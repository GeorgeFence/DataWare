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
            this.dataActive = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataRegistered = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportRegistered = new System.Windows.Forms.Button();
            this.btnExportActive = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblChecking = new System.Windows.Forms.Label();
            this.txtRFIDOut = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnAddNewuser = new System.Windows.Forms.Button();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.timerrefreshDB = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActive)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistered)).BeginInit();
            this.Header.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataActive);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktivní";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataActive
            // 
            this.dataActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataActive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActive.Location = new System.Drawing.Point(6, 6);
            this.dataActive.Name = "dataActive";
            this.dataActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActive.Size = new System.Drawing.Size(1246, 543);
            this.dataActive.TabIndex = 1;
            this.dataActive.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataActive_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataRegistered);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1258, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrovaní";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataRegistered
            // 
            this.dataRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegistered.Location = new System.Drawing.Point(6, 6);
            this.dataRegistered.Name = "dataRegistered";
            this.dataRegistered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRegistered.Size = new System.Drawing.Size(1246, 543);
            this.dataRegistered.TabIndex = 0;
            this.dataRegistered.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataRegistered_CellMouseClick);
            this.dataRegistered.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataRegistered_DataError);
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.Controls.Add(this.tabPage3);
            this.Header.Controls.Add(this.tabPage4);
            this.Header.Controls.Add(this.tabPage5);
            this.Header.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(1266, 100);
            this.Header.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnExportRegistered);
            this.tabPage3.Controls.Add(this.btnExportActive);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1258, 72);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Soubor";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(192, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(192, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportRegistered
            // 
            this.btnExportRegistered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportRegistered.BackgroundImage")));
            this.btnExportRegistered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportRegistered.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportRegistered.ForeColor = System.Drawing.Color.White;
            this.btnExportRegistered.Location = new System.Drawing.Point(6, 6);
            this.btnExportRegistered.Name = "btnExportRegistered";
            this.btnExportRegistered.Size = new System.Drawing.Size(87, 61);
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
            this.btnExportActive.Location = new System.Drawing.Point(99, 6);
            this.btnExportActive.Name = "btnExportActive";
            this.btnExportActive.Size = new System.Drawing.Size(87, 61);
            this.btnExportActive.TabIndex = 0;
            this.btnExportActive.Text = "Exportovat Aktivní";
            this.btnExportActive.UseVisualStyleBackColor = true;
            this.btnExportActive.Click += new System.EventHandler(this.btnExportActive_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblTag);
            this.tabPage4.Controls.Add(this.lblChecking);
            this.tabPage4.Controls.Add(this.txtRFIDOut);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1258, 72);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Čtečka";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(124, 55);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 4;
            this.lblTag.Text = "000";
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.Location = new System.Drawing.Point(8, 55);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(25, 15);
            this.lblChecking.TabIndex = 3;
            this.lblChecking.Text = "000";
            // 
            // txtRFIDOut
            // 
            this.txtRFIDOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRFIDOut.Location = new System.Drawing.Point(293, 6);
            this.txtRFIDOut.Name = "txtRFIDOut";
            this.txtRFIDOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtRFIDOut.Size = new System.Drawing.Size(959, 62);
            this.txtRFIDOut.TabIndex = 0;
            this.txtRFIDOut.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "RFID Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFID Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnAddNewuser);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1258, 72);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Cells";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnAddNewuser
            // 
            this.btnAddNewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewuser.Location = new System.Drawing.Point(8, 6);
            this.btnAddNewuser.Name = "btnAddNewuser";
            this.btnAddNewuser.Size = new System.Drawing.Size(66, 61);
            this.btnAddNewuser.TabIndex = 1;
            this.btnAddNewuser.Text = "ADD NEW USER";
            this.btnAddNewuser.UseVisualStyleBackColor = true;
            this.btnAddNewuser.Click += new System.EventHandler(this.btnAddNewuser_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataActive)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistered)).EndInit();
            this.Header.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl Header;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataActive;
        private System.Windows.Forms.DataGridView dataRegistered;
        private System.Windows.Forms.Button btnExportActive;
        private System.Windows.Forms.Button btnExportRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox txtRFIDOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblChecking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnAddNewuser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timerrefreshDB;
    }
}