using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystem
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            barLoad.ForeColor = Color.Red;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(barLoad.Value == 230){
                
                timer1.Stop();
                Form main = new Main();
                main.Show();
                Hide();

            }
            else
            {
                barLoad.Value = barLoad.Value + 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Properties.Settings.Default["PgIp"] = "";
            Properties.Settings.Default["PgPort"] = null;
            Properties.Settings.Default["PgUsername"] = null;
            Properties.Settings.Default["PgPassword"] = null;
            Properties.Settings.Default["PgDatabase"] = null;
            Properties.Settings.Default["PgTableRegistered"] = null;
            Properties.Settings.Default["PgTableActive"] = null;
            Properties.Settings.Default.Save();
            Setup s = new Setup();
            s.Show();
            Hide();
        }

        private void barLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
