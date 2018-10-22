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
    public partial class Form3 : Form
    {
        int f, l, s;
        string o;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(1);
            else
                screen.Text = Convert.ToString(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(2);
            else
                screen.Text = Convert.ToString(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(3);
            else
                screen.Text = Convert.ToString(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(4);
            else
                screen.Text = Convert.ToString(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(5);
            else
                screen.Text = Convert.ToString(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(6);
            else
                screen.Text = Convert.ToString(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(7);
            else
                screen.Text = Convert.ToString(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(8);
            else
                screen.Text = Convert.ToString(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(9);
            else
                screen.Text = Convert.ToString(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (screen.Text != null)

                screen.Text = screen.Text + Convert.ToString(0);
            else
                screen.Text = Convert.ToString(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            f = Convert.ToInt32(screen.Text);
            o = "-";
            screen.Text = f + "-";
            
            screen.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            l = Convert.ToInt32(screen.Text);
            if (o == "-")
            {
                s = f + l;
                screen.Text = f + "+" + l + "=" + s;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                l = Convert.ToInt32(screen.Text);
            }
            catch (Exception e1)

            {
                MessageBox.Show("enter input \n");

            }

            string str =screen.Text;
            

            if(o=="+")
            {
                s = f + l;
                screen.Text = f + "+" + l + "=" + s;
                f=s;
            }
            if (o == "-")
            {
                s = f - l;
                screen.Text = f + "-" + l + "=" + s;
                f = s;
            }
            if (o == "/")
            {
                s = f / l;
                screen.Text = f + "/" + l + "=" + s;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {  
            
            f = Convert.ToInt32(screen.Text);
            
            o = "+";
            screen.Text = f + "+";
            screen.Clear();
        }
    }
}
