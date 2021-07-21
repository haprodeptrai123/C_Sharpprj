namespace ProjManagement
{
    partial class frmtblDependent
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depRelationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepBirthdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpSSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepSex = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DT-Cooper", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(42, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 48);
            this.label5.TabIndex = 23;
            this.label5.Text = "DEPENDENTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depName,
            this.empSSN,
            this.depSex,
            this.depBirthdate,
            this.depRelationship});
            this.dataGridView1.Location = new System.Drawing.Point(360, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 418);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // depName
            // 
            this.depName.DataPropertyName = "depName";
            this.depName.HeaderText = "DepName";
            this.depName.Name = "depName";
            this.depName.Width = 130;
            // 
            // empSSN
            // 
            this.empSSN.DataPropertyName = "empSSN";
            this.empSSN.HeaderText = "EmpSSN";
            this.empSSN.Name = "empSSN";
            this.empSSN.Width = 90;
            // 
            // depSex
            // 
            this.depSex.DataPropertyName = "depSex";
            this.depSex.HeaderText = "DepSex";
            this.depSex.Name = "depSex";
            this.depSex.Width = 90;
            // 
            // depBirthdate
            // 
            this.depBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.depBirthdate.DataPropertyName = "depBirthdate";
            this.depBirthdate.HeaderText = "DepBirthdate";
            this.depBirthdate.Name = "depBirthdate";
            // 
            // depRelationship
            // 
            this.depRelationship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depRelationship.DataPropertyName = "depRelationship";
            this.depRelationship.HeaderText = "DepRelationship";
            this.depRelationship.Name = "depRelationship";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 20);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(182, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 20);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(66, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 20);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(66, 315);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 20);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDepBirthdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtRelationship);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDepName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmpSSN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDepSex);
            this.groupBox1.Location = new System.Drawing.Point(25, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 175);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "            The list of employee\'s ralative";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "DepBirthdate";
            // 
            // txtDepBirthdate
            // 
            this.txtDepBirthdate.Location = new System.Drawing.Point(122, 101);
            this.txtDepBirthdate.Name = "txtDepBirthdate";
            this.txtDepBirthdate.Size = new System.Drawing.Size(156, 20);
            this.txtDepBirthdate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DepRelationship";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjManagement.Properties.Resources.apple;
            this.pictureBox2.Location = new System.Drawing.Point(15, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(122, 127);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(156, 20);
            this.txtRelationship.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DepName";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(122, 23);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(156, 20);
            this.txtDepName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EmpSSN";
            // 
            // txtEmpSSN
            // 
            this.txtEmpSSN.Location = new System.Drawing.Point(122, 49);
            this.txtEmpSSN.Name = "txtEmpSSN";
            this.txtEmpSSN.Size = new System.Drawing.Size(156, 20);
            this.txtEmpSSN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DepSex";
            // 
            // txtDepSex
            // 
            this.txtDepSex.Location = new System.Drawing.Point(122, 75);
            this.txtDepSex.Name = "txtDepSex";
            this.txtDepSex.Size = new System.Drawing.Size(156, 20);
            this.txtDepSex.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjManagement.Properties.Resources.fptlogo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmtblDependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtblDependent";
            this.Text = "tblDependent";
            this.Load += new System.EventHandler(this.frmtblDependent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpSSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepSex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn depSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn depBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn depRelationship;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepBirthdate;
    }
}