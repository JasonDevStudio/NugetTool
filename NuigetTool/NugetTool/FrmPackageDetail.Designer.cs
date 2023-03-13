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
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btnPush = new DevExpress.XtraBars.Navigation.NavButton();
            this.btnPushAll = new DevExpress.XtraBars.Navigation.NavButton();
            this.grdDependencies = new DevExpress.XtraGrid.GridControl();
            this.dependencyGroupItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvDependencies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTargetFramework = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dlyDetail = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.PackageIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.packageMetadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VersionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AuthorsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LanguageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PackageContentUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProjectUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PublishedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SummaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPackageId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSummary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPublished = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProjectUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackageContentUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAuthors = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVersion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtLocalNugetUrl = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtApiKey = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyGroupItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDependencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlyDetail)).BeginInit();
            this.dlyDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageMetadataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageContentUrlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectUrlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackageId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjectUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackageContentUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalNugetUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApiKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.btnPush);
            this.tileNavPane1.Buttons.Add(this.btnPushAll);
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
            this.tileNavPane1.Size = new System.Drawing.Size(1476, 40);
            this.tileNavPane1.TabIndex = 1;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // btnPush
            // 
            this.btnPush.Caption = "Push";
            this.btnPush.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPush.ImageOptions.Image")));
            this.btnPush.Name = "btnPush";
            this.btnPush.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.BtnPush_ElementClick);
            // 
            // btnPushAll
            // 
            this.btnPushAll.Caption = "Push All";
            this.btnPushAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPushAll.ImageOptions.Image")));
            this.btnPushAll.Name = "btnPushAll";
            this.btnPushAll.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btnPushAll_ElementClick);
            // 
            // grdDependencies
            // 
            this.grdDependencies.DataSource = this.dependencyGroupItemBindingSource;
            this.grdDependencies.Location = new System.Drawing.Point(12, 407);
            this.grdDependencies.MainView = this.grvDependencies;
            this.grdDependencies.Name = "grdDependencies";
            this.grdDependencies.Size = new System.Drawing.Size(724, 477);
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
            // dlyDetail
            // 
            this.dlyDetail.Controls.Add(this.txtApiKey);
            this.dlyDetail.Controls.Add(this.txtLocalNugetUrl);
            this.dlyDetail.Controls.Add(this.memoEdit1);
            this.dlyDetail.Controls.Add(this.grdDependencies);
            this.dlyDetail.Controls.Add(this.PackageIdTextEdit);
            this.dlyDetail.Controls.Add(this.VersionTextEdit);
            this.dlyDetail.Controls.Add(this.AuthorsTextEdit);
            this.dlyDetail.Controls.Add(this.DescriptionTextEdit);
            this.dlyDetail.Controls.Add(this.LanguageTextEdit);
            this.dlyDetail.Controls.Add(this.PackageContentUrlTextEdit);
            this.dlyDetail.Controls.Add(this.ProjectUrlTextEdit);
            this.dlyDetail.Controls.Add(this.PublishedTextEdit);
            this.dlyDetail.Controls.Add(this.SummaryTextEdit);
            this.dlyDetail.DataSource = this.packageMetadataBindingSource;
            this.dlyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlyDetail.Location = new System.Drawing.Point(0, 40);
            this.dlyDetail.Name = "dlyDetail";
            this.dlyDetail.Root = this.Root;
            this.dlyDetail.Size = new System.Drawing.Size(1476, 896);
            this.dlyDetail.TabIndex = 2;
            this.dlyDetail.Text = "dataLayoutControl1";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(740, 407);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(724, 477);
            this.memoEdit1.StyleController = this.dlyDetail;
            this.memoEdit1.TabIndex = 13;
            // 
            // PackageIdTextEdit
            // 
            this.PackageIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "PackageId", true));
            this.PackageIdTextEdit.Location = new System.Drawing.Point(162, 92);
            this.PackageIdTextEdit.Name = "PackageIdTextEdit";
            this.PackageIdTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.PackageIdTextEdit.StyleController = this.dlyDetail;
            this.PackageIdTextEdit.TabIndex = 4;
            // 
            // packageMetadataBindingSource
            // 
            this.packageMetadataBindingSource.DataSource = typeof(BaGet.Protocol.Models.PackageMetadata);
            // 
            // VersionTextEdit
            // 
            this.VersionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Version", true));
            this.VersionTextEdit.Location = new System.Drawing.Point(162, 126);
            this.VersionTextEdit.Name = "VersionTextEdit";
            this.VersionTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.VersionTextEdit.StyleController = this.dlyDetail;
            this.VersionTextEdit.TabIndex = 5;
            // 
            // AuthorsTextEdit
            // 
            this.AuthorsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Authors", true));
            this.AuthorsTextEdit.Location = new System.Drawing.Point(162, 160);
            this.AuthorsTextEdit.Name = "AuthorsTextEdit";
            this.AuthorsTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.AuthorsTextEdit.StyleController = this.dlyDetail;
            this.AuthorsTextEdit.TabIndex = 6;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(162, 194);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.DescriptionTextEdit.StyleController = this.dlyDetail;
            this.DescriptionTextEdit.TabIndex = 7;
            // 
            // LanguageTextEdit
            // 
            this.LanguageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Language", true));
            this.LanguageTextEdit.Location = new System.Drawing.Point(162, 228);
            this.LanguageTextEdit.Name = "LanguageTextEdit";
            this.LanguageTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.LanguageTextEdit.StyleController = this.dlyDetail;
            this.LanguageTextEdit.TabIndex = 8;
            // 
            // PackageContentUrlTextEdit
            // 
            this.PackageContentUrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "PackageContentUrl", true));
            this.PackageContentUrlTextEdit.Location = new System.Drawing.Point(162, 262);
            this.PackageContentUrlTextEdit.Name = "PackageContentUrlTextEdit";
            this.PackageContentUrlTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.PackageContentUrlTextEdit.StyleController = this.dlyDetail;
            this.PackageContentUrlTextEdit.TabIndex = 9;
            // 
            // ProjectUrlTextEdit
            // 
            this.ProjectUrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "ProjectUrl", true));
            this.ProjectUrlTextEdit.Location = new System.Drawing.Point(162, 296);
            this.ProjectUrlTextEdit.Name = "ProjectUrlTextEdit";
            this.ProjectUrlTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.ProjectUrlTextEdit.StyleController = this.dlyDetail;
            this.ProjectUrlTextEdit.TabIndex = 10;
            // 
            // PublishedTextEdit
            // 
            this.PublishedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Published", true));
            this.PublishedTextEdit.Location = new System.Drawing.Point(162, 330);
            this.PublishedTextEdit.Name = "PublishedTextEdit";
            this.PublishedTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.PublishedTextEdit.StyleController = this.dlyDetail;
            this.PublishedTextEdit.TabIndex = 11;
            // 
            // SummaryTextEdit
            // 
            this.SummaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.packageMetadataBindingSource, "Summary", true));
            this.SummaryTextEdit.Location = new System.Drawing.Point(162, 364);
            this.SummaryTextEdit.Name = "SummaryTextEdit";
            this.SummaryTextEdit.Size = new System.Drawing.Size(1287, 24);
            this.SummaryTextEdit.StyleController = this.dlyDetail;
            this.SummaryTextEdit.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1476, 896);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1456, 876);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdDependencies;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 395);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(728, 481);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPackageId,
            this.ItemForSummary,
            this.ItemForPublished,
            this.ItemForProjectUrl,
            this.ItemForPackageContentUrl,
            this.ItemForLanguage,
            this.ItemForDescription,
            this.ItemForAuthors,
            this.ItemForVersion,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1456, 395);
            this.layoutControlGroup2.Text = "Baseic Info";
            // 
            // ItemForPackageId
            // 
            this.ItemForPackageId.Control = this.PackageIdTextEdit;
            this.ItemForPackageId.Location = new System.Drawing.Point(0, 34);
            this.ItemForPackageId.Name = "ItemForPackageId";
            this.ItemForPackageId.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForPackageId.Size = new System.Drawing.Size(1432, 34);
            this.ItemForPackageId.Text = "Package Id";
            this.ItemForPackageId.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForSummary
            // 
            this.ItemForSummary.Control = this.SummaryTextEdit;
            this.ItemForSummary.Location = new System.Drawing.Point(0, 306);
            this.ItemForSummary.Name = "ItemForSummary";
            this.ItemForSummary.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForSummary.Size = new System.Drawing.Size(1432, 34);
            this.ItemForSummary.Text = "Summary";
            this.ItemForSummary.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForPublished
            // 
            this.ItemForPublished.Control = this.PublishedTextEdit;
            this.ItemForPublished.Location = new System.Drawing.Point(0, 272);
            this.ItemForPublished.Name = "ItemForPublished";
            this.ItemForPublished.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForPublished.Size = new System.Drawing.Size(1432, 34);
            this.ItemForPublished.Text = "Published";
            this.ItemForPublished.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForProjectUrl
            // 
            this.ItemForProjectUrl.Control = this.ProjectUrlTextEdit;
            this.ItemForProjectUrl.Location = new System.Drawing.Point(0, 238);
            this.ItemForProjectUrl.Name = "ItemForProjectUrl";
            this.ItemForProjectUrl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForProjectUrl.Size = new System.Drawing.Size(1432, 34);
            this.ItemForProjectUrl.Text = "Project Url";
            this.ItemForProjectUrl.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForPackageContentUrl
            // 
            this.ItemForPackageContentUrl.Control = this.PackageContentUrlTextEdit;
            this.ItemForPackageContentUrl.Location = new System.Drawing.Point(0, 204);
            this.ItemForPackageContentUrl.Name = "ItemForPackageContentUrl";
            this.ItemForPackageContentUrl.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForPackageContentUrl.Size = new System.Drawing.Size(1432, 34);
            this.ItemForPackageContentUrl.Text = "Package Content Url";
            this.ItemForPackageContentUrl.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForLanguage
            // 
            this.ItemForLanguage.Control = this.LanguageTextEdit;
            this.ItemForLanguage.Location = new System.Drawing.Point(0, 170);
            this.ItemForLanguage.Name = "ItemForLanguage";
            this.ItemForLanguage.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForLanguage.Size = new System.Drawing.Size(1432, 34);
            this.ItemForLanguage.Text = "Language";
            this.ItemForLanguage.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 136);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForDescription.Size = new System.Drawing.Size(1432, 34);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForAuthors
            // 
            this.ItemForAuthors.Control = this.AuthorsTextEdit;
            this.ItemForAuthors.Location = new System.Drawing.Point(0, 102);
            this.ItemForAuthors.Name = "ItemForAuthors";
            this.ItemForAuthors.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForAuthors.Size = new System.Drawing.Size(1432, 34);
            this.ItemForAuthors.Text = "Authors";
            this.ItemForAuthors.TextSize = new System.Drawing.Size(132, 18);
            // 
            // ItemForVersion
            // 
            this.ItemForVersion.Control = this.VersionTextEdit;
            this.ItemForVersion.Location = new System.Drawing.Point(0, 68);
            this.ItemForVersion.Name = "ItemForVersion";
            this.ItemForVersion.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForVersion.Size = new System.Drawing.Size(1432, 34);
            this.ItemForVersion.Text = "Version";
            this.ItemForVersion.TextSize = new System.Drawing.Size(132, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(728, 395);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(728, 481);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // txtLocalNugetUrl
            // 
            this.txtLocalNugetUrl.EditValue = "http://localhost:5000/v3/index.json";
            this.txtLocalNugetUrl.Location = new System.Drawing.Point(162, 58);
            this.txtLocalNugetUrl.Name = "txtLocalNugetUrl";
            this.txtLocalNugetUrl.Size = new System.Drawing.Size(571, 24);
            this.txtLocalNugetUrl.StyleController = this.dlyDetail;
            this.txtLocalNugetUrl.TabIndex = 14;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtLocalNugetUrl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(716, 34);
            this.layoutControlItem3.Text = "Local Nuget Server";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(132, 18);
            // 
            // txtApiKey
            // 
            this.txtApiKey.EditValue = "1234567890";
            this.txtApiKey.Location = new System.Drawing.Point(878, 58);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(571, 24);
            this.txtApiKey.StyleController = this.dlyDetail;
            this.txtApiKey.TabIndex = 15;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtApiKey;
            this.layoutControlItem4.Location = new System.Drawing.Point(716, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(716, 34);
            this.layoutControlItem4.Text = "ApiKey";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(132, 18);
            // 
            // FrmPackageDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 936);
            this.Controls.Add(this.dlyDetail);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "FrmPackageDetail";
            this.Text = "FrmPackageDetail";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyGroupItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDependencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlyDetail)).EndInit();
            this.dlyDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageMetadataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageContentUrlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectUrlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublishedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackageId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProjectUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackageContentUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalNugetUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApiKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btnPush;
        private DevExpress.XtraGrid.GridControl grdDependencies;
        private System.Windows.Forms.BindingSource dependencyGroupItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDependencies;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetFramework;
        private DevExpress.XtraDataLayout.DataLayoutControl dlyDetail;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.TextEdit PackageIdTextEdit;
        private System.Windows.Forms.BindingSource packageMetadataBindingSource;
        private DevExpress.XtraEditors.TextEdit VersionTextEdit;
        private DevExpress.XtraEditors.TextEdit AuthorsTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit LanguageTextEdit;
        private DevExpress.XtraEditors.TextEdit PackageContentUrlTextEdit;
        private DevExpress.XtraEditors.TextEdit ProjectUrlTextEdit;
        private DevExpress.XtraEditors.TextEdit PublishedTextEdit;
        private DevExpress.XtraEditors.TextEdit SummaryTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackageId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSummary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPublished;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProjectUrl;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackageContentUrl;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLanguage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAuthors;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVersion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Navigation.NavButton btnPushAll;
        private DevExpress.XtraEditors.TextEdit txtLocalNugetUrl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtApiKey;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}