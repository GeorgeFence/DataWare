namespace RFIDSystem
{
    partial class CreateTable
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTable));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název Tabulky: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(100, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 18);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.Location = new System.Drawing.Point(12, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeTable";
            treeNode1.Text = "";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(219, 213);
            this.treeView1.TabIndex = 2;
            // 
            // txtNode
            // 
            this.txtNode.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNode.ForeColor = System.Drawing.Color.Black;
            this.txtNode.Location = new System.Drawing.Point(12, 256);
            this.txtNode.Multiline = true;
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(100, 21);
            this.txtNode.TabIndex = 3;
            // 
            // comboFormat
            // 
            this.comboFormat.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormat.ForeColor = System.Drawing.Color.Black;
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "TEXT",
            "INT",
            "BOOL"});
            this.comboFormat.Location = new System.Drawing.Point(118, 256);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(45, 23);
            this.comboFormat.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(169, 256);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(61, 21);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Vložit";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDone.BackgroundImage")));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(12, 283);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(219, 23);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Hotovo";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 314);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.comboFormat);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "CreateTable";
            this.ShowIcon = false;
            this.Text = "Vytvořit Tabulku";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDone;
    }
}