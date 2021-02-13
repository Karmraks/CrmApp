
namespace Test
{
    partial class PositionForm
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
            this.position = new System.Windows.Forms.TextBox();
            this.Pos = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(23, 28);
            this.position.Multiline = true;
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(200, 24);
            this.position.TabIndex = 3;
            // 
            // Pos
            // 
            this.Pos.AutoSize = true;
            this.Pos.Location = new System.Drawing.Point(229, 31);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(65, 13);
            this.Pos.TabIndex = 12;
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
            this.AddEmployee.Location = new System.Drawing.Point(220, 187);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(186, 46);
            this.AddEmployee.TabIndex = 14;
            this.AddEmployee.Text = "Добавить";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // PositionFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 245);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.position);
            this.Name = "PositionFom";
            this.Text = "PositionFom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label Pos;
        private System.Windows.Forms.Button AddEmployee;
    }
}