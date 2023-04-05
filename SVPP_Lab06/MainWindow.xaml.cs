using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Lab006
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Integral integral;
        BackgroundWorker worker;
        public MainWindow()
        {
            InitializeComponent();
            worker = (BackgroundWorker)this.Resources["worker"];
        }

        private void buttonParams_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            if (window1.ShowDialog() != true) return;
            integral = window1.integral;
            MessageBox.Show(integral.ToString());
        }

        private void ButtonD_Click(object sender, RoutedEventArgs e)
        {
            if (integral == null) return;
            Thread thread = new Thread(Calculate);
            thread.Start();
        }

        private void ButtonW_Click(object sender, RoutedEventArgs e)
        {
            buttonD.IsEnabled = false;
            buttonW.IsEnabled = false;
            worker.RunWorkerAsync();
        }

        private async void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            if (integral == null) return;
            IAsyncEnumerable<(double,double,double)> data = integral.GetDoublesAsync();
            await foreach(var trio in data)
            {
                listBox.Items.Add($"x = {trio.Item1:0.00} S={trio.Item2:0.00000}");
                pBar.Value = trio.Item3 * 100;
            }
        }
        private void Calculate()
        {
            if (integral == null) return;
            int n = integral.N;
            double h = (integral.B - integral.A) / n;
            var step = Math.Round((double)n / 100);
            double s = 0;
            for(int i = 0; i <= n; i++)
            {
                double x = integral.A + h * i;
                s += integral.f(x) * h;
                if(i % step == 0)
                {
                    Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                        new Action(() => pBar.Value = i / step));
                }
                Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                    new Action(() => listBox.Items.Add($"x = {x:0.00} S={s:0.00000}")));
                Thread.Sleep(100);
            }
            //MessageBox.Show($"S = {s:0.00000}");
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (integral == null) return;
            int n = integral.N;
            double h = (integral.B - integral.A) / n;
            var step = Math.Round((double)n / 100);
            double s = 0;
            for (int i = 0; i <= n; i++)
            {
                double x = integral.A + h * i;
                s += integral.f(x) * h;
                if (i % step == 0)
                {
                    if(worker != null && worker.WorkerReportsProgress)
                    {
                        worker.ReportProgress((int)(i / step));
                    }
                }
                Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                    new Action(() => listBox.Items.Add($"x = {x:0.00} S={s:0.00000}")));
                Thread.Sleep(100);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
           
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonD.IsEnabled = true;
            buttonW.IsEnabled = true;
        }
    }
}
