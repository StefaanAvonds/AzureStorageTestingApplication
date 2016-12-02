namespace AzureStorageTestingApplication.Forms
{
    partial class CustomerPage
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
            this.lstAllCustomers = new System.Windows.Forms.ListView();
            this.groupAllCustomers = new System.Windows.Forms.GroupBox();
            this.groupNewCustomer = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.groupAllCustomers.SuspendLayout();
            this.groupNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllCustomers
            // 
            this.lstAllCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAllCustomers.Location = new System.Drawing.Point(3, 18);
            this.lstAllCustomers.Name = "lstAllCustomers";
            this.lstAllCustomers.Size = new System.Drawing.Size(400, 267);
            this.lstAllCustomers.TabIndex = 0;
            this.lstAllCustomers.UseCompatibleStateImageBehavior = false;
            this.lstAllCustomers.View = System.Windows.Forms.View.List;
            // 
            // groupAllCustomers
            // 
            this.groupAllCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAllCustomers.Controls.Add(this.lstAllCustomers);
            this.groupAllCustomers.Location = new System.Drawing.Point(12, 200);
            this.groupAllCustomers.Name = "groupAllCustomers";
            this.groupAllCustomers.Size = new System.Drawing.Size(406, 288);
            this.groupAllCustomers.TabIndex = 1;
            this.groupAllCustomers.TabStop = false;
            this.groupAllCustomers.Text = "All customers";
            // 
            // groupNewCustomer
            // 
            this.groupNewCustomer.Controls.Add(this.btnAdd);
            this.groupNewCustomer.Controls.Add(this.txtPhoneNumber);
            this.groupNewCustomer.Controls.Add(this.lblPhoneNumber);
            this.groupNewCustomer.Controls.Add(this.txtEmail);
            this.groupNewCustomer.Controls.Add(this.lblEmail);
            this.groupNewCustomer.Controls.Add(this.txtFirstname);
            this.groupNewCustomer.Controls.Add(this.txtLastname);
            this.groupNewCustomer.Controls.Add(this.lblFirstname);
            this.groupNewCustomer.Controls.Add(this.lblLastname);
            this.groupNewCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupNewCustomer.Name = "groupNewCustomer";
            this.groupNewCustomer.Size = new System.Drawing.Size(406, 182);
            this.groupNewCustomer.TabIndex = 0;
            this.groupNewCustomer.TabStop = false;
            this.groupNewCustomer.Text = "New customer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(290, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(117, 105);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(283, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 108);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(105, 17);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(117, 49);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(283, 22);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(117, 21);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(283, 22);
            this.txtLastname.TabIndex = 0;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(6, 52);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(74, 17);
            this.lblFirstname.TabIndex = 6;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(6, 24);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(74, 17);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Lastname:";
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 500);
            this.Controls.Add(this.groupNewCustomer);
            this.Controls.Add(this.groupAllCustomers);
            this.MinimumSize = new System.Drawing.Size(448, 547);
            this.Name = "CustomerPage";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.groupAllCustomers.ResumeLayout(false);
            this.groupNewCustomer.ResumeLayout(false);
            this.groupNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstAllCustomers;
        private System.Windows.Forms.GroupBox groupAllCustomers;
        private System.Windows.Forms.GroupBox groupNewCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
    }
}