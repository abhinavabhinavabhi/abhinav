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
            Form3 f3 = new Form3(); 
            if (studentradio.Checked == true)
            {
                if (username.Text == "abhinav" && password.Text == "abhi")
                {
                    MessageBox.Show("login sucsess");
                    f3.Show();

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
                    f3.Show();

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
                    f3.Show();

                }
                else
                    MessageBox.Show("invalid");
            }
            else
            {
                MessageBox.Show("enter the option");
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        private void button7_Click(object sender, EventArgs e)
        {
          
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
        }
        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb = comboBox1.Text;
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            
            

        }

        private void button10_Click(object sender, EventArgs e)
        {

          
        }
    }
}
