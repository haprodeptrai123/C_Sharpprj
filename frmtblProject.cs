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
    public partial class frmtblProject : Form
    {
        public frmtblProject()
        {
            InitializeComponent();
        }
    
        #region Create a connection object
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=FUH_COMPANY;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        #endregion

        #region Create a Dataset and DataAdapter object
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        #endregion

        private void frmProject_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select proNum, proName, locNum, depNum From tblProject", conn);
            //Fill data to dataset
            da.Fill(ds, "tblProject");
            //Display data by using datagridview
            dataGridView1.DataSource = ds.Tables["tblProject"];
   
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtProNum.Text = dr.Cells["proNum"].Value.ToString();
            txtProName.Text = dr.Cells["proName"].Value.ToString();
            txtLocNum.Text = dr.Cells["locNum"].Value.ToString();
            txtDepNum.Text = dr.Cells["depNum"].Value.ToString();
            //int index = dataGridView1.CurrentRow.Index;
            //txtProNum.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtProName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //txtLockNum.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtDepNum.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int proNum = Int32.Parse(txtProNum.Text);
                String proName = txtProName.Text;
                int locNum = Int32.Parse(txtLocNum.Text);
                int depNum = Int32.Parse(txtDepNum.Text);

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Insert_tblProject", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Insert_tblProject";

                //Format and assign values to the SQL insert parameters
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters.Add("@proName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@locNum", SqlDbType.Int);
                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters["@proNum"].Value = txtProNum.Text;
                com.Parameters["@proName"].Value = txtProName.Text;
                com.Parameters["@locNum"].Value = txtLocNum.Text;
                com.Parameters["@depNum"].Value = txtDepNum.Text;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
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
                int proNum = Int32.Parse(txtProNum.Text);
                String proName = txtProName.Text;
                int locNum = Int32.Parse(txtLocNum.Text);
                int depNum = Int32.Parse(txtDepNum.Text);

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Update_tblProject", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Update_tblProject";

                //Format and assign values to the SQL update parameters
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters.Add("@proName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@locNum", SqlDbType.Int);
                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters["@proNum"].Value = txtProNum.Text;
                com.Parameters["@proName"].Value = txtProName.Text;
                com.Parameters["@locNum"].Value = txtLocNum.Text;
                com.Parameters["@depNum"].Value = txtDepNum.Text;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
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
                String proNum = txtProNum.Text;

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Delete_tblProject", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Delete_tblProject";

                //Format and assign values to the SQL delete parameters
                com.Parameters.Add("@proNum", SqlDbType.Int);
                com.Parameters["@proNum"].Value = txtProNum.Text;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();

                #region Setup TextBox
                txtProNum.Text = "";
                txtProName.Text = "";
                txtLocNum.Text = "";
                txtDepNum.Text = "";
                #endregion

                MessageBox.Show("Delete data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
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
