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

namespace ДЗ1_2_Светофор
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

        private int currentLight = 0; // 0 - красный, 1 - желтый, 2 - зеленый

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //Все круги серые
            RedLight.Fill = Brushes.Gray;
            YellowLight.Fill = Brushes.Gray;
            GreenLight.Fill = Brushes.Gray;

            currentLight = (currentLight + 1) % 3; //0→1→2→0→1→2..

            // Устанавливаем цвет активного круга
            switch (currentLight)
            {
                case 0:
                    RedLight.Fill = Brushes.Red;
                    break;
                case 1:
                    YellowLight.Fill = Brushes.Yellow;
                    break;
                case 2:
                    GreenLight.Fill = Brushes.Green;
                    break;
            }
        }
    }
}