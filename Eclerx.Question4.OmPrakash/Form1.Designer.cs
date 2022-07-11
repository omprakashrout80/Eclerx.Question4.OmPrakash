
namespace Eclerx.Question4.OmPrakash
{
    partial class Form1
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
            this.LblEmployeeNo = new System.Windows.Forms.Label();
            this.TxtEmployeeNo = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.LblEmployeeName = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.LblSalary = new System.Windows.Forms.Label();
            this.RadioPayroll = new System.Windows.Forms.RadioButton();
            this.RadioConsultant = new System.Windows.Forms.RadioButton();
            this.EmployeeType = new System.Windows.Forms.GroupBox();
            this.SelectedEmployee = new System.Windows.Forms.DataGridView();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.EmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmployeeNo
            // 
            this.LblEmployeeNo.AutoSize = true;
            this.LblEmployeeNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeNo.Location = new System.Drawing.Point(39, 43);
            this.LblEmployeeNo.Name = "LblEmployeeNo";
            this.LblEmployeeNo.Size = new System.Drawing.Size(115, 18);
            this.LblEmployeeNo.TabIndex = 0;
            this.LblEmployeeNo.Text = "Employee No";
            // 
            // TxtEmployeeNo
            // 
            this.TxtEmployeeNo.Location = new System.Drawing.Point(194, 36);
            this.TxtEmployeeNo.Name = "TxtEmployeeNo";
            this.TxtEmployeeNo.Size = new System.Drawing.Size(210, 23);
            this.TxtEmployeeNo.TabIndex = 1;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(194, 86);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(210, 23);
            this.TxtEmployeeName.TabIndex = 3;
            // 
            // LblEmployeeName
            // 
            this.LblEmployeeName.AutoSize = true;
            this.LblEmployeeName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeName.Location = new System.Drawing.Point(39, 93);
            this.LblEmployeeName.Name = "LblEmployeeName";
            this.LblEmployeeName.Size = new System.Drawing.Size(141, 18);
            this.LblEmployeeName.TabIndex = 2;
            this.LblEmployeeName.Text = "Employee Name";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(194, 127);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(210, 23);
            this.TxtSalary.TabIndex = 5;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalary.Location = new System.Drawing.Point(39, 134);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(60, 18);
            this.LblSalary.TabIndex = 4;
            this.LblSalary.Text = "Salary";
            // 
            // RadioPayroll
            // 
            this.RadioPayroll.AutoSize = true;
            this.RadioPayroll.Location = new System.Drawing.Point(51, 22);
            this.RadioPayroll.Name = "RadioPayroll";
            this.RadioPayroll.Size = new System.Drawing.Size(72, 18);
            this.RadioPayroll.TabIndex = 6;
            this.RadioPayroll.TabStop = true;
            this.RadioPayroll.Text = "Payroll";
            this.RadioPayroll.UseVisualStyleBackColor = true;
            // 
            // RadioConsultant
            // 
            this.RadioConsultant.AutoSize = true;
            this.RadioConsultant.Location = new System.Drawing.Point(51, 60);
            this.RadioConsultant.Name = "RadioConsultant";
            this.RadioConsultant.Size = new System.Drawing.Size(95, 18);
            this.RadioConsultant.TabIndex = 7;
            this.RadioConsultant.TabStop = true;
            this.RadioConsultant.Text = "Consultant";
            this.RadioConsultant.UseVisualStyleBackColor = true;
            // 
            // EmployeeType
            // 
            this.EmployeeType.Controls.Add(this.RadioPayroll);
            this.EmployeeType.Controls.Add(this.RadioConsultant);
            this.EmployeeType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeType.Location = new System.Drawing.Point(456, 36);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(200, 100);
            this.EmployeeType.TabIndex = 8;
            this.EmployeeType.TabStop = false;
            this.EmployeeType.Text = "Employee Type";
            // 
            // SelectedEmployee
            // 
            this.SelectedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedEmployee.Location = new System.Drawing.Point(23, 217);
            this.SelectedEmployee.Name = "SelectedEmployee";
            this.SelectedEmployee.Size = new System.Drawing.Size(633, 207);
            this.SelectedEmployee.TabIndex = 9;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNew.Location = new System.Drawing.Point(194, 172);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 10;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(329, 172);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 436);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.SelectedEmployee);
            this.Controls.Add(this.EmployeeType);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.LblEmployeeName);
            this.Controls.Add(this.TxtEmployeeNo);
            this.Controls.Add(this.LblEmployeeNo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employee Details";
            this.EmployeeType.ResumeLayout(false);
            this.EmployeeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeNo;
        private System.Windows.Forms.TextBox TxtEmployeeNo;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.Label LblEmployeeName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.RadioButton RadioPayroll;
        private System.Windows.Forms.RadioButton RadioConsultant;
        private System.Windows.Forms.GroupBox EmployeeType;
        private System.Windows.Forms.DataGridView SelectedEmployee;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnReset;
    }
}

