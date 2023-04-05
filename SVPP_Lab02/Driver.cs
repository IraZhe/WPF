using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace NewLab02
{
    public class Driver
    {
        public enum GENDER { male, female, variant};
        public enum COLOREYES { brown, green, blue, gray};
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

        public Driver()
        {
        }
      
        public int Number { get => number; set => number = value; }
        public double Hgt { get => hgt; set => hgt = value; }
        public string Name { get => name; set => name = value; }
        public GENDER Gender { get => gender; set => gender = value; }
        public COLOREYES Eyes { get => eyes; set => eyes = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public DateTime Iss { get => iss; set => iss = value; }
        public DateTime Exp { get => exp; set => exp = value; }
        public bool Donor { get => donor; set => donor = value; }
        public char Class1 { get => class1; set => class1 = value; }
        public string Address { get => address; set => address = value; }
        public string UriImage { get => uriImage; set => uriImage = value; }

        public override string ToString()
        {
            return $"№{Number} {Class1} from {Iss} to {Exp}. {Name}, {Gender} Dob({Dob}). {Address}. Height {Hgt}. Eyes {Eyes}. " +
                $"{(Donor?"Donor":"Not donor")}";
        }
    }
    //public class ImageConverter : IValueConverter
    //{
    //    public object Convert(
    //        object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        return new BitmapImage(new Uri(value.ToString()));
    //    }

    //    public object ConvertBack(
    //        object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotSupportedException();
    //    }
    //}
}
