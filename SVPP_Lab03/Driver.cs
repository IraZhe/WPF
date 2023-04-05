using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace NewLab02
{
    public enum GENDER { male, female, variant };
    public enum COLOREYES { brown, green, blue, gray };
    public class Driver : INotifyPropertyChanged, IDataErrorInfo
    {

        int number;
        char class1;
        double hgt;
        string name;
        string address;
        GENDER gender;
        COLOREYES eyes;
        DateTime dob;
        DateTime iss;
        DateTime exp;
        bool donor;
        string uriImage;

        public event PropertyChangedEventHandler PropertyChanged;

        public Driver()
        {
        }

        public int Number { get => number;
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }
        public double Hgt { get => hgt;
            set
            {
                hgt = value;
                OnPropertyChanged("Hgt");
            }
        }
        public string Name { get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public GENDER Gender { get => gender;
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public COLOREYES Eyes { get => eyes;
            set
            {
                eyes = value;
                OnPropertyChanged("Eyes");
            }
        }
        public DateTime Dob { get => dob;
            set
            {
                dob = value;
                OnPropertyChanged("Dob");
            }
        }
        public DateTime Iss { get => iss;
            set
            {
                iss = value;
                OnPropertyChanged("Iss");
            }
        }
        public DateTime Exp { get => exp;
            set
            {
                exp = value;
                OnPropertyChanged("Exp");
            }
        }
        public bool Donor { get => donor;
            set
            {
                donor = value;
                OnPropertyChanged("Donor");
            }
        }
        public char Class1 { get => class1;
            set
            {
                class1 = value;
                OnPropertyChanged("Class1");
            }
        }
        public string Address { get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string UriImage
        {
            get => uriImage;
            set
            {
                uriImage = value;
                OnPropertyChanged("UriImage");
            }
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch(columnName)
                {
                    case "Class1":
                        if (Class1 < 'A' || Class1 > 'E')
                            error = "Неверная категория";
                        break;
                    case "Exp":
                        if (Exp < DateTime.Now)
                            error = "Закончен срок действия";
                        break;
                }
                return error;
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public override string ToString()
        {
            return $"№{Number} {Class1} from {Iss} to {Exp}.\n" +
                $"{Name}, {Gender} Dob({Dob}). {Address}. Height {Hgt}. Eyes {Eyes}. {(Donor?"Donor":"Not donor")}\n" +
                $"{UriImage}";
        }
    }
    
}
