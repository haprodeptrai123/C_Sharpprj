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
    public partial class frmtblDepartment : Form
    {
        public frmtblDepartment()
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

        private void frmtblDepartment_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            da = new SqlDataAdapter("Select depNum, depName, mgrSSN, mgrAssDate From tblDepartment", conn);
            //Fill data to dataset
            da.Fill(ds, "tblDepartment");
            //Display data by using datagridview
            dataGridView1.DataSource = ds.Tables["tblDepartment"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtDepNum.Text = dr.Cells["depNum"].Value.ToString();
            txtDepName.Text = dr.Cells["depName"].Value.ToString();
            txtMgrSSN.Text = dr.Cells["mgrSSN"].Value.ToString();
            txtMgrAssDate.Text = dr.Cells["mgrAssDate"].Value.ToString();
            //int index = dataGridView1.CurrentRow.Index;
            //txtDepNum.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtDepName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //txtMgrSSN.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtMgrAssDate.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
