namespace NuigetTool
{
    partial class FrmPackageDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackageDetail));
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.proMain = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btnPush = new DevExpress.XtraBars.Navigation.NavButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdDependencies = new DevExpress.XtraGrid.GridControl();
            this.dependencyGroupItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvDependencies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTargetFramework = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryDetails = new DevExpress.XtraVerticalGrid.Rows.PGridOfficeCategoryRow();
            this.rowAuthors = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.row4 = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.row3 = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.row1 = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.rowVersion = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.row = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.row2 = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.rowPid = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            this.rowTitle = new DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.proMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyGroupItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // proMain
            // 
            this.proMain.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office;
            this.proMain.AutoGenerateRows = false;
            this.proMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.proMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.proMain.CustomizationFormBounds = new System.Drawing.Rectangle(626, 251, 267, 345);
            this.proMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proMain.Location = new System.Drawing.Point(0, 0);
            this.proMain.Name = "proMain";
            this.proMain.RecordWidth = 185;
            this.proMain.RowHeaderWidth = 15;
            this.proMain.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryDetails,
            this.rowAuthors,
            this.row4,
            this.row3,
            this.row1,
            this.rowVersion,
            this.row,
            this.row2,
            this.rowPid,
            this.rowDescription,
            this.rowTitle});
            this.proMain.Size = new System.Drawing.Size(1302, 331);
            this.proMain.TabIndex = 0;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.btnPush);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(1302, 40);
            this.tileNavPane1.TabIndex = 1;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // btnPush
            // 
            this.btnPush.Caption = "Push";
            this.btnPush.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPush.ImageOptions.Image")));
            this.btnPush.Name = "btnPush";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.proMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdDependencies);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1302, 896);
            this.splitContainerControl1.SplitterPosition = 331;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // grdDependencies
            // 
            this.grdDependencies.DataSource = this.dependencyGroupItemBindingSource;
            this.grdDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDependencies.Location = new System.Drawing.Point(0, 0);
            this.grdDependencies.MainView = this.grvDependencies;
            this.grdDependencies.Name = "grdDependencies";
            this.grdDependencies.Size = new System.Drawing.Size(1302, 553);
            this.grdDependencies.TabIndex = 0;
            this.grdDependencies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDependencies});
            // 
            // dependencyGroupItemBindingSource
            // 
            this.dependencyGroupItemBindingSource.DataSource = typeof(BaGet.Protocol.Models.DependencyGroupItem);
            // 
            // grvDependencies
            // 
            this.grvDependencies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTargetFramework});
            this.grvDependencies.GridControl = this.grdDependencies;
            this.grvDependencies.Name = "grvDependencies";
            this.grvDependencies.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTargetFramework, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colTargetFramework
            // 
            this.colTargetFramework.FieldName = "TargetFramework";
            this.colTargetFramework.MinWidth = 25;
            this.colTargetFramework.Name = "colTargetFramework";
            this.colTargetFramework.Visible = true;
            this.colTargetFramework.VisibleIndex = 0;
            this.colTargetFramework.Width = 94;
            // 
            // categoryDetails
            // 
            this.categoryDetails.Name = "categoryDetails";
            this.categoryDetails.Properties.Caption = "Details";
            this.categoryDetails.Visible = false;
            // 
            // rowAuthors
            // 
            this.rowAuthors.Name = "rowAuthors";
            this.rowAuthors.Properties.Caption = "Authors";
            this.rowAuthors.Properties.FieldName = "Authors";
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.rowAuthors.Repository = repositoryItemTextEdit1;
            // 
            // row4
            // 
            this.row4.Name = "row4";
            this.row4.Properties.Caption = "Summary ";
            this.row4.Properties.FieldName = "Summary";
            this.row4.Repository = repositoryItemTextEdit1;
            // 
            // row3
            // 
            this.row3.Name = "row3";
            this.row3.Properties.Caption = "Published";
            this.row3.Properties.FieldName = "Published";
            this.row3.Repository = repositoryItemTextEdit1;
            // 
            // row1
            // 
            this.row1.Name = "row1";
            this.row1.Properties.Caption = "Language ";
            this.row1.Properties.FieldName = "Language";
            this.row1.Repository = repositoryItemTextEdit1;
            // 
            // rowVersion
            // 
            this.rowVersion.Name = "rowVersion";
            this.rowVersion.Properties.Caption = "Version";
            this.rowVersion.Properties.FieldName = "Version";
            this.rowVersion.Repository = repositoryItemTextEdit1;
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.Properties.Caption = "PackageContentUrl ";
            this.row.Properties.FieldName = "PackageContentUrl";
            this.row.Repository = repositoryItemTextEdit1;
            // 
            // row2
            // 
            this.row2.Name = "row2";
            this.row2.Properties.Caption = "ProjectUrl ";
            this.row2.Properties.FieldName = "ProjectUrl";
            this.row2.Repository = repositoryItemTextEdit1;
            // 
            // rowPid
            // 
            this.rowPid.Name = "rowPid";
            this.rowPid.Properties.Caption = "PackageId";
            this.rowPid.Properties.FieldName = "PackageId";
            this.rowPid.Repository = repositoryItemTextEdit1;
            // 
            // rowDescription
            // 
            this.rowDescription.Name = "rowDescription";
            this.rowDescription.Properties.Caption = "Description";
            this.rowDescription.Properties.FieldName = "Description";
            this.rowDescription.Repository = repositoryItemTextEdit1;
            // 
            // rowTitle
            // 
            this.rowTitle.Name = "rowTitle";
            this.rowTitle.Properties.Caption = "Title";
            this.rowTitle.Properties.FieldName = "Title";
            this.rowTitle.Repository = repositoryItemTextEdit1;
            // 
            // FrmPackageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 936);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "FrmPackageDetail";
            this.Text = "FrmPackageDetail";
            ((System.ComponentModel.ISupportInitialize)(this.proMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyGroupItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.PropertyGridControl proMain;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btnPush;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grdDependencies;
        private System.Windows.Forms.BindingSource dependencyGroupItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDependencies;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetFramework;
        private DevExpress.XtraVerticalGrid.Rows.PGridOfficeCategoryRow categoryDetails;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow rowAuthors;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow row4;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow rowVersion;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow rowPid;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow rowDescription;
        private DevExpress.XtraVerticalGrid.Rows.PGridTextEditorRow rowTitle;
    }
}