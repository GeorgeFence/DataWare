using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
using Npgsql;
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
using Color = System.Drawing.Color;

namespace RFIDSystem
{
    public partial class Setup : Form
    {
        int i = 0;
        public static string NewTable = "";
        public static string NameTable = "";
        public enum Status
        {
            Unknown,
            Error,
            Warning,
            Information,
            Successfull
        };
        public Setup()
        {
            InitializeComponent();
        }

        public void DrawStatus(Status status, string inf = null)
        {
            switch (status)
            {
                case Status.Unknown:
                    panelStatus.BackColor = Color.OrangeRed;
                    txtStatus.Text = "Status Unknown";
                    return;

                case Status.Error:
                    panelStatus.BackColor = Color.Red;
                    txtStatus.Text = "Error : " + inf;
                    return;

                case Status.Warning:
                    panelStatus.BackColor = Color.Yellow;
                    txtStatus.Text = "Warning : " + inf;
                    return;

                case Status.Information:
                    panelStatus.BackColor = Color.LightBlue;
                    txtStatus.Text = "Info : " + inf;
                    return;

                case Status.Successfull:
                    panelStatus.BackColor = Color.LawnGreen;
                    txtStatus.Text = "Successfull : " + inf;
                    return;
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            panelPostgreSQL.Enabled = false;
            timer1.Start();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtIp.Text = "192.168.0.107";
            txtPort.Text = "5432";
            txtDatabaseName.Text = "rfid";
            txtUsername.Text = "admin";
            txtPassword.Text = "123";
            txtReg.Text = "rfid_registered";
            txtAct.Text = "rfid_active";
            if(i == 0)
            {
                DrawStatus(Status.Unknown);
                i++;
            }
            else if (i == 1)
            {
                DrawStatus(Status.Error, "Lol");
                i++;
            }
            else if (i == 2)
            {
                DrawStatus(Status.Warning, "Need 50 celsius");
                i++;
            }
            else if (i == 3)
            {
                DrawStatus(Status.Information, "Debil");
                i++;
            }
            else if (i == 4)
            {
                DrawStatus(Status.Successfull, "Yaaay");
                i++;
            }
            else if(i == 5)
            {
                i = 0;
            }
        }

        private void chckPostgreSQL_CheckStateChanged(object sender, EventArgs e)
        {
            if(chckPostgreSQL.Checked)
            {
                panelPostgreSQL.Enabled = true;
                panelCustomDatabase.Enabled = false;
            }
            else if(!chckPostgreSQL.Checked)
            {
                panelCustomDatabase.Enabled = true;
                panelPostgreSQL.Enabled = false;
            }
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                DrawStatus(Status.Information, "Testing connection");
                string connectionString = "Server=" + txtIp.Text +";Port=" + txtPort.Text + ";Database=" + txtDatabaseName.Text + ";User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";";

                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                conn.Close();
                DrawStatus(Status.Successfull, "Testing connection DONE");

                

                Properties.Settings.Default["PgIp"] = txtIp.Text;
                Properties.Settings.Default["PgPort"] = Int32.Parse(txtPort.Text);
                Properties.Settings.Default["PgUsername"] = txtUsername.Text;
                Properties.Settings.Default["PgPassword"] = txtPassword.Text;
                Properties.Settings.Default["PgDatabase"] = txtDatabaseName.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                DrawStatus(Status.Error, ex.Message);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["PgIp"] = txtIp.Text;
            Properties.Settings.Default["PgPort"] = Int32.Parse(txtPort.Text);
            Properties.Settings.Default["PgUsername"] = txtUsername.Text;
            Properties.Settings.Default["PgPassword"] = txtPassword.Text;
            Properties.Settings.Default["PgDatabase"] = txtDatabaseName.Text;
            Properties.Settings.Default["PgTableRegistered"] = txtReg.Text;
            Properties.Settings.Default["PgTableActive"] = txtAct.Text;
            Properties.Settings.Default.Save();

            string connectionString = "Server=" + Properties.Settings.Default["PgIp"] + ";Port=" + Properties.Settings.Default["PgPort"] + ";Database=" + Properties.Settings.Default["PgDatabase"] + ";User Id=" + Properties.Settings.Default["PgUsername"] + ";Password=" + Properties.Settings.Default["PgPassword"] + ";";

            string command = "CREATE TABLE readertemp (\"Id\" INT)";
            MessageBox.Show(command);
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Main.Translate(ex.Message, "cs", "en"), "RFIDSystem - Connection error"); }
            }

            conn.Close();
            this.Close();
            Main main = new Main();
            main.Show();
        }

        public static void CreateActiveTable(string TableName, List<string> values, List<string> valuesFormat)
        {
            string command = "CREATE TABLE " + TableName + " (\"Id\" INT,\"Jméno\" TEXT,\"Příjmení\" TEXT,\"Email\" TEXT,\"Telefonní číslo\" INT,\"Datum narození\" TEXT, \"Aktivní\" BOOL";
            if(values.Count == 0)
            {

            }
            else
            {
                for (int i = 0; i < values.Count(); i++)
                {
                    if (i == 0)
                    {
                        command = command + ", ";
                    }
                    if (i == values.Count() - 1)
                    {
                        command = command += "\"" + values[i] + "\" " + valuesFormat[i] + ");";
                    }
                    else
                    {
                        command = command += "\"" + values[i] + "\" " + valuesFormat[i] + ",";
                    }
                }
            }
            MessageBox.Show(command);
            NpgsqlConnection conn = new NpgsqlConnection(Main.connectionString);
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Main.Translate(ex.Message, "cs", "en"), "RFIDSystem - Connection error"); }
            }
        }

        public static void CreateRegisteredTable(string TableName)
        {
            try
            {
                string command = "CREATE TABLE " + TableName + " (\"Id\" INT,\"Jméno\" TEXT,\"Příjmení\" TEXT,\"Email\" TEXT,\"Telefonní číslo\" INT,\"Datum narození\" TEXT);";
                MessageBox.Show(command);
                NpgsqlConnection conn = new NpgsqlConnection(Main.connectionString);
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Main.Translate(ex.Message, "cs", "en"), "RFIDSystem - Connection error"); }
        }

        private void btnNewActive_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["PgIp"] != null)
            {
                NewTable = "Active";
                CreateTable t = new CreateTable();
                t.Show();
            }
            else
            {
                 MessageBox.Show("Nejdřív prosím zadejte informace k databázi, klikněte na \"Testovat a registrovat\" a pokud status řekne, že testování proběhlo bez problému, lze vytvořit novou tabulku ", "RFIDSystem - No database detected", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnNewRegistered_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["PgIp"] != null)
            {
                NewTable = "Registered";
                CreateTable t = new CreateTable();
                t.Show();
            }
            else
            {
                MessageBox.Show("Nejdřív prosím zadejte informace k databázi, klikněte na \"Testovat a registrovat\" a pokud status řekne, že testování proběhlo bez problému, lze vytvořit novou tabulku ", "RFIDSystem - No database detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string TableName = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(NameTable != "")
            {
                if (NewTable == "Active")
                {
                    txtAct.Text = NameTable;
                    NewTable = "";
                    NameTable = "";
                }
                if (NewTable == "Registered")
                {
                    txtReg.Text = NameTable;
                    NewTable = "";
                    NameTable = "";
                }
            }
        }

    }
}
