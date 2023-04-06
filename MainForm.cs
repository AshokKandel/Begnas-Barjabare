using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LogIn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void campingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camping camping = new Camping();
            camping.Show();
        }

        private void boatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boating boating = new Boating();
            boating.Show();
        }

        private void homestayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homestay homestay = new Homestay();
            homestay.Show();
        }

       
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/Begnasbarjabare/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/groups/begnasbarjabare/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC1oCaz_pIAsgOKTfeVG5G4g");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/ashokkandel111/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.tiktok.com/@ashokkandel8");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox= false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus begnas = new aboutus();
            begnas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();  
            form1.Show();
        }

        private void photoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photo begnas = new photo();
            begnas.Show();

        }
    }
}
