using AzureStorageTestingApplication.TableEntityModels;
using System;
using System.Windows.Forms;

namespace AzureStorageTestingApplication.Forms
{
    public partial class BlobPage : BaseForm
    {
        private BlobEntity _newBlob;

        public BlobPage()
        {
            InitializeComponent();

            _newBlob = new BlobEntity();

            InitializeDataBinding();
        }

        /// <summary>
        /// Initialize the data binding on the page.
        /// </summary>
        private void InitializeDataBinding()
        {
            txtBlobName.DataBindings.Add("Text", _newBlob, "BlobName", false, DataSourceUpdateMode.OnPropertyChanged);
            txtText.DataBindings.Add("Text", _newBlob, "Text", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Check if the blob has it's properties initialized right.
        /// </summary>
        /// <returns></returns>
        private bool IsNewBlobValid()
        {
            if (String.IsNullOrWhiteSpace(_newBlob.BlobName)) return false;
            if (String.IsNullOrWhiteSpace(_newBlob.Text)) return false;

            return true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsNewBlobValid())
            {
                MessageBox.Show("Not all properties are initialized right!");
                return;
            }

            bool result = await App.AzureStorage.BlobTable.AddBlobEntity(_newBlob);
            if (result)
            {
                MessageBox.Show("Blob added!");
            }
        }
    }
}
