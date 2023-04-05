using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new EntityContext();
            context.Students.Load();
            dGrid.ItemsSource = context.Students.Local.ToBindingList();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            WindowEdit edit = new WindowEdit(student);
            if (edit.ShowDialog() == false) return;
            context.Students.Add(student);
            context.SaveChanges();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dGrid.SelectedItems.Count == 0) return;
            if (MessageBox.Show("Вы уверены?", "Удалить запись", MessageBoxButton.YesNo) == MessageBoxResult.No)
                return;
            for (int i = dGrid.SelectedItems.Count-1; i >= 0; i--)
            {
                context.Students.Remove(dGrid.SelectedItems[i] as Student);
            }
            context.SaveChanges();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
            if (dGrid.SelectedItems.Count == 0) return;
            Student student = dGrid.SelectedItem as Student;
            WindowEdit edit = new WindowEdit(student);
            if (edit.ShowDialog() == false) return;
            context.SaveChanges();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }

        private void dGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
    }
}
