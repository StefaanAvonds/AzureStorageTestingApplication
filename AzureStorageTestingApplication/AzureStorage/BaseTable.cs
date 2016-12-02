using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Collections.ObjectModel;
using System.Linq;

namespace AzureStorageTestingApplication.AzureStorage
{
    public class BaseTable<TModel>
        where TModel : TableEntity, new()
    {
        private CloudStorageAccount _storageAccount;
        private CloudTableClient _tableClient;
        private CloudTable _table;
        
        public BaseTable(CloudStorageAccount storageAccount, string tablename)
        {
            _storageAccount = storageAccount;

            _tableClient = _storageAccount.CreateCloudTableClient();

            _table = _tableClient.GetTableReference(tablename);
            _table.CreateIfNotExists();
        }

        /// <summary>
        /// Select all entities from table.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<TModel> SelectAll()
        {
            TableQuery<TModel> query = new TableQuery<TModel>();
            return new ObservableCollection<TModel>(_table.ExecuteQuery(query).ToList());
        }

        /// <summary>
        /// Add a new entity to the table.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        /// <returns></returns>
        public bool AddNewEntity(TModel entity)
        {
            TableOperation insertOperation = TableOperation.Insert(entity);
            _table.Execute(insertOperation);

            return true;
        }
    }
}
