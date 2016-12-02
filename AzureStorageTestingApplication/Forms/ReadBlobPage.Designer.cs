namespace AzureStorageTestingApplication.Forms
{
    partial class ReadBlobPage
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.cmbBlobs = new System.Windows.Forms.ComboBox();
            this.groupDownload = new System.Windows.Forms.GroupBox();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblBlobName = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupDownload.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
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
            // groupResult
            // 
            this.groupResult.Controls.Add(this.btnOpenFile);
            this.groupResult.Controls.Add(this.txtText);
            this.groupResult.Controls.Add(this.txtBlobName);
            this.groupResult.Controls.Add(this.lblText);
            this.groupResult.Controls.Add(this.lblBlobName);
            this.groupResult.Location = new System.Drawing.Point(12, 80);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(395, 262);
            this.groupResult.TabIndex = 1;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(92, 49);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(243, 162);
            this.txtText.TabIndex = 1;
            // 
            // txtBlobName
            // 
            this.txtBlobName.Enabled = false;
            this.txtBlobName.Location = new System.Drawing.Point(92, 21);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(243, 22);
            this.txtBlobName.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(7, 52);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text:";
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(7, 24);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(79, 17);
            this.lblBlobName.TabIndex = 3;
            this.lblBlobName.Text = "Blob name:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(92, 217);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(243, 29);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open Blob";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ReadBlobPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 354);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupDownload);
            this.Name = "ReadBlobPage";
            this.Text = "Read Blob";
            this.Load += new System.EventHandler(this.ReadBlobPage_Load);
            this.groupDownload.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cmbBlobs;
        private System.Windows.Forms.GroupBox groupDownload;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBlobName;
        private System.Windows.Forms.Button btnOpenFile;
    }
}