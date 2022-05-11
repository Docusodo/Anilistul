using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnilistDreq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=REVISION-PC;Initial Catalog=Anilist;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtUserName.Text;    
            user_password = txtpassword.Text;

            try 
            {
                String querry = "SELECT * FROM Login WHERE username = '" + txtUserName.Text + "' AND  password = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable =new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0) 
                {
                    username = txtUserName.Text;
                    user_password = txtpassword.Text;

                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login  details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   txtUserName.Clear();
                   txtpassword.Clear();

                    txtUserName.Focus();
                   
                    

                }
                    }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
           
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Email")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.DarkCyan;
                

            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Email";
                txtUserName.ForeColor = Color.DarkCyan;

            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if(txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.DarkCyan;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.DarkCyan;
            }

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {
       
        }

        private void Form2_DragOver(object sender, DragEventArgs e)
        {
         
        }
    }
}
