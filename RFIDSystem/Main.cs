using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using ExcelDataReader;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Color = System.Drawing.Color;

namespace RFIDSystem
{
    public partial class Main : Form
    {
        static SerialPort RFIDPort;
        DataTableCollection datacollection;
        bool IsPort = false;
        public static int subscription = 0;
        public static string subscriptiondate = "";

        public static List<string> AditionalActiveValues = new List<string>();

        //PostgreSQL
        public static string connectionString = "Server=" + Properties.Settings.Default["PgIp"] + ";Port=" + Properties.Settings.Default["PgPort"] + ";Database=" + Properties.Settings.Default["PgDatabase"] + ";User Id=" + Properties.Settings.Default["PgUsername"] + ";Password=" + Properties.Settings.Default["PgPassword"] + ";";
        public static NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        public static NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        public static DataSet ds;
        public static DataTable refreshDtReg = new DataTable();
        public static DataTable refreshDtAct = new DataTable();
        public static DataTable newUser = new DataTable();

        public static ImageList image = new ImageList();

        public Main()
        {
            InitializeComponent();
            image.Images.Add(Properties.Resources.gradientLeft);
            filterActive.SetColumns(dataActive.Columns);
            filterRegistered.SetColumns(dataRegistered.Columns);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default["PgIp"].ToString() == "")
                {
                    Setup f = new Setup();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (Properties.Settings.Default["ActiveTableAditional"] != null)
                    {
                        if (!Properties.Settings.Default["ActiveTableAditional"].ToString().Contains(';'))
                        {
                            AditionalActiveValues.Add(Properties.Settings.Default["ActiveTableAditional"].ToString());
                        }
                        else
                        {
                            AditionalActiveValues = Properties.Settings.Default["ActiveTableAditional"].ToString().Split(';').ToList();
                        }

                    }
                    connectionString = "Server=" + Properties.Settings.Default["PgIp"] + ";Port=" + Properties.Settings.Default["PgPort"] + ";Database=" + Properties.Settings.Default["PgDatabase"] + ";User Id=" + Properties.Settings.Default["PgUsername"] + ";Password=" + Properties.Settings.Default["PgPassword"] + ";";
                    Tick.Start();
                    conn.Open();
                    Refresh(ref dataRegistered, "PgTableRegistered");
                    Refresh(ref dataActive, "PgTableActive");
                    foreach (DataGridViewColumn d in dataActive.Columns)
                    {
                        if (d.HeaderText != "Aktivní")
                        {
                            d.ReadOnly = true;
                        }
                        else
                        {
                            d.ReadOnly = false;
                        }
                    }
                    timerrefreshDB.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"RFIDystem Login to database", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        public static String Translate(String word, string toLang, string fromLang)
        {
            var toLanguage = toLang.ToLower();
            var fromLanguage = fromLang.ToLower();
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";

            }
        }
        public void Refresh(ref Zuby.ADGV.AdvancedDataGridView d, string settTable)
        {
            int saveRow = 0;
            if (d.SelectedRows.Count > 0)
                saveRow = d.SelectedRows[0].Index;
            d.DataSource = GetData("SELECT * FROM " + Properties.Settings.Default[settTable]);

            if (saveRow != 0 && saveRow < d.Rows.Count)
                d.Rows[0].Selected = false;
                d.Rows[saveRow].Selected = true;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void btnExportActive_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataActive.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataActive.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataActive.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataActive.Columns.Count; j++)
                {
                    if (dataActive.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataActive.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btnExportRegistered_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataRegistered.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataRegistered.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataRegistered.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataRegistered.Columns.Count; j++)
                {
                    if (dataRegistered.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataRegistered.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            int RowIndex = 0;
            string name = null;
            string email = null;
            /*if (IsPort)
            {
                string a = RFIDPort.ReadExisting();
                if(a != "")
                {
                    txtRFIDOut.Text = txtRFIDOut.Text + a + "" +
                        "";
                    txtRFIDOut.SelectionStart = txtRFIDOut.Text.Length;
                    txtRFIDOut.ScrollToCaret();

                    dataRegistered.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    lblTag.Text = a;

                    bool valueResult = false;
                    foreach (DataGridViewRow row in dataRegistered.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            RowIndex++;
                            txtRFIDOut.Text = txtRFIDOut.Text + " 2 ";
                            DataGridViewCell cell = row.Cells[0];
                            string val = cell.Value.ToString();
                            lblChecking.Text = val;
                            if (lblTag.Text.Contains(lblChecking.Text))
                            {
                                if (row.Cells[1].Value != null)
                                {
                                    DataGridViewCell cell1 = row.Cells[1];
                                    string val1 = cell1.Value.ToString();
                                    name = val1;

                                }
                                if (row.Cells[2].Value != null)
                                {
                                    DataGridViewCell cell2 = row.Cells[2];
                                    string val2 = cell2.Value.ToString();
                                    email = val2;

                                }
                                valueResult = true;
                                break;
                            }
                        }


                    }
                    if (!valueResult)
                    {
                        MessageBox.Show("Nelze najít " + a , "Nenalezeno");
                        return;
                    }
                    else
                    {
                        Form form = new User(true,lblChecking.Text,name,email);
                        form.Show();
                    }
                }

                
            }*/

        }


        public void AddUser(String ID, String Jmeno,String Prijmeni, String Email, String TelCislo, String Datum)
        {
            string comm = "INSERT INTO " + Properties.Settings.Default["PgTableRegistered"] + " VALUES('" + ID + "','" + Jmeno + "','" + Prijmeni + "','" + Email + "','" + TelCislo + "','" + Datum + "')";
            MessageBox.Show(comm);
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(comm, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem"); }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem");
            }
            
        }

        /*public void AddActiveUser(int ID, string Val1, string Val2 = null, string Val3 = null)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO " + Properties.Settings.Default["PgTableRegistered"] + " VALUES ('" + ID + "','" + Jmeno + "','" + Prijmeni + "','" + Email + "','" + TelCislo + "','" + Datum + "','" + Heslo + "')", conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { txtRFIDOut.Text = ex.Message; }
            }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Setup();
            f.ShowDialog();
        }
        public DataTable GetData(string selectSql)
        {
            try
            {
                ds = new DataSet();
                da = new NpgsqlDataAdapter(selectSql, conn);
                da.Fill(ds);
                return ds.Tables[0];
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAddNewuser_Click(object sender, EventArgs e)
        {
            User u = new User(false,null,null,null);
            u.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh(ref dataRegistered, "PgTableRegistered");
            Refresh(ref dataActive, "PgTableActive");
        }


        private void dataRegistered_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error appeared in Data Grid View. More info : "+ e.Exception.Message.ToString() + "\n" + Translate(e.Exception.Message.ToString(), "cs", "en"), "RFIDSystem - DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static List<string>Values = new List<string>();
        private void timerrefreshDB_Tick(object sender, EventArgs e)
        {
            Refresh(ref dataActive, "PgTableActive");
            Refresh(ref dataRegistered, "PgTableRegistered");
            newUser = GetData("SELECT * FROM readertemp");
            if (newUser.Rows.Count != 0)
            {
                string comm = "DELETE FROM readertemp WHERE \"Id\"='" + newUser.Rows[0][0].ToString() + "'";
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(comm, conn))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem"); }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem");
                }

                bool Exists = false;
                int RowNum = 0;
                for (int i = 0; i < dataRegistered.Rows.Count - 1; i++)
                {
                    if (dataRegistered.Rows[i].Cells["Id"].Value.ToString() == newUser.Rows[0][0].ToString())
                    {
                        RowNum = i;
                        Exists = true;
                        break;
                    }
                }

                if (!Exists)
                {
                    User user = new User(true, newUser.Rows[0][0].ToString());
                    user.Show();
                }
                else
                {
                    for (int i = 0; i < AditionalActiveValues.Count; i++)
                    {
                        Value v = new Value(AditionalActiveValues[i]);
                        v.Show();
                        while (v.Val == "")
                        {
                            wait(500);
                        }
                    }

                    string command = "INSERT INTO " + Properties.Settings.Default["PgTableActive"] + " VALUES('" + dataRegistered.Rows[RowNum].Cells["Id"].Value.ToString() + "','" + dataRegistered.Rows[RowNum].Cells["Jméno"].Value.ToString() + "','" + dataRegistered.Rows[RowNum].Cells["Příjmení"].Value.ToString() + "','" + dataRegistered.Rows[RowNum].Cells["Email"].Value.ToString() + "','" + dataRegistered.Rows[RowNum].Cells["Telefonní číslo"].Value.ToString() + "','" + dataRegistered.Rows[RowNum].Cells["Datum narození"].Value.ToString() + "', 'true'";
                    if (AditionalActiveValues.Count == 0)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < AditionalActiveValues.Count(); i++)
                        {
                            if (i == 0)
                            {
                                command = command + ", ";
                            }
                            if (i == AditionalActiveValues.Count() - 1)
                            {
                                command = command += "'" + Values[i] + "')";
                            }
                            else
                            {
                                command = command += "'" + Values[i] + "',";
                            }
                        }
                    }
                    Values = new List<string>();
                    MessageBox.Show(command);
                    try
                    {
                        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem"); }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem");
                    }
                }
            }

        }

        private void dataRegistered_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuItem cut = new MenuItem("Cut");
                MenuItem copy = new MenuItem("Copy");
                MenuItem paste = new MenuItem("Paste");
                MenuItem delete = new MenuItem("Delete Row");

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(cut);
                m.MenuItems.Add(copy);
                m.MenuItems.Add(paste);
                m.MenuItems.Add(delete);
                m.Show(dataRegistered, new Point(e.X, e.Y));

            }
        }

        private void dataActive_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataActive.Columns[e.ColumnIndex].HeaderText == "Aktivní")
            {
                timerrefreshDB.Stop();
                string comm = "DELETE FROM " + Properties.Settings.Default["PgTableActive"] + " WHERE \"Id\"='" + dataActive.Rows[e.RowIndex].Cells["Id"].Value + "' AND \"Jméno\"='" + dataActive.Rows[e.RowIndex].Cells["Jméno"].Value + "' AND \"Příjmení\"='" + dataActive.Rows[e.RowIndex].Cells["Příjmení"].Value + "'";
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                MessageBox.Show(comm);
                using (NpgsqlCommand cmd = new NpgsqlCommand(comm, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + Translate(ex.Message.ToString(), "cs", "en"), "RFIDSystem"); }
                }
                timerrefreshDB.Start();
            } 
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void aktivníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataActive.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataActive.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataActive.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataActive.Columns.Count; j++)
                {
                    if (dataActive.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataActive.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void registrovaníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataRegistered.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataRegistered.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataRegistered.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataRegistered.Columns.Count; j++)
                {
                    if (dataRegistered.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataRegistered.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }


        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerrefreshDB.Stop();
            Properties.Settings.Default["PgIp"] = "";
            Properties.Settings.Default["PgPort"] = null;
            Properties.Settings.Default["PgUsername"] = null;
            Properties.Settings.Default["PgPassword"] = null;
            Properties.Settings.Default["PgDatabase"] = null;
            Properties.Settings.Default["PgTableRegistered"] = null;
            Properties.Settings.Default["PgTableActive"] = null;
            Properties.Settings.Default.Save();
            Setup s = new Setup();
            MessageBox.Show("Zavírání aplikace", "RFID System");
            s.Show();
            Hide();
        }

        private void nastaveníPřipojeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup s = new Setup();
            s.Show();
        }

        private void aboutRFIDSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info i = new info();
            i.Show();
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataActive_SelectionChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                txtEditVal1.Enabled = true;
                txtEditVal2.Enabled = true;
                txtEditVal3.Enabled = true;
                if (dataActive.SelectedRows.Count > 0 && dataActive.SelectedRows[0].Cells[0].Value != null)
                {
                    txtEditID.Text = dataActive.SelectedRows[0].Cells[0].Value.ToString();
                    txtEditName.Text = dataActive.SelectedRows[0].Cells[1].Value.ToString();
                    txtEditSurname.Text = dataActive.SelectedRows[0].Cells[2].Value.ToString();
                    txtEditEmail.Text = dataActive.SelectedRows[0].Cells[3].Value.ToString();
                    txtEditTel.Text = dataActive.SelectedRows[0].Cells[4].Value.ToString();
                    txtEditBirthDay.Text = dataActive.SelectedRows[0].Cells[5].Value.ToString();
                    if(AditionalActiveValues.Count == 1)
                    {
                        txtEditVal1.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[0].ToString()].Value.ToString();
                    }
                    if(AditionalActiveValues.Count == 2)
                    {
                        txtEditVal1.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[0].ToString()].Value.ToString();
                        txtEditVal2.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[1].ToString()].Value.ToString();
                    }
                    if(AditionalActiveValues.Count == 3)
                    {
                        txtEditVal1.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[0].ToString()].Value.ToString();
                        txtEditVal2.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[1].ToString()].Value.ToString();
                        txtEditVal3.Text = dataActive.SelectedRows[0].Cells[AditionalActiveValues[2].ToString()].Value.ToString();
                    }
                }
            }
        }
        private void dataRegistered_SelectionChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                txtEditVal1.Enabled = false;
                txtEditVal2.Enabled = false;
                txtEditVal3.Enabled = false;

                if (dataRegistered.SelectedRows.Count > 0 && dataRegistered.SelectedRows[0].Cells[0].Value != null)
                {
                    txtEditID.Text = dataRegistered.SelectedRows[0].Cells[0].Value.ToString();
                    txtEditName.Text = dataRegistered.SelectedRows[0].Cells[1].Value.ToString();
                    txtEditSurname.Text = dataRegistered.SelectedRows[0].Cells[2].Value.ToString();
                    txtEditEmail.Text = dataRegistered.SelectedRows[0].Cells[3].Value.ToString();
                    txtEditTel.Text = dataRegistered.SelectedRows[0].Cells[4].Value.ToString();
                    txtEditBirthDay.Text = dataRegistered.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void filterActive_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = dataActive.CurrentCell.ColumnIndex + 1 >= dataActive.ColumnCount;
                bool endrow = dataActive.CurrentCell.RowIndex + 1 >= dataActive.RowCount;

                if (endcol && endrow)
                {
                    startColumn = dataActive.CurrentCell.ColumnIndex;
                    startRow = dataActive.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : dataActive.CurrentCell.ColumnIndex + 1;
                    startRow = dataActive.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = dataActive.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = dataActive.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                dataActive.CurrentCell = c;
        }

        private void filterRegistered_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = dataRegistered.CurrentCell.ColumnIndex + 1 >= dataRegistered.ColumnCount;
                bool endrow = dataRegistered.CurrentCell.RowIndex + 1 >= dataRegistered.RowCount;

                if (endcol && endrow)
                {
                    startColumn = dataRegistered.CurrentCell.ColumnIndex;
                    startRow = dataRegistered.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : dataRegistered.CurrentCell.ColumnIndex + 1;
                    startRow = dataRegistered.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = dataRegistered.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = dataRegistered.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                dataRegistered.CurrentCell = c;
        }

        private void dataRegistered_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
