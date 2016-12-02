using AzureStorageTestingApplication.AzureStorage;
using Microsoft.WindowsAzure.Storage;

namespace AzureStorageTestingApplication.Managers
{
    public class AzureStorageManager
    {
        private CloudStorageAccount _storageAccount;
        private CustomerTable _customerTable;
        private BlobTable _blobTable;

        /// <summary>
        /// The table with all the customers.
        /// </summary>
        public CustomerTable CustomerTable
        {
            get
            {
                if (_customerTable == null) _customerTable = new CustomerTable(_storageAccount);
                return _customerTable;
            }
        }

        /// <summary>
        /// The table with all the blob-data.
        /// </summary>
        public BlobTable BlobTable
        {
            get
            {
                if (_blobTable == null) _blobTable = new BlobTable(_storageAccount, "TestBlob");
                return _blobTable;
            }
        }

        public AzureStorageManager()
        {
            string connectionString = App.ConnectionStringManager.GetConnectionString();
            bool success = false;

            do
            {
                try
                {
                    _storageAccount = CloudStorageAccount.Parse(connectionString);
                    success = true;
                }
                catch
                {
                    // Something went wrong
                    // Maybe the connection string is wrong
                    // Maybe no Internet Connection is available
                    // For safety reasons, we ask the user to enter a valid connection string
                    connectionString = App.ConnectionStringManager.EnterNewConnectionString();
                }
            }
            while (success == false);
        }
    }
}
