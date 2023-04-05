using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Lab04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hippodrome.UserControlHorse[] horses = new Hippodrome.UserControlHorse[3];
        Hippodrome.UserControlFinish[] finishes = new Hippodrome.UserControlFinish[3];
        Hippodrome.UserControlPosition[] positions = new Hippodrome.UserControlPosition[3];
        DispatcherTimer timer, timerUpdateSpeed;
        Random random = new Random();
        Canvas[] canvases = new Canvas[3];
        bool flStart = false;
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            for (int i = 0; i < 3; i++)
            {
                canvases[i] = new Canvas();
                Grid.SetRow(canvases[i], i);
                grid.Children.Add(canvases[i]);
            }
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(1000);
            
            timerUpdateSpeed = new DispatcherTimer();
            timerUpdateSpeed.Tick += new EventHandler(timer_Tick_Update_Speed);
            timerUpdateSpeed.Interval = new TimeSpan(0,0,2);
            
        }

        private void Start()
        {
            for (int i = 0; i < 3; i++)
            {
                canvases[i].Children.Clear();
                finishes[i] = new Hippodrome.UserControlFinish();
                positions[i] = new Hippodrome.UserControlPosition();
                horses[i] = new Hippodrome.UserControlHorse(random.Next(20, 50));
                canvases[i].Children.Add(finishes[i]);
                canvases[i].Children.Add(horses[i]);
                canvases[i].Children.Add(positions[i]);
                Canvas.SetLeft(positions[i], 50);
                Canvas.SetRight(finishes[i], 0);
            }
            timer.Start();
            timerUpdateSpeed.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
           
            for(int i = 0; i < 3; i++)
            {
                if (horses[i].IsFinish)     // лошадка уже финишировала
                    continue;

                int k = 0; // позиция лошадки
                for (int j = 0; j < 3; j++)
                {
                    if (horses[j].IsFinish || horses[i].XHorse <= horses[j].XHorse) k++;
                }
                if(horses[i].XHorse < 1100)   // еще не финишировала
                {
                   horses[i].UpdatePosition(k);
                   
                    horses[i].XHorse += (float)horses[i].GetSpeed() / 2000.0f;
                }
                else    // лошадка на финише в первый раз
                {
                    horses[i].UpdatePosition(k);
                    positions[i].SetPosition(k);
                    horses[i].IsFinish = true;      // лошадка уже на финише
                }
            }
            
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if(flStart == false)
            {
                flStart = true;
                Start();
            }
            if(timer.IsEnabled)
            {
                ((Button)sender).Content = "Start";
                timer.IsEnabled = false;
                timerUpdateSpeed.IsEnabled = false;
            }
            else
            {
                ((Button)sender).Content = "Pause";
                timer.IsEnabled = true;
                timerUpdateSpeed.IsEnabled = true;
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void timer_Tick_Update_Speed(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (horses[i].XHorse < 1100)
                {
                    horses[i].UpdateSpeed(random.Next(30, 80));
                    
                }
            }
        }
    }
}
