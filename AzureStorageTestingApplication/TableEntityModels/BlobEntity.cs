using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AzureStorageTestingApplication.TableEntityModels
{
    public class BlobEntity : INotifyPropertyChanged
    {
        private string _blobName;
        private string _text;

        public String BlobName
        {
            get { return _blobName; }
            set
            {
                _blobName = value;
                OnPropertyChanged();
            }
        }

        public String Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public BlobEntity()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
