using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grouping
{
    public class Contacts : INotifyPropertyChanged
    {

        #region Fields

        private string contactName;
        private string contactNumber;
        private ImageSource image;
        private string displayString;
        private int age;

        #endregion

        #region Constructor

        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
            displayString = name[0].ToString();
        }

        public Contacts()
        {

        }

        #endregion

        #region Properties

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public string DisplayString
        {
            get { return displayString; }
            set
            {
                if (displayString != value)
                {
                    displayString = value;
                    this.RaisedOnPropertyChanged("DisplayString");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                this.RaisedOnPropertyChanged("Age");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
