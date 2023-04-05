using System.Windows.Controls;
namespace Hippodrome
{
    /// <summary>
    /// Логика взаимодействия для UserControlPosition.xaml
    /// </summary>
    public partial class UserControlPosition : UserControl
    {
        public UserControlPosition()
        {
            InitializeComponent();
        }
        public void SetPosition(int pos)
        {
            position.Text = pos.ToString();
        }
    }
}
