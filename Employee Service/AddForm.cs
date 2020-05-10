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

namespace Service_Application
{
    public partial class AddForm : Form
    {
        private int age = default;
        private DateTime birthDate = default;

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            labelAge.Text = default;
        }

        private void birthDateField_Validating(object sender, CancelEventArgs e)
        {
            if (birthDateField.Text != String.Empty && DateTime.TryParse(birthDateField.Text, out birthDate))
            {
                birthDate = Convert.ToDateTime(birthDateField.Text);
                age = DateTime.Now.Year - birthDate.Year;
                labelAge.Text = $"Age: {age}";
            }
            else MessageBox.Show("Birth date is written incorrect.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var data_base = new ConnectionDB();

            using (var command = new SqlCommand("INSERT INTO Table_employees(id, name, surname, birth_date, age, gender, pesel, country, city, postcode, phone_number, address, company_name, position, date_of_registration)" +
            "VALUES(@id, @name, @surname, @birthDate, @age, @gender, @pesel, @country, @city, @postcode, @phoneNumber, @address, @company_name, @position, @dateOfRegistration)", data_base.GetConnection()))
            {
                command.Parameters.Add("@id", SqlDbType.NChar).Value = IDGenerator();
                command.Parameters.Add("@name", SqlDbType.NChar).Value = nameField.Text;
                command.Parameters.Add("@surname", SqlDbType.NChar).Value = surnameField.Text;
                command.Parameters.Add("@birthDate", SqlDbType.Date).Value = birthDate;
                command.Parameters.Add("@age", SqlDbType.Int).Value = age;
                command.Parameters.Add("@gender", SqlDbType.Text).Value = genderComboBox.SelectedItem;
                command.Parameters.Add("@pesel", SqlDbType.NChar).Value = peselField.Text;
                command.Parameters.Add("@country", SqlDbType.NChar).Value = countryField.Text;
                command.Parameters.Add("@city", SqlDbType.NChar).Value = cityField.Text;
                command.Parameters.Add("@postcode", SqlDbType.NChar).Value = postcodeField.Text;
                command.Parameters.Add("@phoneNumber", SqlDbType.NChar).Value = phoneNumberField.Text;
                command.Parameters.Add("@address", SqlDbType.Text).Value = addressField.Text;
                command.Parameters.Add("@company_name", SqlDbType.Text).Value = companyNameComboBox.SelectedItem;
                command.Parameters.Add("@position", SqlDbType.Text).Value = comboBoxPosition.SelectedItem;
                command.Parameters.Add("@dateOfRegistration", SqlDbType.DateTime).Value = DateTime.Now;

                data_base.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                 {
                    MessageBox.Show("Adding completed successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = this.Owner as MainForm;
                    main.Updt();
                    data_base.CloseConnection();
                    this.Close();
                 }
                 else MessageBox.Show("Registration failed. Please, check your internet connection.", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string IDGenerator()
        {
            const int SIZE = 10;
            string result = default;

            Random rnd = new Random();

            for(int i = 0; i < SIZE; i++)
            {
                result += Convert.ToString(rnd.Next(0, 9));
            }

            return result;
        }
    }
}
