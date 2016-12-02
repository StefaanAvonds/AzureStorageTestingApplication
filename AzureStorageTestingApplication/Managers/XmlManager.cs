using AzureStorageTestingApplication.TableEntityModels;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AzureStorageTestingApplication.Managers
{
    public class XmlManager
    {
        private string _filename;
        private XDocument _xmlDocument;

        public string DefaultConnectionStringValue => "[ENTER CONNECTION STRING]";

        public XmlManager()
        {
            _filename = GetFullFilename("AzureStorageTestingConnectionString.xml");

            if (!File.Exists(_filename))
            {
                _xmlDocument = new XDocument();
                CreateBasicXmlFile();
            }
            else
            {
                _xmlDocument = XDocument.Load(_filename);
            }
        }

        /// <summary>
        /// Get the full filename with a specific path.
        /// </summary>
        /// <param name="filename">The name of the file.</param>
        /// <returns>The full path.</returns>
        private string GetFullFilename(string filename)
        {
            string localAppdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilepath = Path.Combine(localAppdata, "Avonds");

            if (!Directory.Exists(userFilepath)) Directory.CreateDirectory(userFilepath);

            return Path.Combine(userFilepath, filename);
        }

        /// <summary>
        /// Craete a basic XML-file.
        /// </summary>
        private void CreateBasicXmlFile()
        {
            ConnectionStringEntity connectionString = new ConnectionStringEntity(DefaultConnectionStringValue);
            
            XElement xml = new XElement("ConnectionStrings",
                GetConnectionStringElement(connectionString));
            
            _xmlDocument.Add(xml);
            _xmlDocument.Save(_filename);
        }

        /// <summary>
        /// Read the value of the connection string.
        /// </summary>
        /// <returns>The connection string.</returns>
        public string ReadConnectionString()
        {
            var connectionStrings = from xml in _xmlDocument.Descendants("ConnectionString")
                                    select new ConnectionStringEntity
                                    {
                                        Key = xml.Attribute("Key").Value,
                                        ConnectionString = xml.Attribute("Value").Value
                                    };

            if (!connectionStrings.Any()) return string.Empty;
            
            return connectionStrings.FirstOrDefault().ConnectionString;
        }

        /// <summary>
        /// Save the connection string to the XML-file.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public void SaveConnectionString(string connectionString)
        {
            _xmlDocument.Descendants("ConnectionStrings").Remove();

            XElement xml = new XElement("ConnectionStrings",
                GetConnectionStringElement(new ConnectionStringEntity(connectionString)));

            _xmlDocument.Add(xml);
            _xmlDocument.Save(_filename);
        }

        /// <summary>
        /// Get the XML-element for the connection string.
        /// </summary>
        /// <param name="connectionString">The connection string with its parameters.</param>
        /// <returns>The element for XML.</returns>
        private XElement GetConnectionStringElement(ConnectionStringEntity connectionString)
        {
            XElement connectionStringElement = new XElement("ConnectionString");
            connectionStringElement.SetAttributeValue("Key", connectionString.Key);
            connectionStringElement.SetAttributeValue("Value", connectionString.ConnectionString);

            return connectionStringElement;
        }

        /// <summary>
        /// Open the XML-file that contains the connection string.
        /// </summary>
        public void OpenConnectionStringFile()
        {
            Process.Start(_filename);
        }
    }
}
