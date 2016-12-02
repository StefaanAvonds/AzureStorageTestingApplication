using AzureStorageTestingApplication.Interfaces;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace AzureStorageTestingApplication.Forms
{
    public partial class ImageBlobPage : BaseForm, IFileCreated
    {
        private List<CloudBlob> _listImageBlobs;

        public ImageBlobPage()
        {
            InitializeComponent();
        }

        private void ImageBlobPage_Load(object sender, EventArgs e)
        {
            ReloadImageBlobItems();
        }

        /// <summary>
        /// Reload all image blob items in container.
        /// </summary>
        private async void ReloadImageBlobItems()
        {
            _listImageBlobs = new List<CloudBlob>();

            var list = await App.AzureStorage.BlobTable.GetAllBlobs();

            var dataSource = new List<String>();
            foreach (var item in list)
            {
                if (item is CloudBlob)
                {
                    if (!((CloudBlob)item).Properties.ContentType.StartsWith("image")) continue;

                    _listImageBlobs.Add((CloudBlob)item);
                    string name = ((CloudBlob)item).Name;
                    dataSource.Add(name);
                }
            }

            cmbBlobs.DataSource = dataSource;

            btnDownload.Enabled = true;
        }

        private async void DownloadImageFile(CloudBlob blob)
        {
            if (App.FileManager.FileExists(blob.Name))
            {
                FileCreated(App.FileManager.DownloadsPath + blob.Name);
                return;
            }

            await App.AzureStorage.BlobTable.DownloadFileFromBlob(blob, this);
        }

        public void FileCreated(string filepath)
        {
            Image img = Image.FromFile(filepath);
            picResult.Image = img;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var blob = _listImageBlobs[cmbBlobs.SelectedIndex];

            DownloadImageFile(blob);
        }
    }
}
