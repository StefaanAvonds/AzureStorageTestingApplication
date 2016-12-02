using AzureStorageTestingApplication.Interfaces;
using AzureStorageTestingApplication.TableEntityModels;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageTestingApplication.AzureStorage
{
    public class BlobTable
    {
        private string _containerName;

        private CloudStorageAccount _storageAccount;
        private CloudBlobClient _blobClient;
        private CloudBlobContainer _blobContainer;
        
        public BlobTable(CloudStorageAccount storageAccount, string containerName)
        {
            _storageAccount = storageAccount;

            _blobClient = _storageAccount.CreateCloudBlobClient();

            _containerName = containerName.ToLower();
        }

        /// <summary>
        /// Create the blob container if it doesn't exist.
        /// </summary>
        /// <returns></returns>
        private async Task CreateIfNotExists()
        {
            _blobContainer = _blobClient.GetContainerReference(_containerName);
            await _blobContainer.CreateIfNotExistsAsync();
        }

        /// <summary>
        /// Get all Blob available.
        /// </summary>
        /// <returns></returns>
        public async Task<List<IListBlobItem>> GetAllBlobs()
        {
            await CreateIfNotExists();
            
            return _blobContainer.ListBlobs().ToList();
        }

        /// <summary>
        /// Add a new blob entity.
        /// </summary>
        /// <param name="blob">Blob to add.</param>
        /// <returns></returns>
        public async Task<bool> AddBlobEntity(BlobEntity blob)
        {
            await CreateIfNotExists();

            CloudBlockBlob blockBlob = _blobContainer.GetBlockBlobReference(blob.BlobName);

            await blockBlob.UploadTextAsync(blob.Text);

            return true;
        }

        /// <summary>
        /// Return the block for a specific blob.
        /// </summary>
        /// <param name="blob"></param>
        /// <returns></returns>
        private async Task<CloudBlockBlob> GetBlockBlob(CloudBlob blob)
        {
            await CreateIfNotExists();
            return _blobContainer.GetBlockBlobReference(blob.Name);
        }

        /// <summary>
        /// Download the blob and return the string value.
        /// If the Content Type isn't that of text, an empty string will be returned.
        /// </summary>
        /// <param name="blob"></param>
        /// <param name="saveToTempFile">Set this to TRUE if you want the contents of the text to be saved in a temp-file.</param>
        /// <param name="fileCreatedReceiver">Object that will receive a notification once the file is created. This is only active is "saveToTempFile" is set to TRUE.</param>
        /// <returns></returns>
        public async Task<String> DownloadTextContentFromBlob(CloudBlob blob, bool saveToTempFile = false, IFileCreated fileCreatedReceiver = null)
        {
            if (!blob.Properties.ContentType.Equals(Constants.BlobTextContentType)) return String.Empty;

            CloudBlockBlob blockBlob = await GetBlockBlob(blob);
            
            string text = String.Empty;
            using (var memoryStream = new MemoryStream())
            {
                await blockBlob.DownloadToStreamAsync(memoryStream);
                text = Encoding.UTF8.GetString(memoryStream.ToArray());
            }

            if (saveToTempFile)
            {
                App.FileManager.CreateTempFile();

                using (var file = new StreamWriter(App.FileManager.TempTxtFile))
                {
                    await file.WriteLineAsync(text);
                }

                fileCreatedReceiver?.FileCreated(App.FileManager.TempTxtFile);
            }

            return text;
        }

        /// <summary>
        /// Download the file to a local file.
        /// </summary>
        /// <param name="blob"></param>
        /// <param name="fileCreatedReceiver">Object that will receive a notification once the file is created.</param>
        public async Task DownloadFileFromBlob(CloudBlob blob, IFileCreated fileCreatedReceiver = null)
        {
            CloudBlockBlob blockBlob = await GetBlockBlob(blob);

            string filename = App.FileManager.CreateNewFilenameForDownloads(blob.Name);
            using (var fileStream = File.OpenWrite(filename))
            {
                await blockBlob.DownloadToStreamAsync(fileStream);
            }

            fileCreatedReceiver?.FileCreated(filename);
        }
    }
}
