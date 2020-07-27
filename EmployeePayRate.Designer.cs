namespace EhlertProgram10
{
    partial class EmployeePayRate
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
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeePayRate = new System.Windows.Forms.TextBox();
            this.txtEmployeeHoursWorked = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeePayRate = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblEmployeeHoursWorked = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(107, 34);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(107, 60);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 1;
            // 
            // txtEmployeePayRate
            // 
            this.txtEmployeePayRate.Location = new System.Drawing.Point(107, 86);
            this.txtEmployeePayRate.Name = "txtEmployeePayRate";
            this.txtEmployeePayRate.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePayRate.TabIndex = 2;
            // 
            // txtEmployeeHoursWorked
            // 
            this.txtEmployeeHoursWorked.Location = new System.Drawing.Point(107, 112);
            this.txtEmployeeHoursWorked.Name = "txtEmployeeHoursWorked";
            this.txtEmployeeHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeHoursWorked.TabIndex = 3;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 34);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblEmployeePayRate
            // 
            this.lblEmployeePayRate.AutoSize = true;
            this.lblEmployeePayRate.Location = new System.Drawing.Point(4, 89);
            this.lblEmployeePayRate.Name = "lblEmployeePayRate";
            this.lblEmployeePayRate.Size = new System.Drawing.Size(99, 13);
            this.lblEmployeePayRate.TabIndex = 5;
            this.lblEmployeePayRate.Text = "Pay Rate (per hour)";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(4, 63);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(44, 13);
            this.lblEmployeeNumber.TabIndex = 6;
            this.lblEmployeeNumber.Text = "Number";
            // 
            // lblEmployeeHoursWorked
            // 
            this.lblEmployeeHoursWorked.AutoSize = true;
            this.lblEmployeeHoursWorked.Location = new System.Drawing.Point(4, 115);
            this.lblEmployeeHoursWorked.Name = "lblEmployeeHoursWorked";
            this.lblEmployeeHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblEmployeeHoursWorked.TabIndex = 7;
            this.lblEmployeeHoursWorked.Text = "Hours Worked";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(7, 162);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(265, 87);
            this.txtDisplay.TabIndex = 9;
            // 
            // EmployeePayRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblEmployeeHoursWorked);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.lblEmployeePayRate);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtEmployeeHoursWorked);
            this.Controls.Add(this.txtEmployeePayRate);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeePayRate";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtEmployeePayRate;
        private System.Windows.Forms.TextBox txtEmployeeHoursWorked;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeePayRate;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeHoursWorked;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

