using System;

namespace AzureStorageTestingApplication.Forms
{
    public partial class ConnectionStringPage : BaseForm
    {
        /// <summary>
        /// The connection string that was given by the user.
        /// </summary>
        public String ConnectionString => txtConnectionString.Text;

        public ConnectionStringPage()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
