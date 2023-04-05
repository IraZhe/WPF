using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Hippodrome
{
    /// <summary>
    /// Логика взаимодействия для UserControlHorse.xaml
    /// </summary>
    public partial class UserControlHorse : UserControl
    {
        Horse horse;

        public UserControlHorse(int speed)
        {
            InitializeComponent();
            horse = new Horse(speed);

            textBlockSpeed.DataContext = horse;
            Binding bindingSpeed = new Binding("Speed");
            bindingSpeed.Converter = new SpeedToString();
            textBlockSpeed.SetBinding(TextBlock.TextProperty, bindingSpeed);


            textBlockPosition.DataContext = horse;
            Binding bindingPosition = new Binding("Position");
            bindingPosition.Converter = new PositionToString();
            textBlockPosition.SetBinding(TextBlock.TextProperty, bindingPosition);

            this.DataContext = horse;
            this.SetBinding(Canvas.LeftProperty, new Binding("X"));
        }
        public void UpdateSpeed(int speed)
        {
            horse.Speed = speed;
        }
        public int GetSpeed()
        {
            return horse.Speed;
        }
        public void UpdatePosition(int position)
        {
            horse.Position = position;
        }
        public float XHorse
        {
            get
            {
                return horse.X;
            }
            set
            {
                horse.X = value;
            }
        }
        public bool IsFinish
        {
            get
            {
                return horse.IsFinish;
            }
            set
            {
                horse.IsFinish = value;
            }
        }
        private void Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if (textBlockSpeed.Visibility == Visibility.Visible)
                textBlockSpeed.Visibility = Visibility.Hidden;
            else
                textBlockSpeed.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            if (textBlockPosition.Visibility == Visibility.Visible)
                textBlockPosition.Visibility = Visibility.Hidden;
            else
                textBlockPosition.Visibility = Visibility.Visible;


        }
    }
    public class PositionToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"position {value}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
    public class SpeedToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"{value} км/ч";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
