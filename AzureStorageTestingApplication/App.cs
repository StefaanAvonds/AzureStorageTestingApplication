using AzureStorageTestingApplication.Managers;

namespace AzureStorageTestingApplication
{
    public static class App
    {
        private static AzureStorageManager _azureStorageManager;
        private static FileManager _fileManager;
        private static ConnectionStringManager _connectionStringManager;

        /// <summary>
        /// The manager to contact the Azure Storage.
        /// </summary>
        public static AzureStorageManager AzureStorage
        {
            get
            {
                if (_azureStorageManager == null) _azureStorageManager = new AzureStorageManager();
                return _azureStorageManager;
            }
        }

        /// <summary>
        /// The manager for handeling files.
        /// </summary>
        public static FileManager FileManager
        {
            get
            {
                if (_fileManager == null) _fileManager = new FileManager();
                return _fileManager;
            }
        }

        /// <summary>
        /// The manager for the connection string.
        /// </summary>
        public static ConnectionStringManager ConnectionStringManager
        {
            get
            {
                if (_connectionStringManager == null) _connectionStringManager = new ConnectionStringManager();
                return _connectionStringManager;
            }
        }
    }
}
