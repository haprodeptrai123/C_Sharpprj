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
    public partial class frmLoginManage : Form
    {
        public frmLoginManage()
        {
            InitializeComponent();
        }

        #region Create a connection object
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        #endregion

        #region Create a Dataset and DataAdapter object
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        #endregion

        private void Form5_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select username, pass From tblAccount", conn);
            //Fill data to dataset
            da.Fill(ds, "tblAccount");
            //Display data by using datagridview
            dataGridView1.DataSource = ds.Tables["tblAccount"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtUsername.Text = dr.Cells["username"].Value.ToString();
            txtPassword.Text = dr.Cells["pass"].Value.ToString();
            //int index = dataGridView1.CurrentRow.Index;
            //txtUsername.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtPassword.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Updte tblWorksOn Table with new row
                DataRow r = ds.Tables["tblAccount"].NewRow();
                r["username"] = txtUsername.Text;
                r["pass"] = txtPassword.Text;
                ds.Tables["tblAccount"].Rows.Add(r);
                MessageBox.Show("Insert data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Update row in dataset
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                dataGridView1.BeginEdit(true);
                dr.Cells["username"].Value = txtUsername.Text;
                dr.Cells["pass"].Value = txtPassword.Text;
                dataGridView1.EndEdit();
                MessageBox.Show("Update data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Delete in dataset
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(dr);
                MessageBox.Show("Delete data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Delete data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            //Format SQL Insert and plug into DataAdapter
            SqlCommand incom = new SqlCommand("Insert into tblAccount values (@username,@pass)", conn);
            incom.Parameters.Add("@username", SqlDbType.VarChar, 50);
            incom.Parameters.Add("@pass", SqlDbType.VarChar, 50);
            incom.Parameters["@username"].Value = username;
            incom.Parameters["@pass"].Value = pass;
            da.InsertCommand = incom;

            //Format SQL Update and plug into DataAdapter
            SqlCommand upcom = new SqlCommand("Update tblAccount Set pass=@pass Where username=@username", conn);
            upcom.Parameters.Add("@username", SqlDbType.VarChar, 50);
            upcom.Parameters.Add("@pass", SqlDbType.VarChar, 50);
            upcom.Parameters["@username"].Value = username;
            upcom.Parameters["@pass"].Value = pass;
            da.UpdateCommand = upcom;

            //Format SQL Delete and plug into DataAdapter
            SqlCommand delcom = new SqlCommand("Delete From tblAccount Where username=@username", conn);
            delcom.Parameters.Add("@username", SqlDbType.VarChar, 50);
            delcom.Parameters["@username"].Value = username;
            da.DeleteCommand = delcom;
            txtUsername.Text = "";
            txtPassword.Text = "";
            try
            {
                //Update dataset to database
                da.Update(ds, "tblAccount");
                MessageBox.Show("Save data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
                Loaddata();
            }
            catch
            {
                MessageBox.Show("Save data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
