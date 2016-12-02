namespace AzureStorageTestingApplication.Forms
{
    partial class Homepage
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
            this.btnCustomerEntity = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBlobPage = new System.Windows.Forms.Button();
            this.btnReadBlob = new System.Windows.Forms.Button();
            this.btnShowImageBlob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerEntity
            // 
            this.btnCustomerEntity.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerEntity.Name = "btnCustomerEntity";
            this.btnCustomerEntity.Size = new System.Drawing.Size(254, 31);
            this.btnCustomerEntity.TabIndex = 0;
            this.btnCustomerEntity.Text = "Customers";
            this.btnCustomerEntity.UseVisualStyleBackColor = true;
            this.btnCustomerEntity.Click += new System.EventHandler(this.btnCustomerEntity_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(254, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBlobPage
            // 
            this.btnBlobPage.Location = new System.Drawing.Point(12, 49);
            this.btnBlobPage.Name = "btnBlobPage";
            this.btnBlobPage.Size = new System.Drawing.Size(254, 31);
            this.btnBlobPage.TabIndex = 1;
            this.btnBlobPage.Text = "Add blob";
            this.btnBlobPage.UseVisualStyleBackColor = true;
            this.btnBlobPage.Click += new System.EventHandler(this.btnBlobPage_Click);
            // 
            // btnReadBlob
            // 
            this.btnReadBlob.Location = new System.Drawing.Point(12, 86);
            this.btnReadBlob.Name = "btnReadBlob";
            this.btnReadBlob.Size = new System.Drawing.Size(254, 31);
            this.btnReadBlob.TabIndex = 2;
            this.btnReadBlob.Text = "Read blob";
            this.btnReadBlob.UseVisualStyleBackColor = true;
            this.btnReadBlob.Click += new System.EventHandler(this.btnReadBlob_Click);
            // 
            // btnShowImageBlob
            // 
            this.btnShowImageBlob.Location = new System.Drawing.Point(12, 123);
            this.btnShowImageBlob.Name = "btnShowImageBlob";
            this.btnShowImageBlob.Size = new System.Drawing.Size(254, 31);
            this.btnShowImageBlob.TabIndex = 3;
            this.btnShowImageBlob.Text = "Show image blob";
            this.btnShowImageBlob.UseVisualStyleBackColor = true;
            this.btnShowImageBlob.Click += new System.EventHandler(this.btnShowImageBlob_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 261);
            this.Controls.Add(this.btnShowImageBlob);
            this.Controls.Add(this.btnReadBlob);
            this.Controls.Add(this.btnBlobPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerEntity);
            this.MaximumSize = new System.Drawing.Size(296, 308);
            this.MinimumSize = new System.Drawing.Size(296, 308);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerEntity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBlobPage;
        private System.Windows.Forms.Button btnReadBlob;
        private System.Windows.Forms.Button btnShowImageBlob;
    }
}

