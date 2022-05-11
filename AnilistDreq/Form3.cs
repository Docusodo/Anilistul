using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnilistDreq
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";
                Email.ForeColor = Color.DarkCyan;
            }
          
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;
            }

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.DarkCyan;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
            }

        }

        private void Password1_Enter(object sender, EventArgs e)
        {
            if(Password1.Text == "Password")
            {
                Password1.Text = "";
                Password1.ForeColor = Color.DarkCyan;
            }
        }

        private void Password1_Leave(object sender, EventArgs e)
        {
            if (Password1.Text == "")
            {
                Password1.Text = "Password";
                Password1.ForeColor = Color.Silver;
            }

        }

        private void Password2_Enter(object sender, EventArgs e)
        {
            if (Password2.Text == "Confirm password")
            {
                Password2.Text = "";
                Password2.ForeColor = Color.DarkCyan;
            }
        }

        private void Password2_Leave(object sender, EventArgs e)
        {
            if (Password2.Text == "")
            {
                Password2.Text = "Confirm password";
                Password2.ForeColor = Color.Silver;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form2().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form2().Show();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
