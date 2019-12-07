using BaGet.Protocol;
using BaGet.Protocol.Models;
using DevExpress.XtraBars;
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
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var results = Task.Factory.StartNew(() => client.GetPackageMetadataAsync(result.PackageId).Result).Result;
            this.grdDetails.DataSource = results;
        }

        private void btnOpen_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var result = this.grvDetails.GetFocusedRow() as PackageMetadata;
            var frm = new FrmPackageDetail();
            frm.SetData(result);
            frm.Show();
        }

        private void grvPackages_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var results = Task.Factory.StartNew(() => client.GetPackageMetadataAsync(result.PackageId).Result).Result;
            this.grdDetails.DataSource = results;
        }
    }
}
