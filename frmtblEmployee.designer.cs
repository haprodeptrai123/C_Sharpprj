namespace ProjManagement
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpSSN = new System.Windows.Forms.TextBox();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupervisorSSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpBirthdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpStartdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.empSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empStartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpSSN :";
            // 
            // txtEmpSSN
            // 
            this.txtEmpSSN.Location = new System.Drawing.Point(96, 28);
            this.txtEmpSSN.Name = "txtEmpSSN";
            this.txtEmpSSN.Size = new System.Drawing.Size(124, 20);
            this.txtEmpSSN.TabIndex = 1;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(96, 53);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(124, 20);
            this.txtEmpSalary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EmpSalary :";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(328, 28);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(124, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EmpName :";
            // 
            // txtEmpSex
            // 
            this.txtEmpSex.Location = new System.Drawing.Point(328, 54);
            this.txtEmpSex.Name = "txtEmpSex";
            this.txtEmpSex.Size = new System.Drawing.Size(124, 20);
            this.txtEmpSex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EmpSex :";
            // 
            // txtSupervisorSSN
            // 
            this.txtSupervisorSSN.Location = new System.Drawing.Point(328, 80);
            this.txtSupervisorSSN.Name = "txtSupervisorSSN";
            this.txtSupervisorSSN.Size = new System.Drawing.Size(124, 20);
            this.txtSupervisorSSN.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SupervisorSSN :";
            // 
            // txtDepNum
            // 
            this.txtDepNum.Location = new System.Drawing.Point(96, 80);
            this.txtDepNum.Name = "txtDepNum";
            this.txtDepNum.Size = new System.Drawing.Size(124, 20);
            this.txtDepNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DepNum :";
            // 
            // txtEmpBirthdate
            // 
            this.txtEmpBirthdate.Location = new System.Drawing.Point(571, 53);
            this.txtEmpBirthdate.Name = "txtEmpBirthdate";
            this.txtEmpBirthdate.Size = new System.Drawing.Size(124, 20);
            this.txtEmpBirthdate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "EmpBirthdate :";
            // 
            // txtEmpStartdate
            // 
            this.txtEmpStartdate.Location = new System.Drawing.Point(571, 80);
            this.txtEmpStartdate.Name = "txtEmpStartdate";
            this.txtEmpStartdate.Size = new System.Drawing.Size(124, 20);
            this.txtEmpStartdate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "EmpStartdate :";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(571, 27);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(124, 20);
            this.txtEmpAddress.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "EmpAddress :";
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empSSN,
            this.empName,
            this.empAddress,
            this.empSalary,
            this.empSex,
            this.empBirthdate,
            this.depNum,
            this.supervisorSSN,
            this.empStartdate});
            this.dgEmployees.Location = new System.Drawing.Point(25, 22);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(894, 326);
            this.dgEmployees.TabIndex = 18;
            this.dgEmployees.Click += new System.EventHandler(this.dgEmployees_Click);
            // 
            // empSSN
            // 
            this.empSSN.DataPropertyName = "empSSN";
            this.empSSN.HeaderText = "EmpSSN";
            this.empSSN.Name = "empSSN";
            this.empSSN.Width = 80;
            // 
            // empName
            // 
            this.empName.DataPropertyName = "empName";
            this.empName.HeaderText = "EmpName";
            this.empName.Name = "empName";
            this.empName.Width = 130;
            // 
            // empAddress
            // 
            this.empAddress.DataPropertyName = "empAddress";
            this.empAddress.HeaderText = "EmpAddress";
            this.empAddress.Name = "empAddress";
            this.empAddress.Width = 120;
            // 
            // empSalary
            // 
            this.empSalary.DataPropertyName = "empSalary";
            this.empSalary.HeaderText = "EmpSalary";
            this.empSalary.Name = "empSalary";
            this.empSalary.Width = 80;
            // 
            // empSex
            // 
            this.empSex.DataPropertyName = "empSex";
            this.empSex.HeaderText = "EmpSex";
            this.empSex.Name = "empSex";
            this.empSex.Width = 80;
            // 
            // empBirthdate
            // 
            this.empBirthdate.DataPropertyName = "empBirthdate";
            this.empBirthdate.FillWeight = 120F;
            this.empBirthdate.HeaderText = "EmpBirthdate";
            this.empBirthdate.Name = "empBirthdate";
            this.empBirthdate.Width = 80;
            // 
            // depNum
            // 
            this.depNum.DataPropertyName = "depNum";
            this.depNum.HeaderText = "DepNum";
            this.depNum.Name = "depNum";
            this.depNum.Width = 80;
            // 
            // supervisorSSN
            // 
            this.supervisorSSN.DataPropertyName = "supervisorSSN";
            this.supervisorSSN.HeaderText = "SupervisorSSN";
            this.supervisorSSN.Name = "supervisorSSN";
            // 
            // empStartdate
            // 
            this.empStartdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empStartdate.DataPropertyName = "empStartdate";
            this.empStartdate.HeaderText = "EmpStartdate";
            this.empStartdate.Name = "empStartdate";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(744, 70);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 23);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(821, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(744, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(821, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDepNum);
            this.groupBox1.Controls.Add(this.txtEmpSSN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSupervisorSSN);
            this.groupBox1.Controls.Add(this.txtEmpSalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpStartdate);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmpAddress);
            this.groupBox1.Controls.Add(this.txtEmpSex);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmpBirthdate);
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 116);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                Personal Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjManagement.Properties.Resources.apple;
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(25, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 144);
            this.panel1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mouser", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(739, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "EMPLOYEES";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The list of employee";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpSSN;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupervisorSSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpBirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpStartdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn empStartdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;

    }
}