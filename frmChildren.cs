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
    public partial class frmChildren : Form
    {
        public frmChildren()
        {
            InitializeComponent();
        }

        #region Create a connection object
        SqlConnection conn = new SqlConnection(@"Data Source=WIN-STQ4JGMACB6\SQLEXPRESS;Initial Catalog=FUH_COMPANY;Integrated Security=SSPI");
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
        #endregion

        #region Create a Dataset and DataAdapter object
        //DataSet ds = new DataSet();
        //SqlDataAdapter da;
        #endregion

        private void frmChildren_Load(object sender, EventArgs e)
        {
            conn.Open();

            #region Create a SqlCommand object and execute stored procedures
            //SqlCommand com = new SqlCommand("sp_Select_Children", conn);
            //com.CommandType = CommandType.StoredProcedure;

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_Select_Children";
            #endregion

            #region Obtain a SqlDataReader via ExecuteReader()
            SqlDataReader dr = com.ExecuteReader();
            #endregion

            int i = 0;
            #region Loop over the results
            while (dr.Read())
            {
                LivRetirement.Items.Add(dr["empSSN"].ToString());
                LivRetirement.Items[i].SubItems.Add(dr["empName"].ToString());
                LivRetirement.Items[i].SubItems.Add(dr["depName"].ToString());
                LivRetirement.Items[i].SubItems.Add(dr["depSex"].ToString());
                LivRetirement.Items[i].SubItems.Add(dr["depBirthDate"].ToString());
                
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
