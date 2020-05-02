using Service_Application;
using Service_Application.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            var data_base = new ConnectionDB();
            var table = new DataTable();
            var adapter = new SqlDataAdapter();

            using (var command = new SqlCommand("SELECT * FROM Table_company_collaborators WHERE name = @CN AND surname = @CS AND pesel = @CPl AND password = @CP", data_base.GetConnection()))
            {
                command.Parameters.Add("@CN", SqlDbType.NChar).Value = nameField.Text;
                command.Parameters.Add("@CS", SqlDbType.NChar).Value = surnameField.Text;
                command.Parameters.Add("@CPl", SqlDbType.NChar).Value = peselField.Text;
                command.Parameters.Add("@CP", SqlDbType.Binary).Value = PassCryptor(codeField.Text);
                adapter.SelectCommand = command;
            }

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Collaborator is conected");
                List<TextBox> fieldsList = new List<TextBox>() { nameField, surnameField, peselField, codeField };
                foreach (var x in fieldsList)
                {
                    x.Clear();
                }
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else MessageBox.Show("Collaborator is not conected");
        }

        private byte[] PassCryptor(string password)
        {
            using (var sha = new SHA256Managed())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
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
