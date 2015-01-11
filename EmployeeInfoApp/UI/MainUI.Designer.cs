namespace EmployeeInfoApp.UI
{
    partial class MainUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addDesignationButton = new System.Windows.Forms.Button();
            this.findAndEditButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findAndEditButton);
            this.groupBox1.Controls.Add(this.addDesignationButton);
            this.groupBox1.Controls.Add(this.addEmployeeButton);
            this.groupBox1.Location = new System.Drawing.Point(61, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(24, 44);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(112, 62);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addDesignationButton
            // 
            this.addDesignationButton.Location = new System.Drawing.Point(154, 44);
            this.addDesignationButton.Name = "addDesignationButton";
            this.addDesignationButton.Size = new System.Drawing.Size(112, 62);
            this.addDesignationButton.TabIndex = 1;
            this.addDesignationButton.Text = "Add Designation";
            this.addDesignationButton.UseVisualStyleBackColor = true;
            this.addDesignationButton.Click += new System.EventHandler(this.addDesignationButton_Click);
            // 
            // findAndEditButton
            // 
            this.findAndEditButton.Location = new System.Drawing.Point(283, 44);
            this.findAndEditButton.Name = "findAndEditButton";
            this.findAndEditButton.Size = new System.Drawing.Size(112, 62);
            this.findAndEditButton.TabIndex = 2;
            this.findAndEditButton.Text = "FindEmail and Edit";
            this.findAndEditButton.UseVisualStyleBackColor = true;
            this.findAndEditButton.Click += new System.EventHandler(this.findAndEditButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "Main Menu (Employee Information)";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findAndEditButton;
        private System.Windows.Forms.Button addDesignationButton;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}

