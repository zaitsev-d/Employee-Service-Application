using Service_Application;
using Service_Application.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Service
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();

            this.codeField.AutoSize = false;
            this.codeField.Size = new Size(this.codeField.Size.Width, 48);
        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string surname = surnameField.Text;
            string pesel = peselField.Text;
            string password = codeField.Text;

            var data_base = new ConnectionDB();
            var table = new DataTable();
            var adapter = new SqlDataAdapter();

            using (var command = new SqlCommand("SELECT * FROM Table_company_collaborators WHERE name = @CN AND surname = @CS AND pesel = @CPl AND password = @CP", data_base.GetConnection()))
            {
                command.Parameters.Add("@CN", SqlDbType.NChar).Value = name;
                command.Parameters.Add("@CS", SqlDbType.NChar).Value = surname;
                command.Parameters.Add("@CPl", SqlDbType.NChar).Value = pesel;
                command.Parameters.Add("@CP", SqlDbType.Binary).Value = password;
                adapter.SelectCommand = command;
            }

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Collaborator is conected");
            }
            else MessageBox.Show("Collaborator is not conected");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();

            this.Hide();
        }

        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
