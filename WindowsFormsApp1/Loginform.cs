using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.ToString();
            string password = tb_password.Text.ToString();

            if(username == "admin" && password == "1234")
            {
                
                this.Hide();
                Kasirapp form1 = new Kasirapp();
                form1.Show();

            } else
            {
                MessageBox.Show("Username atau password salah");
            }




        }

        private void Loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
        }
    }
}
