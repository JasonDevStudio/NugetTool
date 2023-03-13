using BaGet.Protocol;
using BaGet.Protocol.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.grdVersions.DataSource = result.Versions;
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

        private void btnDownlaod_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

        }
    }
}
