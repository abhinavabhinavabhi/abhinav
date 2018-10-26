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


namespace database
{
    public partial class Form1 : Form
        
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\abhinav\database\database\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "INSERT into employee values('"+ id.Text+"','"+name.Text+"','"+dept.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.employee);

        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
