using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable personTable = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
        }
        void Fill()
        {
            personTable.Rows.Clear();
            personTable = Person.ViewAll();
            personGrid.ItemsSource = personTable.DefaultView;
        }

        private void ButtonView_Click(object sender, RoutedEventArgs e)
        {
            Fill();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            Person.Update();
            Fill();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            WindowPerson windowPerson = new WindowPerson(person);
            if (windowPerson.ShowDialog() == false) return;
            MessageBox.Show(person.Find());
        }
    }
}
