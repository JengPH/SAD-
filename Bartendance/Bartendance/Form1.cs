using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartendance
{
    public partial class singupform : Form
    {
        public singupform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EJ\Documents\signup.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into detail values('"+txtname.Text+ "','" +txtemail.Text+ "','" + txtpass.Text + "', '" + txtcpass.Text + "')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Sign Up Successfully");

            txtname.Clear();
            txtemail.Clear();
            txtpass.Clear();
            txtcpass.Clear();
            
        }
    }
}
