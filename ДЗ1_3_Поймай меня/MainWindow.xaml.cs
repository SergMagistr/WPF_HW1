using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ДЗ1_3_Поймай_меня
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Random random = new Random();

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            // Получаем размеры окна и кнопки
            double windowWidth = this.ActualWidth;
            double windowHeight = this.ActualHeight;
            double buttonWidth = RunButton.ActualWidth;
            double buttonHeight = RunButton.ActualHeight;

            // Генерируем случайные координаты (с учётом размера кнопки)
            double newX = random.Next(0, (int)(windowWidth - buttonWidth));
            double newY = random.Next(0, (int)(windowHeight - buttonHeight));

            // Перемещаем кнопку
            RunButton.Margin = new Thickness(newX, newY, 0, 0);


        }
    }
}