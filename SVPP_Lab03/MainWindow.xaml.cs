using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace NewLab02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Driver driver = new Driver();
        public MainWindow()
        {
            InitializeComponent();
            //foreach (COLOREYES color in Enum.GetValues(typeof(COLOREYES)))
            //{
            //    comboBoxEyes.Items.Add(color.ToString());
            //}
            newdriver();
            grid.DataContext = driver;

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            //int a;
            //Int32.TryParse(textBoxNumber.Text,out a);
            //driver.Number = a;
            //if (textBoxClass.Text.Length > 0)
            //    driver.Class1 = textBoxClass.Text[0];
            //else
            //    driver.Class1 = 'A';
            //driver.Address = textBoxAddress.Text;
            //if (dataPickerDOB.SelectedDate == null)
            //    driver.Dob = DateTime.Now;
            // else
            //    driver.Dob = (DateTime)(dataPickerDOB.SelectedDate);

            //driver.Gender = Driver.GENDER.variant;
            //if (radioButtonMale.IsChecked == true)
            //    driver.Gender = Driver.GENDER.male;
            //if (radioButtonFemale.IsChecked == true)
            //    driver.Gender = Driver.GENDER.female;
            //if(comboBoxEyes.SelectedIndex > -1)
            //    driver.Eyes = (Driver.COLOREYES)comboBoxEyes.SelectedIndex;
            //driver.Hgt = sliderHGT.Value;
            MessageBox.Show(driver.ToString());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы (jpg)|*.jpg|Все файлы|*.*";
                
            if (dialog.ShowDialog() == true)
            {
                driver.UriImage = dialog.FileName;
                image.Source = new BitmapImage(new Uri(driver.UriImage, UriKind.RelativeOrAbsolute));
            }
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
 
            driver.Name = "Морфеус";
            driver.Address = "Зион";
            driver.Number = 777;
            driver.Donor = false;
            driver.Class1 = 'D';
            driver.Hgt = 250;
            driver.Iss = new DateTime(2018, 5, 11);
            driver.Gender = GENDER.variant;
            driver.Eyes = COLOREYES.brown;
            driver.UriImage = "Images/Морфеус.jpg";

        }

        private void newdriver()
        {

            driver.Name = "Severus Snape";
            driver.Class1 = 'A';
            driver.Address = "Hogwarts";
            driver.Number = 0123456789;
            driver.Hgt = 192;
            driver.Gender = GENDER.male;
            driver.Eyes = COLOREYES.gray;
            driver.Dob = new DateTime(1968, 5, 1);
            driver.Iss = new DateTime(2008, 10, 22);
            driver.Exp = new DateTime(2038, 10, 22);
            driver.Donor = true;
            driver.UriImage = "Images/Северус Снегг.jpg";
            
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
