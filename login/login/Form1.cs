using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="abhinav"&& textBox2.Text=="abhinav")
            {
                
                f2.Show();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("invalid username or password");
            }
        }
    }
}
