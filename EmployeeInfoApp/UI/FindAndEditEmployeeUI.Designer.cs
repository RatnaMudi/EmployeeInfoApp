namespace EmployeeInfoApp.UI
{
    partial class FindAndEditEmployeeUI
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultListView = new System.Windows.Forms.ListView();
            this.SerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchEmployee";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(292, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(94, 24);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.searchNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultListView);
            this.groupBox2.Location = new System.Drawing.Point(32, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SearchEmployee Result";
            // 
            // resultListView
            // 
            this.resultListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNo,
            this.Name,
            this.Email});
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(19, 20);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(348, 119);
            this.resultListView.TabIndex = 0;
            this.resultListView.Tag = "Edit";
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // SerialNo
            // 
            this.SerialNo.Text = "Serial No.";
            this.SerialNo.Width = 61;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 123;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 160;
            // 
            // FindAndEditEmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            //this.Name = "FindAndEditEmployeeUI";
            this.Text = "SearchEmployee/Modify Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader SerialNo;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Email;
    }
}