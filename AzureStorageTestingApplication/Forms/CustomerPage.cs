using AzureStorageTestingApplication.TableEntityModels;
using System;
using System.Windows.Forms;

namespace AzureStorageTestingApplication.Forms
{
    public partial class CustomerPage : BaseForm
    {
        private CustomerEntity _newCustomer;

        public CustomerPage()
        {
            InitializeComponent();

            _newCustomer = new CustomerEntity();

            InitializeDataBinding();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            ReloadCustomers();
        }

        /// <summary>
        /// Initialize the data binding on the page.
        /// </summary>
        private void InitializeDataBinding()
        {
            txtFirstname.DataBindings.Add("Text", _newCustomer, "Firstname", false, DataSourceUpdateMode.OnPropertyChanged);
            txtLastname.DataBindings.Add("Text", _newCustomer, "Lastname", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _newCustomer, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPhoneNumber.DataBindings.Add("Text", _newCustomer, "PhoneNumber", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Loads all customers from Azure Storage.
        /// </summary>
        private void ReloadCustomers()
        {
            lstAllCustomers.Items.Clear();

            var allCustomers = App.AzureStorage.CustomerTable.SelectAll();
            
            foreach (var customer in allCustomers)
            {
                lstAllCustomers.Items.Add(customer.ToString());
            }
        }

        /// <summary>
        /// Check if the customer has it's properties initialized right.
        /// </summary>
        /// <returns></returns>
        private bool IsNewCustomerValid()
        {
            if (String.IsNullOrWhiteSpace(_newCustomer.Firstname)) return false;
            if (String.IsNullOrWhiteSpace(_newCustomer.Lastname)) return false;
            if (String.IsNullOrWhiteSpace(_newCustomer.Email)) return false;
            if (String.IsNullOrWhiteSpace(_newCustomer.PhoneNumber)) return false;

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsNewCustomerValid())
            {
                MessageBox.Show("Not all properties are initialized right!");
                return;
            }

            bool result = App.AzureStorage.CustomerTable.AddNewEntity(_newCustomer);
            if (result)
            {
                MessageBox.Show("Customer added!");
                ReloadCustomers();
            }
        }
    }
}
