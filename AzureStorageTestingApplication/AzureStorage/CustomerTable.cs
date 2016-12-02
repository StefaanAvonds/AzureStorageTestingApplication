using AzureStorageTestingApplication.TableEntityModels;
using Microsoft.WindowsAzure.Storage;

namespace AzureStorageTestingApplication.AzureStorage
{
    public class CustomerTable : BaseTable<CustomerEntity>
    {
        public CustomerTable(CloudStorageAccount storageAccount)
            : base(storageAccount, "Customer")
        {
            
        }
    }
}
