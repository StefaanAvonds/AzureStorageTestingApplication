namespace AzureStorageTestingApplication.Forms
{
    partial class ImageBlobPage
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
            this.groupDownload = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.cmbBlobs = new System.Windows.Forms.ComboBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.groupDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDownload
            // 
            this.groupDownload.Controls.Add(this.btnDownload);
            this.groupDownload.Controls.Add(this.cmbBlobs);
            this.groupDownload.Location = new System.Drawing.Point(12, 12);
            this.groupDownload.Name = "groupDownload";
            this.groupDownload.Size = new System.Drawing.Size(395, 62);
            this.groupDownload.TabIndex = 0;
            this.groupDownload.TabStop = false;
            this.groupDownload.Text = "Download Blob";
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(282, 18);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 29);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cmbBlobs
            // 
            this.cmbBlobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlobs.FormattingEnabled = true;
            this.cmbBlobs.Location = new System.Drawing.Point(6, 21);
            this.cmbBlobs.Name = "cmbBlobs";
            this.cmbBlobs.Size = new System.Drawing.Size(270, 24);
            this.cmbBlobs.TabIndex = 0;
            // 
            // picResult
            // 
            this.picResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picResult.Location = new System.Drawing.Point(12, 80);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(395, 262);
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // ImageBlobPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 354);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.groupDownload);
            this.Name = "ImageBlobPage";
            this.Text = "Images";
            this.Load += new System.EventHandler(this.ImageBlobPage_Load);
            this.groupDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cmbBlobs;
        private System.Windows.Forms.PictureBox picResult;
    }
}