using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaGet.Protocol.Models;
using BaGet.Protocol;
using NuGet.Versioning;
using System.IO;
using System.Diagnostics;

namespace NuigetTool
{
    public partial class FrmPackageDetail : DevExpress.XtraEditors.XtraForm
    {
        public PackageMetadata Package { get; set; }

        private string localNugetServer = "";
        private string apiKey = "";

        public FrmPackageDetail()
        {
            InitializeComponent();
        }

        public void SetData(PackageMetadata package)
        {
            this.Package = package;
            this.dlyDetail.DataSource = this.Package;
            this.grdDependencies.DataSource = this.Package.DependencyGroups;

            for (int i = 0; i < this.grvDependencies.RowCount; i++)
            {
                this.grvDependencies.ExpandMasterRow(i);
            }
        }

        private void WriteLog(string msg)
        {
            Action<string> act = s =>
            {
                this.memoEdit1.Text += $"{s}{Environment.NewLine}";
                this.memoEdit1.SelectionStart = this.memoEdit1.Text.Length;
                this.memoEdit1.ScrollToCaret();
            };

            this.Invoke(act, msg);
        }

        private void DownloadPackage(string packageId, string version)
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "packages");
                var packagePath = Path.Combine(path, $"{packageId}.{version}.nupkg");
                var client = new NuGetClient("https://api.nuget.org/v3/index.json");
                var packageVersion = new NuGetVersion(version);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (File.Exists(packagePath))
                {
                    WriteLog($"Package [{packageId} {version}] already exists...");
                    return;
                }


                WriteLog($"Start Download package [{packageId} {version}] ...");

                var isExists = Task.Factory.StartNew(() => client.ExistsAsync(packageId, packageVersion).Result).Result;

                if (isExists)
                {
                    var packageStream = Task.Factory.StartNew(() => client.GetPackageStreamAsync(packageId, packageVersion).Result).Result;

                    using (packageStream)
                    {
                        using (var fs = new FileStream(packagePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            packageStream.CopyTo(fs);
                            fs.Close();
                            WriteLog($"Downloaded package [{packageId} {version}] ...");
                        }
                    }
                }
                else
                {
                    WriteLog($"NotFound package [{packageId} {version}] ...");
                }
            }
            catch (Exception ex)
            {
                WriteLog($"{ex}");
            }
        }

        private void DownloadAll()
        {
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var packageId = this.Package.PackageId;
            DownloadPackage(packageId, this.Package.Version);

            if (this.Package.DependencyGroups != null && this.Package.DependencyGroups.Count > 0)
            {
                foreach (var item in this.Package.DependencyGroups)
                {
                    WriteLog($"Start Read DependencyGroups [{item.TargetFramework}] ...");

                    if (item.Dependencies != null && item.Dependencies.Count > 0)
                    {
                        foreach (var dep in item.Dependencies)
                        {
                            WriteLog($"Start Read Dependencies [{dep.Id}] ...");

                            var searchResults = Task.Factory.StartNew(() => client.SearchAsync(dep.Id, true).Result).Result;

                            if (searchResults != null && searchResults.Count > 0)
                            {
                                foreach (var sea in searchResults)
                                {
                                    if (sea.PackageId == dep.Id)
                                    {
                                        foreach (var ver in sea.Versions)
                                        {
                                            DownloadPackage(dep.Id, ver.Version);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                WriteLog($"Not Found Dependencies [{dep.Id}] versions ...");
                            }
                        }
                    }
                    else
                    {
                        WriteLog($"Not Found DependencyGroups [{item.TargetFramework}] ...");
                    }
                }
            }
            else
            {
                WriteLog($"Not Found DependencyGroups...");
            }

            WriteLog($"========================End===DownLoad==========================");
            WriteLog($"");
            Push();
        }

        private void Download()
        {
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var packageId = this.Package.PackageId;
            DownloadPackage(packageId, this.Package.Version);

            if (this.Package.DependencyGroups != null && this.Package.DependencyGroups.Count > 0)
            {
                foreach (var item in this.Package.DependencyGroups)
                {
                    WriteLog($"Start Read DependencyGroups [{item.TargetFramework}] ...");

                    if (item.Dependencies != null && item.Dependencies.Count > 0)
                    {
                        foreach (var dep in item.Dependencies)
                        {
                            WriteLog($"Start Read Dependencies [{dep.Id}] ...");

                            var vers = dep.Range.Split(',');
                            var ver = vers.FirstOrDefault().Replace("[",string.Empty);
                            DownloadPackage(dep.Id, ver);

                            //var searchResults = Task.Factory.StartNew(() => client.SearchAsync(dep.Id, true).Result).Result;

                            //if (searchResults != null && searchResults.Count > 0)
                            //{
                            //    foreach (var sea in searchResults)
                            //    {
                            //        if (sea.PackageId == dep.Id)
                            //        {
                            //            foreach (var ver in sea.Versions)
                            //            {
                            //                DownloadPackage(dep.Id, ver.Version);
                            //            }
                            //        } 
                            //    }
                            //}
                            //else
                            //{
                            //    WriteLog($"Not Found Dependencies [{dep.Id}] versions ...");
                            //}
                        }
                    }
                    else
                    {
                        WriteLog($"Not Found DependencyGroups [{item.TargetFramework}] ...");
                    }
                }
            }
            else
            {
                WriteLog($"Not Found DependencyGroups...");
            }

            WriteLog($"========================End===DownLoad==========================");
            WriteLog($"");
            Push();
        }

        public void Push()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "packages");
            var files = Directory.GetFiles(path, "*.nupkg");
            var nugetPaht = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nuget.exe");

            if (!File.Exists(nugetPaht))
            {
                using (var fs = new FileStream(nugetPaht, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(Properties.Resources.nuget, 0, Properties.Resources.nuget.Length);
                    fs.Close();
                    fs.Dispose();
                }
            }

            var process = new Process();
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += (s, e) => WriteLog(e.Data);
            process.ErrorDataReceived += (s, e) => WriteLog(e.Data);
            process.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            foreach (var item in files)
            {
                var pushCmd = $"\"{nugetPaht}\" push -Source {localNugetServer} \"{item}\" -ApiKey {apiKey}";
                process.StandardInput.WriteLine(pushCmd);
            }

            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            WriteLog($"========================End===Push==========================");
            WriteLog($"");
        }

        private void BtnPush_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            localNugetServer = this.txtLocalNugetUrl.EditValue.ToString();
            apiKey = this.txtApiKey.EditValue.ToString();
            Task.Factory.StartNew(() => Download()); 
        }

        private void btnPushAll_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            localNugetServer = this.txtLocalNugetUrl.EditValue.ToString();
            apiKey = this.txtApiKey.EditValue.ToString();
            Task.Factory.StartNew(() => DownloadAll());
        }
    }
}