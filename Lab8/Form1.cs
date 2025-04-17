using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Lab8
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection connection;
        private DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = @"server=localhost; port=5432; username=postgres; password=1; database=postgres";
            connection = new NpgsqlConnection(connStr);

            LoadCitiesToComboBox();
            LoadLectures(); 
        }

        private void LoadCitiesToComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Выберите город");

            string commandText = "select distinct city from lectures";
            DataTable citiesTable = new DataTable();

            using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["city"].ToString());
                    }
                }
                connection.Close();
            }

            comboBox1.SelectedIndex = 0;
        }

        private void LoadLectures(string cityFilter = null)
        {
            ds.Clear();
            string commandText = "SELECT * FROM lectures";

            if (!string.IsNullOrEmpty(cityFilter))
            {
                commandText += " WHERE city = @city";
            }

            using (var adapter = new NpgsqlDataAdapter(commandText, connection))
            {
                if (!string.IsNullOrEmpty(cityFilter))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@city", cityFilter);
                }

                connection.Open();
                adapter.Fill(ds, "lectures");
                connection.Close();
            }

            dataGridView1.DataSource = ds.Tables["lectures"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                LoadLectures(); 
            }
            else
            {
                string selectedCity = comboBox1.SelectedItem.ToString();
                LoadLectures(selectedCity); 
            }
        }
    }
}