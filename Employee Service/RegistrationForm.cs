using Employee_Service;
using Service_Application.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Application
{
    public partial class RegistrationForm : Form
    {
        private int age = default;
        private DateTime birthDate = default;
        private AutorizationForm autorizationForm = new AutorizationForm();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            labelAge.Text = default;
            label_IDCode.Text = default;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            const int SIZE = 6;
            string symbolSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random rand = new Random();
            StringBuilder sb = new StringBuilder(SIZE);

            for(int i = 0; i < SIZE; i++)
            {
                sb.Append(symbolSet[rand.Next(symbolSet.Length)]);
            }
            
            string result = sb.ToString();
            label_IDCode.Text = result;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            autorizationForm.Show();

            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            List<string> fields_list = new List<string>();
            bool IsVerify = FieldsNotNull(fields_list);

            if (IsVerify)
            {
                var pass_temp = PassCryptor(label_IDCode.Text);
                var data_base = new ConnectionDB();

                using (var command = new SqlCommand("INSERT INTO Table_company_collaborators(name, surname, birth_date, age, gender, pesel, country, city, postcode, phone_number, password, position, date_of_registration)" +
                "VALUES(@name, @surname, @birthDate, @age, @gender, @pesel, @country, @city, @postcode, @phoneNumber, @password, @position, @dateOfRegistration)", data_base.GetConnection()))
                {
                    command.Parameters.Add("@name", SqlDbType.NChar).Value = nameField.Text;
                    command.Parameters.Add("@surname", SqlDbType.NChar).Value = surnameField.Text;
                    command.Parameters.Add("@birthDate", SqlDbType.Date).Value = birthDate;
                    command.Parameters.Add("@age", SqlDbType.Int).Value = age;
                    command.Parameters.Add("@gender", SqlDbType.Char).Value = comboBoxGender.SelectedItem;
                    command.Parameters.Add("@pesel", SqlDbType.NChar).Value = peselField.Text;
                    command.Parameters.Add("@country", SqlDbType.NChar).Value = countryField.Text;
                    command.Parameters.Add("@city", SqlDbType.NChar).Value = cityField.Text;
                    command.Parameters.Add("@postcode", SqlDbType.NChar).Value = postcodeField.Text;
                    command.Parameters.Add("@phoneNumber", SqlDbType.NChar).Value = phoneNumberField.Text;
                    command.Parameters.Add("@password", SqlDbType.Binary).Value = pass_temp;
                    command.Parameters.Add("@position", SqlDbType.NChar).Value = comboBoxPosition.SelectedItem;
                    command.Parameters.Add("@dateOfRegistration", SqlDbType.DateTime).Value = DateTime.Now;

                    data_base.OpenConnection();

                    if (command.ExecuteNonQuery() == 1) 
                    { 
                        MessageBox.Show("Registration completed successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autorizationForm.Show();
                        this.Close();

                    }
                    else MessageBox.Show("Registration failed. Please, check your internet connection.", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    data_base.CloseConnection();
                }
            }
            else
            {
                var count = fields_list.Count();
                var temp_message = new StringBuilder();
                temp_message.AppendLine($"{count} fields is null. Please check this fields:");
                temp_message.AppendLine("");

                foreach (string l in fields_list)
                {
                    temp_message.AppendLine($" • Field \"{l}\" must not be null.");
                    temp_message.AppendLine("");
                }

                MessageBox.Show(temp_message.ToString(), "FIELD IS NULL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private byte[] PassCryptor(string password)
        {
            using(var sha = new SHA256Managed())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool FieldsNotNull(List<string> fields)
        {
            int counter = default;
            List<TextBox> fieldsList = new List<TextBox>() { nameField, surnameField, birthDateField, peselField, countryField, cityField, postcodeField, phoneNumberField };
            List<ComboBox> comboList = new List<ComboBox>() { comboBoxGender, comboBoxPosition };
            List<Label> labelList = new List<Label>() { labelAge, label_IDCode };

            foreach(var x in fieldsList)
            {
                if(x.Text == String.Empty)
                {
                    fields.Add(x.Name);
                    counter++;
                }
            }

            foreach (var y in comboList)
            {
                if (y.SelectedItem == null)
                {
                    fields.Add(y.Name);
                    counter++;
                }
            }

            foreach (var r in labelList)
            {
                if (r.Text == String.Empty)
                {
                    fields.Add(r.Name);
                    counter++;
                }
            }

            if (counter > 0) return false;
            else return true;
        }
    }
}
