using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogIn { 
    
public partial class signup : Form
{
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public signup()
    {
        InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
        Form1 form1 = new Form1();
        form1.Show();
    }

    private void signup_Load(object sender, EventArgs e)
    {
        }

    private void button1_Click(object sender, EventArgs e)
    {

                //Adds a User in the Database
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    cmd = new MySqlCommand("insert into mydatabase.signup(fullName,email,address,contact,gender,password) values(@fullname,@email,@address,@contact,@gender,@password)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox5.Text);
                    cmd.Parameters.AddWithValue("@gender", textBox6.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Successfully Added", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // DisplayData();
                    //ClearData();


                }
                else
                {
                    MessageBox.Show("Fill out all the information needed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}

