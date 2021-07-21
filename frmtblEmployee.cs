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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        #region Create a connection object
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=FUH_COMPANY;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        #endregion

        #region Create a Dataset and DataAdapter object
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        #endregion

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select * From tblEmployee", conn);
            //Fill data to dataset
            da.Fill(ds, "tblEmployee");
            //Display data by using datagridview
            dgEmployees.DataSource = ds.Tables["tblEmployee"];
        }

        private void dgEmployees_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgEmployees.SelectedRows[0];
            txtEmpSSN.Text = dr.Cells["empSSN"].Value.ToString();
            txtEmpName.Text = dr.Cells["empName"].Value.ToString();
            txtEmpAddress.Text = dr.Cells["empAddress"].Value.ToString();
            txtEmpSalary.Text = dr.Cells["empSalary"].Value.ToString();
            txtEmpSex.Text = dr.Cells["empSex"].Value.ToString();
            txtEmpBirthdate.Text = dr.Cells["empBirthdate"].Value.ToString();
            txtDepNum.Text = dr.Cells["depNum"].Value.ToString();
            txtSupervisorSSN.Text = dr.Cells["supervisorSSN"].Value.ToString();
            txtEmpStartdate.Text = dr.Cells["empStartdate"].Value.ToString();
            //int index = dgEmployees.CurrentRow.Index;
            //txtEmpSSN.Text = dgEmployees.Rows[index].Cells[0].Value.ToString();
            //txtEmpName.Text = dgEmployees.Rows[index].Cells[1].Value.ToString();
            //txtEmpAddress.Text = dgEmployees.Rows[index].Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Decimal empSSN = Decimal.Parse(txtEmpSSN.Text);
                String empName = txtEmpName.Text;
                String empAddress = txtEmpAddress.Text;
                Decimal empSalary = Decimal.Parse(txtEmpSalary.Text);
                Char empSex = Char.Parse(txtEmpSex.Text);
                DateTime empBirthdate = DateTime.Parse(txtEmpBirthdate.Text);
                int depNum = Int32.Parse(txtDepNum.Text);
                Decimal supervisorSSN = Decimal.Parse(txtSupervisorSSN.Text);
                DateTime empStartdate = DateTime.Parse(txtEmpStartdate.Text);

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Insert_tblEmployee", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Insert_tblEmployee";

                //Format and assign values to the SQL insert parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@empName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empAddress", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empSalary", SqlDbType.Decimal);
                com.Parameters.Add("@empSex", SqlDbType.Char, 1);
                com.Parameters.Add("@empBirthdate", SqlDbType.DateTime);
                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters.Add("@supervisorSSN", SqlDbType.Decimal);
                com.Parameters.Add("@empStartdate", SqlDbType.DateTime);
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@empName"].Value = empName;
                com.Parameters["@empAddress"].Value = empAddress;
                com.Parameters["@empSalary"].Value = empSalary;
                com.Parameters["@empSex"].Value = empSex;
                com.Parameters["@empBirthdate"].Value = empBirthdate;
                com.Parameters["@depNum"].Value = depNum;
                com.Parameters["@supervisorSSN"].Value = supervisorSSN;
                com.Parameters["@empStartdate"].Value = empStartdate;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();

                #region MyRegion
                ////Updte tblEmployee Table with new row
                //DataRow r = ds.Tables["tblEmployee"].NewRow();
                //r["empSSN"] = txtEmpSSN.Text;
                //r["empName"] = txtEmpName.Text;
                //r["empAddress"] = txtEmpAddress.Text;
                //r["empSalary"] = txtEmpSalary.Text;
                //r["empSex"] = txtEmpSex.Text;
                //r["empBirthdate"] = txtEmpBirthdate.Text;
                //r["depNum"] = txtDepNum.Text;
                //r["supervisorSSN"] = txtSupervisorSSN.Text;
                //r["empStartdate"] = txtEmpStartdate.Text;
                //ds.Tables["tblEmployee"].Rows.Add(r);
                //SqlCommandBuilder comb = new SqlCommandBuilder(da);
                //da.Fill(ds, "tblEmployee");
                ////Update dataset to database
                //da.Update(ds, "tblEmployee");
                #endregion

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
                Decimal empSSN = Decimal.Parse(txtEmpSSN.Text);
                String empName = txtEmpName.Text;
                String empAddress = txtEmpAddress.Text;
                Decimal empSalary = Decimal.Parse(txtEmpSalary.Text);
                Char empSex = Char.Parse(txtEmpSex.Text);
                DateTime empBirthdate = DateTime.Parse(txtEmpBirthdate.Text);
                int depNum = Int32.Parse(txtDepNum.Text);
                Decimal supervisorSSN = Decimal.Parse(txtSupervisorSSN.Text);
                DateTime empStartdate = DateTime.Parse(txtEmpStartdate.Text);

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Update_tblEmployee", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Update_tblEmployee";

                //Format and assign values to the SQL update parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters.Add("@empName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empAddress", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@empSalary", SqlDbType.Decimal);
                com.Parameters.Add("@empSex", SqlDbType.Char, 1);
                com.Parameters.Add("@empBirthdate", SqlDbType.DateTime);
                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters.Add("@supervisorSSN", SqlDbType.Decimal);
                com.Parameters.Add("@empStartdate", SqlDbType.DateTime);
                com.Parameters["@empSSN"].Value = empSSN;
                com.Parameters["@empName"].Value = empName;
                com.Parameters["@empAddress"].Value = empAddress;
                com.Parameters["@empSalary"].Value = empSalary;
                com.Parameters["@empSex"].Value = empSex;
                com.Parameters["@empBirthdate"].Value = empBirthdate;
                com.Parameters["@depNum"].Value = depNum;
                com.Parameters["@supervisorSSN"].Value = supervisorSSN;
                com.Parameters["@empStartdate"].Value = empStartdate;
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
                String empSSN = txtEmpSSN.Text;

                #region Working with stored procedures
                SqlCommand com = new SqlCommand("sp_Delete_tblEmployee", conn);
                com.CommandType = CommandType.StoredProcedure;

                //SqlCommand com = conn.CreateCommand();
                //SqlCommand com = new SqlCommand();
                //com.Connection = conn;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "sp_Delete_tblEmployee";

                //Format and assign values to the SQL delete parameters
                com.Parameters.Add("@empSSN", SqlDbType.Decimal);
                com.Parameters["@empSSN"].Value = empSSN;
                #endregion

                com.ExecuteNonQuery();
                conn.Close();

                #region Setup TextBox
                txtEmpSSN.Text = "";
                txtEmpName.Text = "";
                txtEmpAddress.Text = "";
                txtEmpSalary.Text = "";
                txtEmpSex.Text = "";
                txtEmpBirthdate.Text = "";
                txtDepNum.Text = "";
                txtSupervisorSSN.Text = "";
                txtEmpStartdate.Text = "";
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
