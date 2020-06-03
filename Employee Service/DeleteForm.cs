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

namespace Service_Application
{
    public partial class DeleteForm : Form
    {
        public string temp_id = default;
        private ConnectionDB data_base = new ConnectionDB();

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            idField.Text = temp_id;
            LoadDataBase(temp_id);
        }

        private void LoadDataBase(string temp_id)
        {
            var listOfData = new List<string>();
            var listOfColums = new List<Label>() { leftColumn, rightColumn };

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
                        }
                        else if (dataBaseReader[i] is Int32)
                        {
                            Int32 temp = dataBaseReader.GetInt32(i);
                            listOfData.Add(temp.ToString());
                        }
                        else listOfData.Add(dataBaseReader.GetString(i));
                    }
                }
                dataBaseReader.Close();

                for (int i = 0; i < listOfColums.Count; i++)
                {
                    listOfColums[i].Text = DescriptionBuilder(listOfData, i).ToString();
                }
            }
        }

        private StringBuilder DescriptionBuilder(List<string> listOfData, int index)
        {
            var listOfRows = new List<string>() { "ID: ", "Name: ", "Surname: ", "Birth Date: ", "Age: ", "Gender: ", "Pesel: ", "Country: ", 
                "City: ", "Postcode: ", "Phone number: ", "Address: ", "Company Name: ", "Position: " };

            var builder = new StringBuilder();
            var temp_size = listOfData.Count / 2;

            switch (index)
            {
                case 0:
                    for (int i = 0; i < temp_size; i++)
                    {
                        builder.Append($"{listOfRows[i]}{listOfData[i]}");
                        builder.Append($"\n\n");
                    } 
                    break;

                case 1:
                    for (int i = temp_size; i < listOfData.Count; i++)
                    {
                        builder.Append($"{listOfRows[i]}{listOfData[i]}");
                        builder.Append($"\n\n");
                    }
                    break;
            }

            return builder;
        }

        private void idField_TextChanged(object sender, EventArgs e)
        {
            if (idField.Text != temp_id)
            {
                temp_id = idField.Text;
                LoadDataBase(temp_id);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var command = new SqlCommand("DELETE Table_employees WHERE id = @id ", data_base.GetConnection()))
            {
                command.Parameters.Add("@id", SqlDbType.NChar).Value = temp_id;
                data_base.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Deleting completed successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = this.Owner as MainForm;
                    main.Updt();

                    data_base.CloseConnection();
                    this.Close();
                }
                else MessageBox.Show("Registration failed. Please, check your internet connection.", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
