using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool IsSuccessfull = false;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=SSPI");
            conn.Open();
            SqlCommand com = new SqlCommand("Select * From tblAccount Where username = '"+ txtUsername.Text +"' and pass = '"+ txtPass.Text +"'", conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                IsSuccessfull = true;
                MessageBox.Show("The login is successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The login failed!");
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
