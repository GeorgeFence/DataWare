using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystem
{
    public partial class CreateTable : Form
    {
        List<string> s = new List<string>();
        List<string> sFormat = new List<string>();
        public CreateTable()
        {
            InitializeComponent();
        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
            this.Text = Setup.NewTable;
            if (Setup.NewTable == "Active")
            {
                treeView1.Nodes[0].Nodes.Insert(0, new TreeNode("Id"));
                treeView1.Nodes[0].Nodes[0].Nodes.Insert(0, new TreeNode("INT"));
                treeView1.Nodes[0].Nodes.Insert(1, new TreeNode("Jméno"));
                treeView1.Nodes[0].Nodes[1].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(2, new TreeNode("Příjmení"));
                treeView1.Nodes[0].Nodes[2].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(3, new TreeNode("Email"));
                treeView1.Nodes[0].Nodes[3].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(4, new TreeNode("Telefonní číslo"));
                treeView1.Nodes[0].Nodes[4].Nodes.Insert(0, new TreeNode("INT"));
                treeView1.Nodes[0].Nodes.Insert(5, new TreeNode("Datum narození"));
                treeView1.Nodes[0].Nodes[5].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(6, new TreeNode("Aktivní"));
                treeView1.Nodes[0].Nodes[6].Nodes.Insert(0, new TreeNode("BOOL"));
            }
            if (Setup.NewTable == "Registered")
            {
                btnInsert.Enabled = false;
                txtNode.Enabled = false; 
                comboFormat.Enabled = false;
                treeView1.Nodes[0].Nodes.Insert(0, new TreeNode("Id"));
                treeView1.Nodes[0].Nodes[0].Nodes.Insert(0, new TreeNode("INT"));
                treeView1.Nodes[0].Nodes.Insert(1, new TreeNode("Jméno"));
                treeView1.Nodes[0].Nodes[1].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(2, new TreeNode("Příjmení"));
                treeView1.Nodes[0].Nodes[2].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(3, new TreeNode("Email"));
                treeView1.Nodes[0].Nodes[3].Nodes.Insert(0, new TreeNode("TEXT"));
                treeView1.Nodes[0].Nodes.Insert(4, new TreeNode("Telefonní číslo"));
                treeView1.Nodes[0].Nodes[4].Nodes.Insert(0, new TreeNode("INT"));
                treeView1.Nodes[0].Nodes.Insert(5, new TreeNode("Datum narození"));
                treeView1.Nodes[0].Nodes[5].Nodes.Insert(0, new TreeNode("TEXT"));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Text = txtName.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Insert(treeView1.Nodes[0].Nodes.Count, new TreeNode(txtNode.Text));
            treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Nodes.Insert(0, new TreeNode(comboFormat.Text));
            s.Add(txtNode.Text);
            sFormat.Add(comboFormat.Text);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(s.Count() > 3)
            {
                MessageBox.Show("Počet přidaných hodnot překračuje limit 3. Vás počet je " + s.Count() + ". Pro přidání více hodnot kontaktujte developera.", "Vytváření Table", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if(Setup.NewTable == "Active")
                {
                    if(s.Count() != 0)
                    {
                        string st = "";
                        for (int i = 0; i < s.Count; i++)
                        {
                            

                            if(i == s.Count - 1)
                            {
                                st = st + s[i].ToString();
                            }
                            else
                            {
                                st = st +  s[i].ToString() + ";";
                            }
                        }
                        Properties.Settings.Default["ActiveTableAditional"] = st.ToString();
                        Properties.Settings.Default.Save();
                        MessageBox.Show(st);
                    }

                    Setup.CreateActiveTable(txtName.Text, s, sFormat);
                    Setup.NameTable = txtName.Text;
                }
                else
                {
                    Setup.CreateRegisteredTable(txtName.Text);
                    Setup.NameTable = txtName.Text;
                }
                Hide();
            }
        }
    }
}
