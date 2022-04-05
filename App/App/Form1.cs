using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace App
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Yeah!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                $"INSERT INTO [Students] (Name, Surname, Birthday, Birth_city, Phone, Email) VALUES (@Name, @Surname, @Birthday, @Birth_city, @Phone, @Email)",
                sqlConnection);

            DateTime date = DateTime.Parse(textBox3.Text);

            cmd.Parameters.AddWithValue("Name", textBox1.Text);
            cmd.Parameters.AddWithValue("Surname", textBox2.Text);
            cmd.Parameters.AddWithValue("Birthday", $"{date.Month}/{date.Day}/{date.Year}");
            cmd.Parameters.AddWithValue("Birth_city", textBox4.Text);
            cmd.Parameters.AddWithValue("Phone", textBox5.Text);
            cmd.Parameters.AddWithValue("Email", textBox6.Text);
            MessageBox.Show(cmd.ExecuteNonQuery().ToString());
        }
    }
}
