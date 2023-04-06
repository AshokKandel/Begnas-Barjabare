using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogIn
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=mydatabase;user=root;password=";

            // Create a MySqlConnection object and open the connection.
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SELECT query to retrieve the username and password from the database.
            string query = "SELECT * FROM signup WHERE fullName=@username AND password=@password";

            // Create a MySqlCommand object and associate it with the MySqlConnection.
            MySqlCommand command = new MySqlCommand(query, connection);

            // Set the parameters of the MySqlCommand object.
            command.Parameters.AddWithValue("@username", userTextbox.Text);
            command.Parameters.AddWithValue("@password", passwordTextbox.Text);

            // Execute the query and retrieve the results.
            MySqlDataReader reader = command.ExecuteReader();

            // Check if there is a row returned.
            if (reader.HasRows)
            {
                // Login successful
                MessageBox.Show("Login successful!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.");
            }

            // Close the SqlDataReader, MySqlConnection, and MySQLConnection objects.
            reader.Close();
            connection.Close();
        }


        private void signinButton_Click(object sender, EventArgs e)
        {

            
        }

          private void userTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        }
    }
}


