using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaGet.Protocol;
using BaGet.Protocol.Models;
using DevExpress.XtraEditors;
using NuGet.Versioning;
using NugetTool.Properties;

namespace NuigetTool
{
    public partial class FrmNuGetTool : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private NuGetClient CreateClient()
        {
            var enable = Convert.ToBoolean(ConfigurationManager.AppSettings["http_proxy.enable"]);
            var userName = ConfigurationManager.AppSettings["http_proxy.user"];
            var userPwd = ConfigurationManager.AppSettings["http_proxy.password"];
            var proxyUrl = ConfigurationManager.AppSettings["http_proxy.url"];

            if (enable)
            {
                // 创建一个NetworkCredential对象，指定代理的账号密码
                var credential = new NetworkCredential(userName, userPwd);

                // 创建一个WebProxy实例，传入代理服务器的地址和端口，以及NetworkCredential对象
                var proxy = new System.Net.WebProxy(proxyUrl) { Credentials = credential };

                var httpClient = new HttpClient(new HttpClientHandler { Proxy = proxy, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
                var factory = new NuGetClientFactory(httpClient, "https://api.nuget.org/v3/index.json");
                var client = new NuGetClient(factory);
                return client;
            }
            else
            {
                var httpClient = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
                var factory = new NuGetClientFactory(httpClient, "https://api.nuget.org/v3/index.json");
                var client = new NuGetClient(factory);
                return client; 
            }
        }

        private async Task SearchAsync()
        {
            var _client = this.CreateClient();
            var results = new List<SearchResult>();
            var keys = this.txtKeys.EditValue.ToString();
            var lines = keys.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var tmp = await _client.SearchAsync(line, this.chePreview.Checked);
                    results.AddRange(tmp);
                }
            }

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
            var versions = this.grvVersions.GetSelectedRows().Select(m => this.grvVersions.GetRow(m) as SearchResultVersion).ToList();

            foreach (var version in versions)
            {
                var packageId = result.PackageId;
                await this.DownloadPackageAsync(packageId, version.Version);
                await this.DownloadDependenciesAsync(packageId, version.Version);
                WriteLog($"--------------------------------------Download [{version.Version}] End--------------------------------------");
            }


            WriteLog($"--------------------------------------Download [{result.PackageId}] End--------------------------------------");
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
                var downloadCount = Convert.ToInt32(ConfigurationManager.AppSettings["DownloadVersions"]);
                var _client = this.CreateClient();

                foreach (string line in lines)
                {
                    var packages = await _client.GetPackageMetadataAsync(line.Trim());
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
                var _client = this.CreateClient();
                var path = ConfigurationManager.AppSettings["DownloadPath"];
                var packagePath = Path.Combine(path, $"{packageId}.{version}.nupkg");
                var packageVersion = new NuGetVersion(version);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (File.Exists(packagePath))
                {
                    WriteLog($"Package [{packageId} {version}] already exists...");
                    return;
                }


                WriteLog($"Start Download package [{packageId} {version}] ...");

                var isExists = await _client.ExistsAsync(packageId, packageVersion);

                if (isExists)
                {
                    var packageStream = await _client.DownloadPackageAsync(packageId, packageVersion);

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
            var _client = this.CreateClient();
            var package = await _client.GetPackageMetadataAsync(packageId, new NuGetVersion(version));

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
            var _client = this.CreateClient();
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var versions = Task.Factory.StartNew(() => _client.ListPackageVersionsAsync(result.PackageId, chePreview.Checked, default).Result).Result;
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

        private void btnOpen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var _client = this.CreateClient();
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var version = this.grvVersions.GetFocusedRow() as SearchResultVersion;

            var isExists = Task.Factory.StartNew(() => _client.ExistsAsync(result.PackageId, new NuGetVersion(version.Version)).Result).Result;

            if (isExists)
            {
                var package = Task.Factory.StartNew(() => _client.GetPackageMetadataAsync(result.PackageId, new NuGetVersion(version.Version)).Result).Result;
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
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                await SearchAsync();
                e.Handled = true;
                return;
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

        private void btnOpenFolder_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var folderPath = ConfigurationManager.AppSettings["DownloadPath"];
            Process.Start("explorer.exe", folderPath);
        }
    }
}
