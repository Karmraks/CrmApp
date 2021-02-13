
namespace Test
{
    partial class EmployeeForm
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
            this.hired = new System.Windows.Forms.DateTimePicker();
            this.fired = new System.Windows.Forms.DateTimePicker();
            this.secondName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.SName = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.Sal = new System.Windows.Forms.Label();
            this.Hir = new System.Windows.Forms.Label();
            this.Fir = new System.Windows.Forms.Label();
            this.Pos = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // hired
            // 
            this.hired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hired.Location = new System.Drawing.Point(24, 168);
            this.hired.Name = "hired";
            this.hired.Size = new System.Drawing.Size(200, 20);
            this.hired.TabIndex = 0;
            // 
            // fired
            // 
            this.fired.CustomFormat = " ";
            this.fired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fired.Location = new System.Drawing.Point(24, 201);
            this.fired.Name = "fired";
            this.fired.Size = new System.Drawing.Size(200, 20);
            this.fired.TabIndex = 1;
            this.fired.Value = new System.DateTime(2020, 11, 24, 16, 43, 1, 0);
            this.fired.ValueChanged += new System.EventHandler(this.fired_ValueChanged);
            this.fired.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fired_KeyDown);
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(24, 22);
            this.secondName.Multiline = true;
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(200, 24);
            this.secondName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(24, 59);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 24);
            this.firstName.TabIndex = 3;
            // 
            // SName
            // 
            this.SName.AutoSize = true;
            this.SName.Location = new System.Drawing.Point(237, 25);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(56, 13);
            this.SName.TabIndex = 6;
            this.SName.Text = "Фамилия";
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(237, 62);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(29, 13);
            this.FName.TabIndex = 7;
            this.FName.Text = "Имя";
            // 
            // Sal
            // 
            this.Sal.AutoSize = true;
            this.Sal.Location = new System.Drawing.Point(237, 126);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(54, 13);
            this.Sal.TabIndex = 8;
            this.Sal.Text = "Оклад ($)";
            // 
            // Hir
            // 
            this.Hir.AutoSize = true;
            this.Hir.Location = new System.Drawing.Point(237, 168);
            this.Hir.Name = "Hir";
            this.Hir.Size = new System.Drawing.Size(38, 13);
            this.Hir.TabIndex = 9;
            this.Hir.Text = "Нанят";
            // 
            // Fir
            // 
            this.Fir.AutoSize = true;
            this.Fir.Location = new System.Drawing.Point(239, 201);
            this.Fir.Name = "Fir";
            this.Fir.Size = new System.Drawing.Size(45, 13);
            this.Fir.TabIndex = 10;
            this.Fir.Text = "Уволен";
            // 
            // Pos
            // 
            this.Pos.AutoSize = true;
            this.Pos.Location = new System.Drawing.Point(237, 89);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(65, 13);
            this.Pos.TabIndex = 11;
            this.Pos.Text = "Должность";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddEmployee.FlatAppearance.BorderSize = 0;
            this.AddEmployee.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEmployee.Location = new System.Drawing.Point(317, 339);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(186, 46);
            this.AddEmployee.TabIndex = 13;
            this.AddEmployee.Text = "Добавить";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // numericSalary
            // 
            this.numericSalary.DecimalPlaces = 2;
            this.numericSalary.Location = new System.Drawing.Point(24, 126);
            this.numericSalary.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(200, 20);
            this.numericSalary.TabIndex = 14;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(24, 90);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPosition.TabIndex = 15;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 413);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.Fir);
            this.Controls.Add(this.Hir);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.fired);
            this.Controls.Add(this.hired);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker hired;
        private System.Windows.Forms.DateTimePicker fired;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label Sal;
        private System.Windows.Forms.Label Hir;
        private System.Windows.Forms.Label Fir;
        private System.Windows.Forms.Label Pos;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}