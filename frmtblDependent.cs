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
    public partial class frmtblDependent : Form
    {
        public frmtblDependent()
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

        private void frmtblDependent_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select depName, empSSN, depSex, depBirthdate, depRelationship From tblDependent", conn);
            //Fill data to dataset
            da.Fill(ds, "tblDependent");
            //Display data by using datagridview
            dataGridView1.DataSource = ds.Tables["tblDependent"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtDepName.Text = dr.Cells["depName"].Value.ToString();
            txtEmpSSN.Text = dr.Cells["empSSN"].Value.ToString();
            txtDepSex.Text = dr.Cells["depSex"].Value.ToString();
            txtDepBirthdate.Text = dr.Cells["depBirthdate"].Value.ToString();
            txtRelationship.Text = dr.Cells["depRelationship"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String depName = txtDepName.Text;
                Decimal empSSN = Decimal.Parse(txtEmpSSN.Text);
                Char depSex = Char.Parse(txtDepSex.Text);
                DateTime depBirthdate = DateTime.Parse(txtDepBirthdate.Text);
                String depRelationship = txtRelationship.Text;

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Insert_tblDependent", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Insert_tblDependent";

                //Format and assign values to the SQL insert parameters
                com.Parameters.Add("@depName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@depSex", SqlDbType.Char, 1);
                com.Parameters.Add("@depBirthdate", SqlDbType.DateTime);
                com.Parameters.Add("@depRelationship", SqlDbType.NVarChar, 50);
                com.Parameters["@depName"].Value = depName;
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@depSex"].Value = depSex;
                com.Parameters["@depBirthdate"].Value = depBirthdate;
                com.Parameters["@depRelationship"].Value = depRelationship;
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
                String depName = txtDepName.Text;
                Decimal empSSN = Decimal.Parse(txtEmpSSN.Text);
                Char depSex = Char.Parse(txtDepSex.Text);
                DateTime depBirthdate = DateTime.Parse(txtDepBirthdate.Text);
                String depRelationship = txtRelationship.Text;

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Update_tblDependent", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Update_tblDependent";

                //Format and assign values to the SQL update parameters
                com.Parameters.Add("@depName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@depSex", SqlDbType.Char, 1);
                com.Parameters.Add("@depBirthdate", SqlDbType.DateTime);
                com.Parameters.Add("@depRelationship", SqlDbType.NVarChar, 50);
                com.Parameters["@depName"].Value = depName;
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@depSex"].Value = depSex;
                com.Parameters["@depBirthdate"].Value = depBirthdate;
                com.Parameters["@depRelationship"].Value = depRelationship;
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
                String depName = txtDepName.Text;
                Decimal empSSN = Decimal.Parse(txtEmpSSN.Text);

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Delete_tblDependent", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Delete_tblDependent";

                //Format and assign values to the SQL delete parameters
                com.Parameters.Add("@depName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters["@depName"].Value = depName;
                com.Parameters["@empSSN"].Value = empSSN;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();

                #region Setup TextBox
                txtDepName.Text = "";
                txtEmpSSN.Text = "";
                txtDepSex.Text = "";
                txtDepBirthdate.Text = "";
                txtRelationship.Text = "";
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
