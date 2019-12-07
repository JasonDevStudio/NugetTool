using BaGet.Protocol;
using BaGet.Protocol.Models;
using DevExpress.XtraBars;
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
        public FrmNuGetTool()
        {
            InitializeComponent();
        }

        private void btnSearch_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var keys = this.txtKeys.EditValue.ToString();
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var results = Task.Factory.StartNew(()=> client.SearchAsync(keys).Result).Result ;
            this.grdPackages.DataSource = results;             
        }

        private void btnDetail_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            this.grdVersions.DataSource = result.Versions;
        }

        private void btnOpen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var version = this.grvVersions.GetFocusedRow() as NuGetVersion;
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var package = Task.Factory.StartNew(() => client.GetPackageMetadataAsync(result.PackageId, version).Result).Result;
             
            var frm = new FrmPackageDetail();
            frm.SetData(package);
            frm.Show();
        }

        private void grvPackages_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //var result = this.grvPackages.GetFocusedRow() as SearchResult;
            //var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            //var versions = Task.Factory.StartNew(() => client.ListPackageVersionsAsync(result.PackageId,default).Result).Result;
            //this.grdVersions.DataSource = versions;

            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var versions = result.Versions;
        }
    }
}
