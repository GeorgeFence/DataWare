namespace RFIDSystem
{
    partial class Setup
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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDb = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelCustomDatabase = new System.Windows.Forms.Panel();
            this.panelPostgreSQL = new System.Windows.Forms.Panel();
            this.btnNewRegistered = new System.Windows.Forms.Button();
            this.btnNewActive = new System.Windows.Forms.Button();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.chckPostgreSQL = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelStatus.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDb.SuspendLayout();
            this.panelPostgreSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.txtStatus);
            this.panelStatus.Controls.Add(this.txt1);
            this.panelStatus.Location = new System.Drawing.Point(12, 243);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(440, 26);
            this.panelStatus.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtStatus.AutoEllipsis = true;
            this.txtStatus.Location = new System.Drawing.Point(50, 7);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(387, 13);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "Status Unknown";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(4, 7);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(40, 13);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Status:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 211);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDb);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 196);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageDb
            // 
            this.tabPageDb.Controls.Add(this.btnNext);
            this.tabPageDb.Controls.Add(this.panelCustomDatabase);
            this.tabPageDb.Controls.Add(this.panelPostgreSQL);
            this.tabPageDb.Controls.Add(this.chckPostgreSQL);
            this.tabPageDb.Location = new System.Drawing.Point(4, 22);
            this.tabPageDb.Name = "tabPageDb";
            this.tabPageDb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDb.Size = new System.Drawing.Size(432, 170);
            this.tabPageDb.TabIndex = 0;
            this.tabPageDb.Text = "Database";
            this.tabPageDb.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(348, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelCustomDatabase
            // 
            this.panelCustomDatabase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCustomDatabase.Location = new System.Drawing.Point(222, 31);
            this.panelCustomDatabase.Name = "panelCustomDatabase";
            this.panelCustomDatabase.Size = new System.Drawing.Size(204, 133);
            this.panelCustomDatabase.TabIndex = 2;
            // 
            // panelPostgreSQL
            // 
            this.panelPostgreSQL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPostgreSQL.Controls.Add(this.btnNewRegistered);
            this.panelPostgreSQL.Controls.Add(this.btnNewActive);
            this.panelPostgreSQL.Controls.Add(this.txtAct);
            this.panelPostgreSQL.Controls.Add(this.txtReg);
            this.panelPostgreSQL.Controls.Add(this.txtDatabaseName);
            this.panelPostgreSQL.Controls.Add(this.btnTestConnection);
            this.panelPostgreSQL.Controls.Add(this.txtPassword);
            this.panelPostgreSQL.Controls.Add(this.txtUsername);
            this.panelPostgreSQL.Controls.Add(this.txtPort);
            this.panelPostgreSQL.Controls.Add(this.txtIp);
            this.panelPostgreSQL.Location = new System.Drawing.Point(7, 31);
            this.panelPostgreSQL.Name = "panelPostgreSQL";
            this.panelPostgreSQL.Size = new System.Drawing.Size(204, 133);
            this.panelPostgreSQL.TabIndex = 1;
            // 
            // btnNewRegistered
            // 
            this.btnNewRegistered.Location = new System.Drawing.Point(181, 83);
            this.btnNewRegistered.Name = "btnNewRegistered";
            this.btnNewRegistered.Size = new System.Drawing.Size(20, 20);
            this.btnNewRegistered.TabIndex = 9;
            this.btnNewRegistered.Text = "+";
            this.btnNewRegistered.UseVisualStyleBackColor = true;
            this.btnNewRegistered.Click += new System.EventHandler(this.btnNewRegistered_Click);
            // 
            // btnNewActive
            // 
            this.btnNewActive.Location = new System.Drawing.Point(181, 58);
            this.btnNewActive.Name = "btnNewActive";
            this.btnNewActive.Size = new System.Drawing.Size(20, 20);
            this.btnNewActive.TabIndex = 8;
            this.btnNewActive.Text = "+";
            this.btnNewActive.UseVisualStyleBackColor = true;
            this.btnNewActive.Click += new System.EventHandler(this.btnNewActive_Click);
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(105, 58);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(73, 20);
            this.txtAct.TabIndex = 7;
            this.txtAct.Text = "TABLEACTIVE";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(105, 84);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(73, 20);
            this.txtReg.TabIndex = 6;
            this.txtReg.Text = "TABLEREGISTERED";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(4, 84);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(95, 20);
            this.txtDatabaseName.TabIndex = 5;
            this.txtDatabaseName.Text = "DATABASE";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(4, 110);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(197, 20);
            this.btnTestConnection.TabIndex = 4;
            this.btnTestConnection.Text = "Testovat a registrovat";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(4, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(95, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "PASSWORD";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(4, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "USERNAME";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(132, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(69, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "PORT";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(4, 4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(121, 20);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "IP";
            // 
            // chckPostgreSQL
            // 
            this.chckPostgreSQL.AutoSize = true;
            this.chckPostgreSQL.Location = new System.Drawing.Point(7, 7);
            this.chckPostgreSQL.Name = "chckPostgreSQL";
            this.chckPostgreSQL.Size = new System.Drawing.Size(83, 17);
            this.chckPostgreSQL.TabIndex = 0;
            this.chckPostgreSQL.Text = "PostgreSQL";
            this.chckPostgreSQL.UseVisualStyleBackColor = true;
            this.chckPostgreSQL.CheckStateChanged += new System.EventHandler(this.chckPostgreSQL_CheckStateChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panelStatus);
            this.Name = "Setup";
            this.ShowIcon = false;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDb.ResumeLayout(false);
            this.tabPageDb.PerformLayout();
            this.panelPostgreSQL.ResumeLayout(false);
            this.panelPostgreSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDb;
        private System.Windows.Forms.Panel panelPostgreSQL;
        private System.Windows.Forms.CheckBox chckPostgreSQL;
        private System.Windows.Forms.Panel panelCustomDatabase;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Button btnNewRegistered;
        private System.Windows.Forms.Button btnNewActive;
        private System.Windows.Forms.Timer timer1;
    }
}