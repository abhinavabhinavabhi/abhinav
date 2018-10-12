using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (studentradio.Checked == true)
            {
                if (username.Text == "abhinav" && password.Text == "abhi")
                {
                    MessageBox.Show("login sucsess");
                }
                else
                    MessageBox.Show("invalid");
                username.Clear();
                password.Clear();
                studentradio.Checked = false;
            }
                    
            else if (facultyradio.Checked==true)
            {
                if (username.Text == "faculty" && password.Text == "abhi")
                {
                    MessageBox.Show("sucsess");

                }
                else
                    MessageBox.Show("inavalid");
                username.Clear();
                password.Clear();
                facultyradio.Checked = false;

            }
            else if(adminradio.Checked==true)
            {
                if (username.Text == "admin" && password.Text == "abhi")
                {
                    MessageBox.Show("login sucsess");

                }
                else
                    MessageBox.Show("invalid");
            }
            else
            {
                MessageBox.Show("entee the option");
                username.Clear();
                password.Clear();
                studentradio.Checked = false;
                adminradio.Checked = false;
                facultyradio.Checked = false;

            }
                
                     
                
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
