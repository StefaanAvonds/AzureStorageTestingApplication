using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AzureStorageTestingApplication.TableEntityModels
{
    public class CustomerEntity : TableEntity, INotifyPropertyChanged
    {
        private string _lastname;
        private string _firstname;
        private string _email;
        private string _phoneNumber;

        public String Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                PartitionKey = value;
                OnPropertyChanged();
            }
        }
        public String Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                RowKey = value;
                OnPropertyChanged();
            }
        }
        public String Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public CustomerEntity()
        {

        }

        public CustomerEntity(string lastname, string firstname)
            : this()
        {
            Lastname = lastname;
            Firstname = firstname;
        }

        public override string ToString()
        {
            return $"{Lastname} {Firstname} - {Email} - {PhoneNumber}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
