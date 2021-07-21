using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjManagement
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;
                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            Form frm = new Login();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmLoginManagement_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoginManage();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmEmpWorkingDay_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblWorksOn();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmListofEmployee_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmSearchSupervisor_Click(object sender, EventArgs e)
        {
            Form frm = new frmSupervisor();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmNumber_Click(object sender, EventArgs e)
        {
            Form frm = new frmCurrentNumber();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmProject_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblProject();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmsDependent_Click(object sender, EventArgs e)
        {
            Form frm = new frmDependent();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmRetirement_Click(object sender, EventArgs e)
        {
            Form frm = new frmRetirement();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmBirthDay_Click(object sender, EventArgs e)
        {
            Form frm = new frmBirthday();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmtblDepartment_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblDepartment();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmtblLocation_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblLocation();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmDepLocation_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblDepLocation();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmtbtDependent_Click(object sender, EventArgs e)
        {
            Form frm = new frmtblDependent();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmChildren_Click(object sender, EventArgs e)
        {
            Form frm = new frmChildren();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        private void tsmBaby_Click(object sender, EventArgs e)
        {
            Form frm = new frmBaby();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }
    }
}
