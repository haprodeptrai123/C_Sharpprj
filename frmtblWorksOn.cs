using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ProjManagement
{
    public partial class frmtblWorksOn : Form
    {
        public frmtblWorksOn()
        {
            InitializeComponent();
        }

        #region Create a connection object
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=FUH_COMPANY;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Loaddata();
                MessageBox.Show("The connection is successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("The connection failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Loaddata()
        {
            conn.Open();

            // 1. Create and execute query command
            // Command objects are used to perform actions on the data source. 
            // Command objects can execute stored procedures and T-SQL commands

            #region Create a SqlCommand object and execute T-SQL commands
            //SqlCommand com = new SqlCommand("Select empSSN,proNum,workHours From tblWorksOn", conn);

            //SqlCommand com = new SqlCommand();
            //com.Connection = conn;
            //com.CommandText = "Select empSSN,proNum,workHours From tblWorksOn";

            //SqlCommand com = conn.CreateCommand();
            //com.Connection = conn;
            //com.CommandText = "Select empSSN,proNum,workHours From tblWorksOn";
            #endregion

            #region Create a SqlCommand object and execute stored procedures
            //SqlCommand com = new SqlCommand("sp_Select_tblWorksOn", conn);
            //com.CommandType = CommandType.StoredProcedure;

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_Select_tblWorksOn";
            #endregion
            
            #region Obtain a SqlDataReader via ExecuteReader()
            SqlDataReader dr = com.ExecuteReader();
            #endregion
            
            // 2. Read the returned records
            int i = 0;

            #region Loop over the results
            while (dr.Read())
            {
                LivDemo.Items.Add(dr["empSSN"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["proNum"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["workHours"].ToString());
                i++;
            }
            #endregion

            conn.Close();
        }

        private void LivDemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem list in LivDemo.SelectedItems)
            {
                txtEmpSSN.Text = list.SubItems[0].Text;
                txtProNum.Text = list.SubItems[1].Text;
                txtWorkHours.Text = list.SubItems[2].Text;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String empSSN = txtEmpSSN.Text;
                String proNum = txtProNum.Text;
                String workHours = txtWorkHours.Text;

                #region Working with an SQL text commands
                //SqlCommand com = new SqlCommand("Insert into tblWorksOn values (" + empSSN + ", " + proNum + ", " + workHours + ")", conn);
                #endregion

                #region Working with parameterized command objects
                //// To associate a parameter within a SQL statement to a member in
                //// the command object’s parameters collection, prefix the SQL 
                //// text parameter with an at (@) symboL
                //SqlCommand com = new SqlCommand("Insert into tblWorksOn values (@empSSN,@proNum,@workHours)", conn);
                ////Format and assign values to the SQL insert parameters
                //com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                //com.Parameters.Add("@proNum", SqlDbType.Int);
                //com.Parameters.Add("@workHours", SqlDbType.Int);
                //com.Parameters["@empSSN"].Value = empSSN;
                //com.Parameters["@proNum"].Value = proNum;
                //com.Parameters["@workHours"].Value = workHours;
                #endregion

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Insert_tblWorksOn", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Insert_tblWorksOn";

                //Format and assign values to the SQL insert parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters.Add("@workHours", SqlDbType.Int);
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@proNum"].Value = proNum;
                com.Parameters["@workHours"].Value = workHours;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LivDemo.Items.Clear();
                Loaddata();
            }
            catch
            {
                MessageBox.Show("Insert data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String empSSN = txtEmpSSN.Text;
                String proNum = txtProNum.Text;
                String workHours = txtWorkHours.Text;

                #region Working with an SQL text commands
                //SqlCommand com = new SqlCommand("Update tblWorksOn Set workHours = " + workHours + " Where empSSN = " + empSSN + " and proNum = " + proNum + "", conn);
                #endregion

                #region Working with parameterized command objects
                //SqlCommand com = new SqlCommand("Update tblWorksOn Set workHours=@workHours Where empSSN=@empSSN and proNum=@proNum", conn);
                ////Format and assign values to the SQL update parameters
                //com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                //com.Parameters.Add("@proNum", SqlDbType.Int);
                //com.Parameters.Add("@workHours", SqlDbType.Int);
                //com.Parameters["@empSSN"].Value = empSSN;
                //com.Parameters["@proNum"].Value = proNum;
                //com.Parameters["@workHours"].Value = workHours;
                #endregion

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Update_tblWorksOn", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Update_tblWorksOn";

                //Format and assign values to the SQL update parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters.Add("@workHours", SqlDbType.Int);
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@proNum"].Value = proNum;
                com.Parameters["@workHours"].Value = workHours;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LivDemo.Items.Clear();
                Loaddata();
            }
            catch
            {
                MessageBox.Show("Update data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String empSSN = txtEmpSSN.Text;
                String proNum = txtProNum.Text;

                #region Working with an SQL text commands
                //SqlCommand com = new SqlCommand("Delete From tblWorksOn Where empSSN = " + empSSN + " and proNum = " + proNum + "", conn);
                #endregion

                #region Working with parameterized command objects
                //SqlCommand com = new SqlCommand("Delete From tblWorksOn Where empSSN=@empSSN and proNum=@proNum", conn);
                ////Format and assign values to the SQL delete parameters
                //com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                //com.Parameters.Add("@proNum", SqlDbType.Int);
                //com.Parameters["@empSSN"].Value = empSSN;
                //com.Parameters["@proNum"].Value = proNum;
                #endregion

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Delete_tblWorksOn", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Delete_tblWorksOn";

                //Format and assign values to the SQL delete parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@proNum"].Value = proNum;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();
                txtEmpSSN.Text = "";
                txtProNum.Text = "";
                txtWorkHours.Text = "";
                MessageBox.Show("Delete data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LivDemo.Items.Clear();
                Loaddata();
            }
            catch
            {
                MessageBox.Show("Delete data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
