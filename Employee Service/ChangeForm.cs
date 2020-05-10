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
    public partial class ChangeForm : Form
    {
        private int age = default;
        private DateTime birthDate = default;

        public string temp_id = default;

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            var data_base = new ConnectionDB();
            var listOfData = new List<string>();
            var listOfFields = new List<Control>() { labelID, nameField, surnameField, birthDateField, labelAge, genderCB, peselField, countryField, cityField, postcodeField,
                phoneNumberField, addressField, companyNameComboBox, comboBoxPosition };

            using (var command = new SqlCommand("SELECT * FROM Table_employees WHERE id = @id", data_base.GetConnection()))
            {
                command.Parameters.Add("@id", SqlDbType.NChar).Value = temp_id;

                data_base.OpenConnection();
                var dataBaseReader = command.ExecuteReader();

                while (dataBaseReader.Read())
                {
                    for (int i = 0; i < dataBaseReader.FieldCount - 1; i++)
                    {
                        if (dataBaseReader[i] is DateTime)
                        {
                            DateTime temp = dataBaseReader.GetDateTime(i);
                            listOfData.Add(temp.ToString("yyyy.MM.dd"));
                            birthDate = temp;
                        }
                        else if(dataBaseReader[i] is Int32)
                        {
                            Int32 temp = dataBaseReader.GetInt32(i);
                            listOfData.Add(temp.ToString());
                        }
                        else listOfData.Add(dataBaseReader.GetString(i));
                    }
                }

                for(int i = 0; i < listOfFields.Count; i++)
                {
                    if (listOfFields[i].Name == nameof(labelID)) listOfFields[i].Text = $"ID: {listOfData[i]}";
                    else if (listOfFields[i].Name == nameof(labelAge)) 
                    { 
                        listOfFields[i].Text = $"Age: {listOfData[i]}";
                        age = Convert.ToInt32(listOfData[i]);
                    }

                    if (listOfFields[i].GetType() == typeof(TextBox)) 
                    {
                        var tmpTB = listOfFields[i] as TextBox; 
                        tmpTB.Text = $"{listOfData[i]}"; 
                    }

                    if (listOfFields[i].GetType() == typeof(ComboBox))
                    {
                        var tmp = listOfFields[i] as ComboBox;
                        for (int j = 0; j < tmp.Items.Count; j++)
                        {
                            if (tmp.Items[j].Equals(listOfData[i])) tmp.SelectedItem = tmp.Items[j];
                        }
                    }
                }
            }
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var data_base = new ConnectionDB();

            using(var command = new SqlCommand("UPDATE Table_employees SET name = @name, surname = @surname, birth_date = @birthDate, age = @age, " +
                "gender = @gender, pesel = @pesel, country = @country, city = @city, postcode = @postcode, phone_number = @phoneNumber, address = @address, company_name = @companyName, position = @position " +
                "WHERE id = @id", data_base.GetConnection()))
            {
                command.Parameters.Add("@id", SqlDbType.NChar).Value = temp_id;
                command.Parameters.Add("@name", SqlDbType.NChar).Value = nameField.Text;
                command.Parameters.Add("@surname", SqlDbType.NChar).Value = surnameField.Text;
                command.Parameters.Add("@birthDate", SqlDbType.Date).Value = birthDateField.Text;
                command.Parameters.Add("@age", SqlDbType.Int).Value = age;
                command.Parameters.Add("@gender", SqlDbType.Text).Value = genderCB.SelectedItem;
                command.Parameters.Add("@pesel", SqlDbType.NChar).Value = peselField.Text;
                command.Parameters.Add("@country", SqlDbType.NChar).Value = countryField.Text;
                command.Parameters.Add("@city", SqlDbType.NChar).Value = cityField.Text;
                command.Parameters.Add("@postcode", SqlDbType.NChar).Value = postcodeField.Text;
                command.Parameters.Add("@phoneNumber", SqlDbType.NChar).Value = phoneNumberField.Text;
                command.Parameters.Add("@address", SqlDbType.Text).Value = addressField.Text;
                command.Parameters.Add("@companyName", SqlDbType.Text).Value = companyNameComboBox.SelectedItem;
                command.Parameters.Add("@position", SqlDbType.Text).Value = comboBoxPosition.SelectedItem;

                data_base.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Changing completed successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
