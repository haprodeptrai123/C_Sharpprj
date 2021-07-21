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
    public partial class frmDependent : Form
    {
        public frmDependent()
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

        private void frmDependent_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select empSSN, empName From tblEmployee", conn);
            //Fill data to dataset
            da.Fill(ds, "tblEmployee");
            //Display data by using datagridview
            cbDependent.DataSource = ds.Tables["tblEmployee"];
            cbDependent.DisplayMember = "empName";
            cbDependent.ValueMember = "empSSN";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            LivDemo.Items.Clear();
            
            #region Create a SqlCommand object and execute stored procedures
            //SqlCommand com = new SqlCommand("sp_Select_tblWorksOn", conn);
            //com.CommandType = CommandType.StoredProcedure;

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_Select_sDependent";
            com.Parameters.Add("@empSSN", SqlDbType.Decimal);
            com.Parameters["@empSSN"].Value = cbDependent.SelectedValue;
            com.ExecuteNonQuery();
            #endregion
           
            #region Obtain a SqlDataReader via ExecuteReader()
            SqlDataReader dr = com.ExecuteReader();
            #endregion

            int i = 0;

            #region Loop over the results
            while (dr.Read())
            {
                LivDemo.Items.Add(dr["depName"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["empSSN"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["depSex"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["depBirthdate"].ToString());
                LivDemo.Items[i].SubItems.Add(dr["depRelationship"].ToString());
                i++;
            }
            #endregion

            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

