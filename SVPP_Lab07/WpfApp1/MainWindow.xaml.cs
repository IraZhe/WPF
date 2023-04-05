using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            person = new Person();
            stackpanelPerson.DataContext = person;
            listBox.DataContext = persons;
        }
        private void FillData()
        {
            persons.Clear();
            foreach(Person p in Person.GetAllPerson())
            {
                persons.Add(p);
            }

        }

        private void ButtonView_Click(object sender, RoutedEventArgs e)
        {
            FillData();
        }

        private void ButtonInsert_Click(object sender, RoutedEventArgs e)
        {
            person.Insert();
            FillData();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            Person person1 = Person.Find(textBoxName.Text);
            if (person1 == null)
                MessageBox.Show("Запись не найдена!");
            else
                MessageBox.Show(person1.ToString());
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
                return;
            person.Id = ((Person)listBox.SelectedItem).Id;
            if (textBoxName.Text.Length > 0)
                person.Name = textBoxName.Text;
            else
                person.Name = ((Person)listBox.SelectedItem).Name;
            decimal d = Convert.ToDecimal(textBoxSum.Text);
            if (d != 0)
                person.Sum = d;
            else
                person.Sum = ((Person)listBox.SelectedItem).Sum;
            person.Update();
            FillData();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
                return;
            Person.Delete(((Person)listBox.SelectedItem).Id);
            FillData();
        }
    }
}
