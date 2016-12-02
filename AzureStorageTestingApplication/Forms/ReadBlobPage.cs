using AzureStorageTestingApplication.Interfaces;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;

namespace AzureStorageTestingApplication.Forms
{
    public partial class ReadBlobPage : BaseForm, IFileCreated
    {
        private List<CloudBlob> _listBlobs;
        private string _downloadedFile;

        public ReadBlobPage()
        {
            InitializeComponent();
            _downloadedFile = String.Empty;
        }

        private void ReadBlobPage_Load(object sender, EventArgs e)
        {
            ReloadBlobItems();
        }

        /// <summary>
        /// Reload all blob items in container.
        /// </summary>
        private async void ReloadBlobItems()
        {
            _listBlobs = new List<CloudBlob>();

            var list = await App.AzureStorage.BlobTable.GetAllBlobs();

            var dataSource = new List<String>();
            foreach (var item in list)
            {
                if (item is CloudBlob)
                {
                    _listBlobs.Add((CloudBlob)item);
                    string name = ((CloudBlob)item).Name;
                    dataSource.Add(name);
                }
            }

            cmbBlobs.DataSource = dataSource;

            btnDownload.Enabled = true;
        }

        public void FileCreated(string filepath)
        {
            _downloadedFile = filepath;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            _downloadedFile = String.Empty;

            var blob = _listBlobs[cmbBlobs.SelectedIndex];
            txtBlobName.Text = blob.Name;

            if (blob.Properties.ContentType.Equals(Constants.BlobTextContentType))
            {
                txtText.Text = await App.AzureStorage.BlobTable.DownloadTextContentFromBlob(blob, true, this);
            }
            else
            {
                txtText.Text = await App.AzureStorage.BlobTable.DownloadTextContentFromBlob(blob);

                if (blob.Properties.ContentType.Equals(Constants.BlobPngContentType))
                {
                    await App.AzureStorage.BlobTable.DownloadFileFromBlob(blob, this);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(_downloadedFile)) return;
            
            App.FileManager.OpenFileFromPath(_downloadedFile);
        }
    }
}
