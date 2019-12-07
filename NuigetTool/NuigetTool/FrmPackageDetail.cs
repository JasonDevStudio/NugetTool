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

namespace NuigetTool
{
    public partial class FrmPackageDetail : DevExpress.XtraEditors.XtraForm
    {
        public PackageMetadata Package { get; set; }

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
    }
}