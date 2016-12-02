namespace AzureStorageTestingApplication.Forms
{
    partial class BlobPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlobPage));
            this.lblBlobName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(12, 15);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(79, 17);
            this.lblBlobName.TabIndex = 3;
            this.lblBlobName.Text = "Blob name:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 43);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text:";
            // 
            // txtBlobName
            // 
            this.txtBlobName.Location = new System.Drawing.Point(97, 12);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(243, 22);
            this.txtBlobName.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(97, 40);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(243, 162);
            this.txtText.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BlobPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 256);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtBlobName);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblBlobName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(370, 262);
            this.Name = "BlobPage";
            this.Text = "Blobs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBlobName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnAdd;
    }
}