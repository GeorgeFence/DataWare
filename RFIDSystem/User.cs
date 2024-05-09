using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystem
{
    public partial class User : Form
    {
        public User(bool uidlock, string UID, string name = null, string email = null)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtName.Text = name;
            txtUID.Text = UID;
            if(uidlock)
            {
                txtUID.Enabled = false;
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.AddUser(txtUID.Text, txtName.Text,txtPrijmeni.Text, txtEmail.Text, txtTelefonnicislo.Text, txtDatum.Value.Day + "-" + txtDatum.Value.Month + "-" + txtDatum.Value.Year);
            Thread.Sleep(1000);
            Hide();
        }
    }
}
