namespace RFIDSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterActive = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.dataActive = new Zuby.ADGV.AdvancedDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterRegistered = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.dataRegistered = new Zuby.ADGV.AdvancedDataGridView();
            this.Header = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportRegistered = new System.Windows.Forms.Button();
            this.btnExportActive = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEditVal3 = new System.Windows.Forms.TextBox();
            this.txtEditVal2 = new System.Windows.Forms.TextBox();
            this.txtEditVal1 = new System.Windows.Forms.TextBox();
            this.txtEditBirthDay = new System.Windows.Forms.TextBox();
            this.txtEditTel = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.timerrefreshDB = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníPřipojeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportovatDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrovaníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRFIDSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActive)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistered)).BeginInit();
            this.Header.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterActive);
            this.tabPage1.Controls.Add(this.dataActive);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktivní";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filterActive
            // 
            this.filterActive.AllowMerge = false;
            this.filterActive.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.filterActive.Location = new System.Drawing.Point(3, 3);
            this.filterActive.MaximumSize = new System.Drawing.Size(0, 27);
            this.filterActive.MinimumSize = new System.Drawing.Size(0, 27);
            this.filterActive.Name = "filterActive";
            this.filterActive.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.filterActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filterActive.Size = new System.Drawing.Size(1252, 27);
            this.filterActive.TabIndex = 3;
            this.filterActive.Text = "advancedDataGridViewSearchToolBar1";
            this.filterActive.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.filterActive_Search);
            // 
            // dataActive
            // 
            this.dataActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActive.FilterAndSortEnabled = true;
            this.dataActive.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataActive.Location = new System.Drawing.Point(6, 33);
            this.dataActive.MaxFilterButtonImageHeight = 23;
            this.dataActive.Name = "dataActive";
            this.dataActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActive.Size = new System.Drawing.Size(1240, 482);
            this.dataActive.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataActive.TabIndex = 2;
            this.dataActive.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataActive_CellValueChanged);
            this.dataActive.SelectionChanged += new System.EventHandler(this.dataActive_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.filterRegistered);
            this.tabPage2.Controls.Add(this.dataRegistered);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1258, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrovaní";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterRegistered
            // 
            this.filterRegistered.AllowMerge = false;
            this.filterRegistered.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.filterRegistered.Location = new System.Drawing.Point(3, 3);
            this.filterRegistered.MaximumSize = new System.Drawing.Size(0, 27);
            this.filterRegistered.MinimumSize = new System.Drawing.Size(0, 27);
            this.filterRegistered.Name = "filterRegistered";
            this.filterRegistered.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.filterRegistered.Size = new System.Drawing.Size(1252, 27);
            this.filterRegistered.TabIndex = 1;
            this.filterRegistered.Text = "advancedDataGridViewSearchToolBar2";
            this.filterRegistered.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.filterRegistered_Search);
            // 
            // dataRegistered
            // 
            this.dataRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegistered.FilterAndSortEnabled = true;
            this.dataRegistered.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataRegistered.Location = new System.Drawing.Point(6, 33);
            this.dataRegistered.MaxFilterButtonImageHeight = 23;
            this.dataRegistered.Name = "dataRegistered";
            this.dataRegistered.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataRegistered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRegistered.Size = new System.Drawing.Size(1246, 482);
            this.dataRegistered.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dataRegistered.TabIndex = 0;
            this.dataRegistered.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataRegistered_CellMouseClick);
            this.dataRegistered.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataRegistered_DataError);
            this.dataRegistered.SelectionChanged += new System.EventHandler(this.dataRegistered_SelectionChanged);
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.Controls.Add(this.tabPage3);
            this.Header.Controls.Add(this.tabPage5);
            this.Header.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(0, 27);
            this.Header.Name = "Header";
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(1266, 107);
            this.Header.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1258, 79);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Domů";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExportRegistered);
            this.groupBox1.Controls.Add(this.btnExportActive);
            this.groupBox1.Location = new System.Drawing.Point(1059, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Dat";
            // 
            // btnExportRegistered
            // 
            this.btnExportRegistered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportRegistered.BackgroundImage")));
            this.btnExportRegistered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportRegistered.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportRegistered.ForeColor = System.Drawing.Color.White;
            this.btnExportRegistered.Location = new System.Drawing.Point(100, 17);
            this.btnExportRegistered.Name = "btnExportRegistered";
            this.btnExportRegistered.Size = new System.Drawing.Size(87, 44);
            this.btnExportRegistered.TabIndex = 1;
            this.btnExportRegistered.Text = "Exportovat Registrované";
            this.btnExportRegistered.UseVisualStyleBackColor = true;
            this.btnExportRegistered.Click += new System.EventHandler(this.btnExportRegistered_Click);
            // 
            // btnExportActive
            // 
            this.btnExportActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportActive.BackgroundImage")));
            this.btnExportActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportActive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportActive.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportActive.ForeColor = System.Drawing.Color.White;
            this.btnExportActive.Location = new System.Drawing.Point(6, 17);
            this.btnExportActive.Name = "btnExportActive";
            this.btnExportActive.Size = new System.Drawing.Size(87, 44);
            this.btnExportActive.TabIndex = 0;
            this.btnExportActive.Text = "Exportovat Aktivní";
            this.btnExportActive.UseVisualStyleBackColor = true;
            this.btnExportActive.Click += new System.EventHandler(this.btnExportActive_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.btnRefresh);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1258, 79);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Tabulka";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEditVal3);
            this.groupBox2.Controls.Add(this.txtEditVal2);
            this.groupBox2.Controls.Add(this.txtEditVal1);
            this.groupBox2.Controls.Add(this.txtEditBirthDay);
            this.groupBox2.Controls.Add(this.txtEditTel);
            this.groupBox2.Controls.Add(this.txtEditEmail);
            this.groupBox2.Controls.Add(this.txtEditSurname);
            this.groupBox2.Controls.Add(this.txtEditName);
            this.groupBox2.Controls.Add(this.txtEditID);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Editor";
            // 
            // txtEditVal3
            // 
            this.txtEditVal3.Location = new System.Drawing.Point(197, 52);
            this.txtEditVal3.Name = "txtEditVal3";
            this.txtEditVal3.Size = new System.Drawing.Size(89, 18);
            this.txtEditVal3.TabIndex = 8;
            // 
            // txtEditVal2
            // 
            this.txtEditVal2.Location = new System.Drawing.Point(102, 52);
            this.txtEditVal2.Name = "txtEditVal2";
            this.txtEditVal2.Size = new System.Drawing.Size(89, 18);
            this.txtEditVal2.TabIndex = 7;
            // 
            // txtEditVal1
            // 
            this.txtEditVal1.Location = new System.Drawing.Point(7, 52);
            this.txtEditVal1.Name = "txtEditVal1";
            this.txtEditVal1.Size = new System.Drawing.Size(89, 18);
            this.txtEditVal1.TabIndex = 6;
            // 
            // txtEditBirthDay
            // 
            this.txtEditBirthDay.Location = new System.Drawing.Point(464, 18);
            this.txtEditBirthDay.Name = "txtEditBirthDay";
            this.txtEditBirthDay.Size = new System.Drawing.Size(89, 18);
            this.txtEditBirthDay.TabIndex = 5;
            // 
            // txtEditTel
            // 
            this.txtEditTel.Location = new System.Drawing.Point(381, 18);
            this.txtEditTel.Name = "txtEditTel";
            this.txtEditTel.Size = new System.Drawing.Size(77, 18);
            this.txtEditTel.TabIndex = 4;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(255, 18);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(120, 18);
            this.txtEditEmail.TabIndex = 3;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(164, 18);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(85, 18);
            this.txtEditSurname.TabIndex = 2;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(73, 18);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(85, 18);
            this.txtEditName.TabIndex = 1;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(7, 18);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(60, 18);
            this.txtEditID.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1020, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Přidat uživatele manuálně";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddNewuser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1139, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 67);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Vynutit obnovení tabulek";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // timerrefreshDB
            // 
            this.timerrefreshDB.Interval = 500;
            this.timerrefreshDB.Tick += new System.EventHandler(this.timerrefreshDB_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikaceToolStripMenuItem
            // 
            this.aplikaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetovatToolStripMenuItem,
            this.nastaveníPřipojeníToolStripMenuItem,
            this.exportovatDataToolStripMenuItem});
            this.aplikaceToolStripMenuItem.Name = "aplikaceToolStripMenuItem";
            this.aplikaceToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aplikaceToolStripMenuItem.Text = "Aplikace";
            // 
            // resetovatToolStripMenuItem
            // 
            this.resetovatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.resetovatToolStripMenuItem.Name = "resetovatToolStripMenuItem";
            this.resetovatToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetovatToolStripMenuItem.Text = "Resetovat";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.dataToolStripMenuItem.Text = "Data";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // nastaveníPřipojeníToolStripMenuItem
            // 
            this.nastaveníPřipojeníToolStripMenuItem.Name = "nastaveníPřipojeníToolStripMenuItem";
            this.nastaveníPřipojeníToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nastaveníPřipojeníToolStripMenuItem.Text = "Nastavení připojení";
            this.nastaveníPřipojeníToolStripMenuItem.Click += new System.EventHandler(this.nastaveníPřipojeníToolStripMenuItem_Click);
            // 
            // exportovatDataToolStripMenuItem
            // 
            this.exportovatDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivníToolStripMenuItem,
            this.registrovaníToolStripMenuItem});
            this.exportovatDataToolStripMenuItem.Name = "exportovatDataToolStripMenuItem";
            this.exportovatDataToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportovatDataToolStripMenuItem.Text = "Exportovat data";
            // 
            // aktivníToolStripMenuItem
            // 
            this.aktivníToolStripMenuItem.Name = "aktivníToolStripMenuItem";
            this.aktivníToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aktivníToolStripMenuItem.Text = "Aktivní";
            this.aktivníToolStripMenuItem.Click += new System.EventHandler(this.aktivníToolStripMenuItem_Click);
            // 
            // registrovaníToolStripMenuItem
            // 
            this.registrovaníToolStripMenuItem.Name = "registrovaníToolStripMenuItem";
            this.registrovaníToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.registrovaníToolStripMenuItem.Text = "Registrovaní";
            this.registrovaníToolStripMenuItem.Click += new System.EventHandler(this.registrovaníToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(1206, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(58, 681);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRFIDSystemToolStripMenuItem,
            this.ukončitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutRFIDSystemToolStripMenuItem
            // 
            this.aboutRFIDSystemToolStripMenuItem.Name = "aboutRFIDSystemToolStripMenuItem";
            this.aboutRFIDSystemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aboutRFIDSystemToolStripMenuItem.Text = "About RFID System";
            this.aboutRFIDSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutRFIDSystemToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ukončitToolStripMenuItem.Text = "Ukončit";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Main";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActive)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistered)).EndInit();
            this.Header.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl Header;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExportActive;
        private System.Windows.Forms.Button btnExportRegistered;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timerrefreshDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníPřipojeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportovatDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrovaníToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRFIDSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEditBirthDay;
        private System.Windows.Forms.TextBox txtEditTel;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditID;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar filterActive;
        private Zuby.ADGV.AdvancedDataGridView dataActive;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar filterRegistered;
        private Zuby.ADGV.AdvancedDataGridView dataRegistered;
        private System.Windows.Forms.TextBox txtEditVal3;
        private System.Windows.Forms.TextBox txtEditVal2;
        private System.Windows.Forms.TextBox txtEditVal1;
    }
}