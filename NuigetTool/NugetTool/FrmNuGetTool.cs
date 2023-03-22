using BaGet.Protocol;
using BaGet.Protocol.Models;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using System.Diagnostics;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using NuGet.Protocol;
using System.Threading;
using NugetTool.Properties;
using DevExpress.XtraPrinting.Native.Lines;

namespace NuigetTool
{
    public partial class FrmNuGetTool : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private async Task SearchAsync()
        {
            var keys = this.txtKeys.EditValue.ToString();
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var results = await client.SearchAsync(keys, this.chePreview.Checked);
            this.grdPackages.DataSource = results;
        }

        private void WriteLog(string msg)
        {
            Action<string> act = s =>
            {
                this.medLog.Text += $"{s}{Environment.NewLine}";
                this.medLog.SelectionStart = this.medLog.Text.Length;
                this.medLog.ScrollToCaret();
            };

            this.Invoke(act, msg);
        }

        private async Task DownloadAsync()
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var version = this.grvVersions.GetFocusedRow() as SearchResultVersion;
            var packageId = result.PackageId;
            await this.DownloadPackageAsync(packageId, version.Version);
            await this.DownloadDependenciesAsync(packageId, version.Version);
            WriteLog($"--------------------------------------Download End--------------------------------------");
        }

        private async Task DownloadsAsync()
        {
            try
            {
                var tasks = new List<Task>();
                var downloadCount = Convert.ToInt32(ConfigurationManager.AppSettings["DownloadVersions"]);
                var rowIndexs = this.grvPackages.GetSelectedRows();

                if (rowIndexs?.Any() ?? false)
                {
                    foreach (var rowIndex in rowIndexs)
                    {
                        var row = this.grvPackages.GetRow(rowIndex) as SearchResult;
                        var versions = row.Versions.OrderByDescending(m => new NuGetVersion(m.Version)).ToList();
                        var packageId = row.PackageId;
                        var verCount = versions.Count > downloadCount ? downloadCount : versions.Count;

                        for (int i = 0; i < verCount; i++)
                        {
                            var version = versions[i];
                            var packageVersion = new NuGetVersion(version.Version);

                            tasks.Add(this.DownloadPackageAsync(packageId, version.Version));
                            tasks.Add(this.DownloadDependenciesAsync(packageId, version.Version));
                        }
                    }

                    if (tasks?.Any() ?? false)
                    {
                        await Task.WhenAll(tasks);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog($"{ex}");
            }

            WriteLog($"--------------------------------------Download End--------------------------------------");
        }

        private async Task BatchDownloadAsync()
        {
            try
            {
                var tasks = new List<Task>();
                var keys = this.txtKeys.EditValue.ToString();
                var lines = keys.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                var client = new NuGetClient("https://api.nuget.org/v3/index.json");
                var downloadCount = Convert.ToInt32(ConfigurationManager.AppSettings["DownloadVersions"]);

                foreach (string line in lines)
                {
                    var packages = await client.GetPackageMetadataAsync(line.Trim());
                    if (packages?.Any() ?? false)
                    {
                        var count = packages.Count > downloadCount ? downloadCount : packages.Count;
                        packages = packages.OrderByDescending(x => x.Version).ToList();

                        for (int i = 0; i < count; i++)
                        {
                            var version = packages[i].Version;
                            var packageId = packages[i].PackageId;
                            tasks.Add(this.DownloadPackageAsync(packageId, version));
                            tasks.Add(this.DownloadDependenciesAsync(packageId, version));
                        }
                    }

                    if (tasks?.Any() ?? false)
                    {
                        await Task.WhenAll(tasks);
                    }

                    WriteLog($"--------------------------------------Download {line} End--------------------------------------");
                }
            }
            catch (Exception ex)
            {
                WriteLog($"{ex}");
            }
        }

        private async Task DownloadPackageAsync(string packageId, string version)
        {
            try
            {
                var path = ConfigurationManager.AppSettings["DownloadPath"];
                var packagePath = Path.Combine(path, $"{packageId}.{version}.nupkg");
                var client = new NuGetClient("https://api.nuget.org/v3/index.json");
                var packageVersion = new NuGetVersion(version);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (File.Exists(packagePath))
                {
                    WriteLog($"Package [{packageId} {version}] already exists...");
                    return;
                }


                WriteLog($"Start Download package [{packageId} {version}] ...");

                var isExists = await client.ExistsAsync(packageId, packageVersion);

                if (isExists)
                {
                    var packageStream = await client.DownloadPackageAsync(packageId, packageVersion);

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

        private async Task DownloadDependenciesAsync(string packageId, string version)
        {
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var package = await client.GetPackageMetadataAsync(packageId, new NuGetVersion(version));

            if (package?.DependencyGroups?.Any() ?? false)
            {
                foreach (var item in package.DependencyGroups)
                {
                    WriteLog($"Start Read DependencyGroups [{item.TargetFramework}] ...");

                    if (item?.Dependencies?.Any() ?? false)
                    {
                        foreach (var dep in item.Dependencies)
                        {
                            WriteLog($"Start Read Dependencies [{dep.Id}] ...");

                            var vers = dep.Range.Split(',');
                            var ver = vers.FirstOrDefault().Replace("[", string.Empty);
                            await DownloadPackageAsync(dep.Id, ver);
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
        }

        public async Task Push1Async()
        {
            await Task.Run(() =>
            {
                try
                {
                    var apiKey = ConfigurationManager.AppSettings["ApiKey"];
                    var nugetServer = ConfigurationManager.AppSettings["NugetServer"];
                    var downloadPath = ConfigurationManager.AppSettings["DownloadPath"];
                    var files = Directory.GetFiles(downloadPath, "*.nupkg");
                    var nugetPaht = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nuget.exe");

                    if (!File.Exists(nugetPaht))
                    {
                        using (var fs = new FileStream(nugetPaht, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(Resource.nuget, 0, Resource.nuget.Length);
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
                        var pushCmd = $"\"{nugetPaht}\" push -Source {nugetServer} \"{item}\" -ApiKey {apiKey}";
                        process.StandardInput.WriteLine(pushCmd);
                    }

                    process.StandardInput.WriteLine("exit");
                    process.WaitForExit();
                    WriteLog($"------------------------------------End Push------------------------------------");
                    WriteLog($"");

                    foreach (var item in files)
                        File.Delete(item);
                }
                catch (Exception ex)
                {
                    WriteLog($"{ex}");
                }
            });
        }

        public async Task PushAsync()
        {
            try
            {
                var tasks = new List<Task>();
                var apiKey = ConfigurationManager.AppSettings["ApiKey"];
                var nugetServer = ConfigurationManager.AppSettings["NugetServer"];
                var downloadPath = ConfigurationManager.AppSettings["DownloadPath"];
                var files = Directory.GetFiles(downloadPath, "*.nupkg");
                var nugetPaht = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nuget.exe");

                if (!File.Exists(nugetPaht))
                {
                    using (var fs = new FileStream(nugetPaht, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(Resource.nuget, 0, Resource.nuget.Length);
                        fs.Close();
                        fs.Dispose();
                    }
                }

                foreach (var item in files)
                {
                    var task = Task.Factory.StartNew(obj =>
                    {
                        var pushCmd = $"\"{nugetPaht}\" push -Source {nugetServer} \"{obj}\" -ApiKey {apiKey}";
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
                        process.StandardInput.WriteLine(pushCmd);
                        process.StandardInput.WriteLine("exit");
                        process.WaitForExit();

                        WriteLog($"------------------------------------{obj} push end------------------------------------");
                    }, item);

                    tasks.Add(task);
                }

                await Task.WhenAll(tasks);
                WriteLog($"========================================End Push========================================");
                WriteLog($"");

                foreach (var item in files)
                    File.Delete(item);
            }
            catch (Exception ex)
            {
                WriteLog($"{ex}");
            }
        }

        public void GetListPackageVersions()
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var versions = Task.Factory.StartNew(() => client.ListPackageVersionsAsync(result.PackageId, chePreview.Checked, default).Result).Result;
            this.grdVersions.DataSource = versions;
        }

        public void GetListPackageVersions2()
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            this.grdVersions.DataSource = result.Versions.OrderByDescending(m => new NuGetVersion(m.Version).Version).ToList();
        }

        public FrmNuGetTool()
        {
            InitializeComponent();
        }

        private async void btnSearch_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await SearchAsync();
        }

        private void btnDetail_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            GetListPackageVersions();
        }

        private void btnOpen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var version = this.grvVersions.GetFocusedRow() as SearchResultVersion;
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");

            var isExists = Task.Factory.StartNew(() => client.ExistsAsync(result.PackageId, new NuGetVersion(version.Version)).Result).Result;

            if (isExists)
            {
                var package = Task.Factory.StartNew(() => client.GetPackageMetadataAsync(result.PackageId, new NuGetVersion(version.Version)).Result).Result;
                var frm = new FrmPackageDetail();
                frm.SetData(package);
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Not Found");
            }
        }

        private void grvPackages_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GetListPackageVersions2();
        }

        private void FrmNuGetTool_Load(object sender, EventArgs e)
        {
            this.txtKeys.Focus();
        }

        private async void txtKeys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await SearchAsync();
            }
        }

        private void btnPush_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

        }

        private async void btnDownlaod_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await DownloadAsync();
        }

        private async void btnDownLoads_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await DownloadsAsync();
        }

        private async void btnBatchDownload_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await this.BatchDownloadAsync();
        }

        private async void btnPush_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await this.PushAsync();
        }

        private async void btnPushPackages_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            await this.Push1Async();
        }
    }
}
