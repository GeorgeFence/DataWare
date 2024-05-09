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
    public partial class Value : Form
    {
        public string Val = "";
        public string title = "";
        public Value(string Name)
        {
            title = Name;
            InitializeComponent();
        }

        private void Value_Load(object sender, EventArgs e)
        {
            this.Text = "Hodnota " + title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Val = textBox1.Text;
            Main.Values.Add(Val);
            this.Hide();
        }
    }
}
