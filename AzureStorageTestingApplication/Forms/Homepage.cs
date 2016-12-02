using System;
using System.Windows.Forms;

namespace AzureStorageTestingApplication.Forms
{
    public partial class Homepage : BaseForm
    {
        public Homepage()
        {
            InitializeComponent();

            this.ControlBox = false;
        }
        
        private void btnCustomerEntity_Click(object sender, EventArgs e)
        {
            var customerPage = new CustomerPage();
            customerPage.Show();
        }

        private void btnBlobPage_Click(object sender, EventArgs e)
        {
            var blobPage = new BlobPage();
            blobPage.Show();
        }

        private void btnReadBlob_Click(object sender, EventArgs e)
        {
            var readBlobPage = new ReadBlobPage();
            readBlobPage.Show();
        }

        private void btnShowImageBlob_Click(object sender, EventArgs e)
        {
            var imageBlobPage = new ImageBlobPage();
            imageBlobPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.FileManager.DeleteAllDownloads();
        }
    }
}
