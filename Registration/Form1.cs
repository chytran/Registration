using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Registration
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = (@"Data Source=DESKTOP-E93ERMF\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + addresstxt.Text + "', '" + genderOption.SelectedItem.ToString() + "', '" + emailtxt.Text + "', '" + phonetxt.Text + "', '" + usertxt.Text + "', '" + passwordtxt.Text +"')" , con);
           con.Open();  
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successful");
        }
    }
}
