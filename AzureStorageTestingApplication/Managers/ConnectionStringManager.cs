using AzureStorageTestingApplication.Forms;
using System;
using System.Windows.Forms;

namespace AzureStorageTestingApplication.Managers
{
    public class ConnectionStringManager
    {
        private XmlManager _xmlManager;

        public ConnectionStringManager()
        {
            _xmlManager = new XmlManager();
        }

        /// <summary>
        /// Get the connection string for the current application.
        /// </summary>
        /// <returns>The connection string.</returns>
        public string GetConnectionString()
        {
            string connectionString = _xmlManager.ReadConnectionString();
            if (!connectionString.Equals(_xmlManager.DefaultConnectionStringValue))
            {
                // If the connection string seems valid, just return it
                return connectionString;
            }

            // If it is the same as the default value (which means no real connection string)
            // the user has to enter one
            return EnterNewConnectionString();
        }

        /// <summary>
        /// A new page will open for the user to enter the right connection string.
        /// </summary>
        /// <returns>The connection string.</returns>
        public string EnterNewConnectionString()
        {
            var page = new ConnectionStringPage();
            do
            {
                MessageBox.Show("Please enter a valid Connection String before using this application!");

                page.ShowDialog();
            }
            while (String.IsNullOrWhiteSpace(page.ConnectionString));

            _xmlManager.SaveConnectionString(page.ConnectionString);

            return page.ConnectionString;
        }
    }
}
