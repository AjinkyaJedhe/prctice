
namespace DataBaseApp
{
    partial class DataCRUDForm
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 213);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 62;
            this.dgData.RowTemplate.Height = 33;
            this.dgData.Size = new System.Drawing.Size(767, 225);
            this.dgData.TabIndex = 0;
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(127, 9);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(74, 25);
            this.lblEmpNo.TabIndex = 1;
            this.lblEmpNo.Text = "Emp no";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(123, 49);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(100, 25);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "Emp Name";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(127, 89);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(81, 25);
            this.lblHireDate.TabIndex = 3;
            this.lblHireDate.Text = "HireDate";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(127, 125);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 25);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(358, 9);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(150, 31);
            this.txtEmpNo.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(358, 49);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(150, 31);
            this.txtEmpName.TabIndex = 6;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(358, 89);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(150, 31);
            this.txtHireDate.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(358, 125);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 31);
            this.txtSalary.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(44, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(196, 163);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(112, 34);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Emp";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(358, 163);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Emp";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Emp";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(656, 163);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(112, 34);
            this.btnSearchEmp.TabIndex = 13;
            this.btnSearchEmp.Text = "Search Emp";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // DataCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.dgData);
            this.Name = "DataCRUDForm";
            this.Text = "DataCRUDForm";
            this.Load += new System.EventHandler(this.DataCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchEmp;
    }
}