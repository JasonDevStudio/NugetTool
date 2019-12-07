﻿namespace NuigetTool
{
    partial class FrmNuGetTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuGetTool));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chePreview = new DevExpress.XtraEditors.CheckEdit();
            this.grdVersions = new DevExpress.XtraGrid.GridControl();
            this.searchResultVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvVersions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegistrationLeafUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDownloads = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdPackages = new DevExpress.XtraGrid.GridControl();
            this.searchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvPackages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPackageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthors = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIconUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistrationIndexUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTags = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDownloads = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKeys = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tnpMain = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btnSearch = new DevExpress.XtraBars.Navigation.NavButton();
            this.btnDetail = new DevExpress.XtraBars.Navigation.NavButton();
            this.btnOpen = new DevExpress.XtraBars.Navigation.NavButton();
            this.packageMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chePreview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnpMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageMetadataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.layoutControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.tnpMain);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 37);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1513, 810);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chePreview);
            this.layoutControl1.Controls.Add(this.grdVersions);
            this.layoutControl1.Controls.Add(this.grdPackages);
            this.layoutControl1.Controls.Add(this.txtKeys);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(952, 471, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1513, 770);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chePreview
            // 
            this.chePreview.EditValue = true;
            this.chePreview.Location = new System.Drawing.Point(1407, 58);
            this.chePreview.Name = "chePreview";
            this.chePreview.Properties.Caption = "Preview";
            this.chePreview.Size = new System.Drawing.Size(79, 24);
            this.chePreview.StyleController = this.layoutControl1;
            this.chePreview.TabIndex = 9;
            // 
            // grdVersions
            // 
            this.grdVersions.DataSource = this.searchResultVersionBindingSource;
            this.grdVersions.Location = new System.Drawing.Point(1047, 89);
            this.grdVersions.MainView = this.grvVersions;
            this.grdVersions.Name = "grdVersions";
            this.grdVersions.Size = new System.Drawing.Size(442, 657);
            this.grdVersions.TabIndex = 8;
            this.grdVersions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvVersions});
            // 
            // searchResultVersionBindingSource
            // 
            this.searchResultVersionBindingSource.DataSource = typeof(BaGet.Protocol.Models.SearchResultVersion);
            // 
            // grvVersions
            // 
            this.grvVersions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegistrationLeafUrl,
            this.colVersion1,
            this.colDownloads});
            this.grvVersions.GridControl = this.grdVersions;
            this.grvVersions.Name = "grvVersions";
            this.grvVersions.OptionsBehavior.Editable = false;
            // 
            // colRegistrationLeafUrl
            // 
            this.colRegistrationLeafUrl.FieldName = "RegistrationLeafUrl";
            this.colRegistrationLeafUrl.MinWidth = 25;
            this.colRegistrationLeafUrl.Name = "colRegistrationLeafUrl";
            this.colRegistrationLeafUrl.Visible = true;
            this.colRegistrationLeafUrl.VisibleIndex = 0;
            this.colRegistrationLeafUrl.Width = 94;
            // 
            // colVersion1
            // 
            this.colVersion1.FieldName = "Version";
            this.colVersion1.MinWidth = 25;
            this.colVersion1.Name = "colVersion1";
            this.colVersion1.Visible = true;
            this.colVersion1.VisibleIndex = 1;
            this.colVersion1.Width = 94;
            // 
            // colDownloads
            // 
            this.colDownloads.FieldName = "Downloads";
            this.colDownloads.MinWidth = 25;
            this.colDownloads.Name = "colDownloads";
            this.colDownloads.Width = 94;
            // 
            // grdPackages
            // 
            this.grdPackages.DataSource = this.searchResultBindingSource;
            this.grdPackages.Location = new System.Drawing.Point(24, 89);
            this.grdPackages.MainView = this.grvPackages;
            this.grdPackages.Name = "grdPackages";
            this.grdPackages.Size = new System.Drawing.Size(1019, 657);
            this.grdPackages.TabIndex = 5;
            this.grdPackages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPackages});
            // 
            // searchResultBindingSource
            // 
            this.searchResultBindingSource.DataSource = typeof(BaGet.Protocol.Models.SearchResult);
            // 
            // grvPackages
            // 
            this.grvPackages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPackageId,
            this.colVersion,
            this.colDescription,
            this.colAuthors,
            this.colIconUrl,
            this.colLicenseUrl,
            this.colProjectUrl,
            this.colRegistrationIndexUrl,
            this.colSummary,
            this.colTags,
            this.colTitle,
            this.colTotalDownloads,
            this.colVersions});
            this.grvPackages.GridControl = this.grdPackages;
            this.grvPackages.Name = "grvPackages";
            this.grvPackages.OptionsBehavior.Editable = false;
            this.grvPackages.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvPackages.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.grvPackages.OptionsDetail.AutoZoomDetail = true;
            this.grvPackages.OptionsFind.AlwaysVisible = true;
            this.grvPackages.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTitle, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVersion, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grvPackages.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvPackages_RowClick);
            // 
            // colPackageId
            // 
            this.colPackageId.FieldName = "PackageId";
            this.colPackageId.MinWidth = 25;
            this.colPackageId.Name = "colPackageId";
            this.colPackageId.Visible = true;
            this.colPackageId.VisibleIndex = 0;
            this.colPackageId.Width = 264;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.MinWidth = 25;
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 1;
            this.colVersion.Width = 151;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 151;
            // 
            // colAuthors
            // 
            this.colAuthors.FieldName = "Authors";
            this.colAuthors.MinWidth = 25;
            this.colAuthors.Name = "colAuthors";
            this.colAuthors.Width = 151;
            // 
            // colIconUrl
            // 
            this.colIconUrl.FieldName = "IconUrl";
            this.colIconUrl.MinWidth = 25;
            this.colIconUrl.Name = "colIconUrl";
            this.colIconUrl.Width = 151;
            // 
            // colLicenseUrl
            // 
            this.colLicenseUrl.FieldName = "LicenseUrl";
            this.colLicenseUrl.MinWidth = 25;
            this.colLicenseUrl.Name = "colLicenseUrl";
            this.colLicenseUrl.Width = 151;
            // 
            // colProjectUrl
            // 
            this.colProjectUrl.FieldName = "ProjectUrl";
            this.colProjectUrl.MinWidth = 25;
            this.colProjectUrl.Name = "colProjectUrl";
            this.colProjectUrl.Visible = true;
            this.colProjectUrl.VisibleIndex = 3;
            this.colProjectUrl.Width = 151;
            // 
            // colRegistrationIndexUrl
            // 
            this.colRegistrationIndexUrl.FieldName = "RegistrationIndexUrl";
            this.colRegistrationIndexUrl.MinWidth = 25;
            this.colRegistrationIndexUrl.Name = "colRegistrationIndexUrl";
            this.colRegistrationIndexUrl.Width = 151;
            // 
            // colSummary
            // 
            this.colSummary.FieldName = "Summary";
            this.colSummary.MinWidth = 25;
            this.colSummary.Name = "colSummary";
            this.colSummary.Width = 151;
            // 
            // colTags
            // 
            this.colTags.FieldName = "Tags";
            this.colTags.MinWidth = 25;
            this.colTags.Name = "colTags";
            this.colTags.Width = 151;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 25;
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 216;
            // 
            // colTotalDownloads
            // 
            this.colTotalDownloads.FieldName = "TotalDownloads";
            this.colTotalDownloads.MinWidth = 25;
            this.colTotalDownloads.Name = "colTotalDownloads";
            this.colTotalDownloads.Visible = true;
            this.colTotalDownloads.VisibleIndex = 4;
            this.colTotalDownloads.Width = 151;
            // 
            // colVersions
            // 
            this.colVersions.FieldName = "Versions";
            this.colVersions.MinWidth = 25;
            this.colVersions.Name = "colVersions";
            this.colVersions.Width = 174;
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(116, 58);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(1281, 24);
            this.txtKeys.StyleController = this.layoutControl1;
            this.txtKeys.TabIndex = 4;
            this.txtKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeys_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1513, 770);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1493, 750);
            this.layoutControlGroup1.Text = "Search";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtKeys;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(1380, 34);
            this.layoutControlItem1.Text = "Search Keys:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdPackages;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1023, 661);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grdVersions;
            this.layoutControlItem3.Location = new System.Drawing.Point(1023, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(446, 661);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chePreview;
            this.layoutControlItem4.Location = new System.Drawing.Point(1380, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(89, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // tnpMain
            // 
            this.tnpMain.Buttons.Add(this.btnSearch);
            this.tnpMain.Buttons.Add(this.btnDetail);
            this.tnpMain.Buttons.Add(this.btnOpen);
            // 
            // tileNavCategory1
            // 
            this.tnpMain.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tnpMain.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tnpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tnpMain.Location = new System.Drawing.Point(0, 0);
            this.tnpMain.Name = "tnpMain";
            this.tnpMain.Size = new System.Drawing.Size(1513, 40);
            this.tnpMain.TabIndex = 0;
            this.tnpMain.Text = "tileNavPane1";
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Search";
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btnSearch_ElementClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.Image")));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btnDetail_ElementClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.ImageOptions.Image")));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btnOpen_ElementClick);
            // 
            // packageMetadataBindingSource
            // 
            this.packageMetadataBindingSource.DataSource = typeof(BaGet.Protocol.Models.PackageMetadata);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1513, 37);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FrmNuGetTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 847);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "FrmNuGetTool";
            this.Text = "Nuget Tool";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FrmNuGetTool_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chePreview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnpMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageMetadataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.TileNavPane tnpMain;
        private DevExpress.XtraBars.Navigation.NavButton btnOpen;
        private DevExpress.XtraBars.Navigation.NavButton btnSearch;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Navigation.NavButton btnDetail;
        private DevExpress.XtraEditors.TextEdit txtKeys;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl grdPackages;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPackages;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource searchResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageId;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthors;
        private DevExpress.XtraGrid.Columns.GridColumn colIconUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationIndexUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colTags;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDownloads;
        private DevExpress.XtraGrid.Columns.GridColumn colVersions;
        private System.Windows.Forms.BindingSource packageMetadataBindingSource;
        private DevExpress.XtraGrid.GridControl grdVersions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvVersions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource searchResultVersionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationLeafUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDownloads;
        private DevExpress.XtraEditors.CheckEdit chePreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

