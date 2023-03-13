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

namespace NuigetTool
{
    public partial class FrmNuGetTool : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private void Search()
        {
            var keys = this.txtKeys.EditValue.ToString();
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var results = Task.Factory.StartNew(() => client.SearchAsync(keys, this.chePreview.Checked).Result).Result;
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
            try
            {
                var result = this.grvPackages.GetFocusedRow() as SearchResult;
                var version = this.grvVersions.GetFocusedRow() as SearchResultVersion;
                var packageId = result.PackageId;
                var path = ConfigurationManager.AppSettings["DownloadPath"];
                var packagePath = Path.Combine(path, $"{packageId}.{version}.nupkg");
                var client = new NuGetClient("https://api.nuget.org/v3/index.json");
                var packageVersion = new NuGetVersion(version.Version);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (File.Exists(packagePath))
                {
                    WriteLog($"Package [{packageId} {version}] already exists...");
                    await Task.CompletedTask;
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
                            await packageStream.CopyToAsync(fs);
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

        private async Task DownloadsAsync()
        {
            try
            {
                var path = ConfigurationManager.AppSettings["DownloadPath"];
                var downloadCount = Convert.ToInt32(ConfigurationManager.AppSettings["DownloadVersions"]);
                var client = new NuGetClient("https://api.nuget.org/v3/index.json");
                var rowIndexs = this.grvPackages.GetSelectedRows();

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

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
                            var packagePath = Path.Combine(path, $"{packageId}.{version.Version}.nupkg");
                            var packageVersion = new NuGetVersion(version.Version);

                            if (File.Exists(packagePath))
                            {
                                WriteLog($"Package [{packageId} {version.Version}] already exists...");
                                await Task.CompletedTask;
                            }

                            WriteLog($"Start Download package [{packageId} {version.Version}] ...");

                            var isExists = await client.ExistsAsync(packageId, packageVersion);

                            if (isExists)
                            {
                                var packageStream = await client.DownloadPackageAsync(packageId, packageVersion);

                                using (packageStream)
                                {
                                    using (var fs = new FileStream(packagePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                                    {
                                        await packageStream.CopyToAsync(fs);
                                        fs.Close();
                                        WriteLog($"Downloaded package [{packageId} {version.Version}] ...");
                                    }
                                }
                            }
                            else
                            {
                                WriteLog($"NotFound package [{packageId} {version.Version}] ...");
                            }
                        }

                        WriteLog($"Download package [{packageId} completed.");
                    }
                }
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

        private void btnSearch_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Search();
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

        private void txtKeys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
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
    }
}
