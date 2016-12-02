namespace AzureStorageTestingApplication.TableEntityModels
{
    public class ConnectionStringEntity
    {
        public string Key { get; set; }
        public string ConnectionString { get; set; }

        public ConnectionStringEntity()
        {
            Key = "ConnectionString";
        }

        public ConnectionStringEntity(string connectionString)
            : this()
        {
            ConnectionString = connectionString;
        }
    }
}
