using Employee_Service;
using Service_Application.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Service_Application
{
    public partial class MainForm : Form
    {
        AutorizationForm autorizationForm = new AutorizationForm();
        ConnectionDB data_base = new ConnectionDB();

        public MainForm()
        {
            InitializeComponent();
            var timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            labelDateTime.Text = $"{DateTime.Now.DayOfWeek}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)}  [ {DateTime.Now.ToShortDateString()} ]  {DateTime.Now.ToShortTimeString()}";

            listView1.Clear();
            await data_base.OpenConnectionAsync(); ListView();
            await LoadDataBaseAsync();
        }

        public async void Updt()
        {
            listView1.Clear();
            await data_base.OpenConnectionAsync(); 
            ListView();
            await LoadDataBaseAsync();
        }

        private void ListView()
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.View = View.Details;

            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Surname");
            listView1.Columns.Add("Birth Date");
            listView1.Columns.Add("Age");
            listView1.Columns.Add("Gender");
            listView1.Columns.Add("PESEL");
            listView1.Columns.Add("Country");
            listView1.Columns.Add("City");
            listView1.Columns.Add("Postcode");
            listView1.Columns.Add("Phone Number");
            listView1.Columns.Add("Address");
            listView1.Columns.Add("Company Name");
            listView1.Columns.Add("Position");
            listView1.Columns.Add("Date of Registration");
        }

        private async Task LoadDataBaseAsync()
        {
            using (var command = new SqlCommand("SELECT * FROM Table_employees", data_base.GetConnection()))
            {
                var dataBaseReader = await command.ExecuteReaderAsync();

                try
                {
                    while (await dataBaseReader.ReadAsync())
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            Convert.ToString(dataBaseReader["id"]),
                            Convert.ToString(dataBaseReader["name"]),
                            Convert.ToString(dataBaseReader["surname"]),
                            Convert.ToString(dataBaseReader["birth_date"]),
                            Convert.ToString(dataBaseReader["age"]),
                            Convert.ToString(dataBaseReader["gender"]),
                            Convert.ToString(dataBaseReader["pesel"]),
                            Convert.ToString(dataBaseReader["country"]),
                            Convert.ToString(dataBaseReader["city"]),
                            Convert.ToString(dataBaseReader["postcode"]),
                            Convert.ToString(dataBaseReader["phone_number"]),
                            Convert.ToString(dataBaseReader["address"]),
                            Convert.ToString(dataBaseReader["company_name"]),
                            Convert.ToString(dataBaseReader["position"]),
                            Convert.ToString(dataBaseReader["date_of_registration"])
                        });

                        listView1.Items.Add(item);
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (dataBaseReader != null) dataBaseReader.Close();
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = $"{DateTime.Now.DayOfWeek}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)}  [ {DateTime.Now.ToShortDateString()} ]  {DateTime.Now.ToShortTimeString()}";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorizationForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            autorizationForm.Show();
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Owner = this;
            add.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm change = new ChangeForm();
            change.Owner = this;
            if (listView1.SelectedItems.Count > 0)
            {
                change.temp_id = listView1.SelectedItems[0].Text;
                change.Show();
            }
            else MessageBox.Show("Please select a database item to modify it.", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
