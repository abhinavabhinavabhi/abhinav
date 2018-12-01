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
using System.IO;

namespace login
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\login\login\image.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            
           
                byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);
            
           SqlCommand str = new SqlCommand("insert into student values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +comboBox1.Text+ "',@pic)",con);
           SqlParameter pr = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
           str.Parameters.Add(pr);
           try
           {
               str.ExecuteNonQuery();
           }
           catch(Exception e1)
           {
               MessageBox.Show("error");
           }
           MessageBox.Show("saved");
            
           con.Close();
            refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.imageDataSet.student);

        }
        public void refresh()
        {
            con.Open();
            SqlDataAdapter st = new SqlDataAdapter("select * from student", con);
            DataTable dt = new DataTable();
            st.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select image from student where idno='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           
                byte[] myimg = new byte[0];
            try
            {
                myimg = (byte[])dt.Rows[0][0];
            }
            catch(Exception e3)
            {
                MessageBox.Show("verify input ");
            }
            MemoryStream ms = new MemoryStream(myimg);
            pictureBox1.Image = Image.FromStream(ms);
            con.Close();

        }
    }
}
