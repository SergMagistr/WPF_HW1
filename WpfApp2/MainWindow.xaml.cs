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

namespace WpfApp2
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            byte r =  (byte)(RedSlider?.Value ?? 128);
            byte g = (byte)(GreenSlider?.Value ?? 128);
            byte b = (byte)(BlueSlider?.Value ?? 128);

            if (GreenValue != null)
                GreenValue.Text = g.ToString();
            if (RedValue != null)
                RedValue.Text = r.ToString();
            if (BlueValue != null)
                BlueValue.Text = b.ToString();

            Color color = Color.FromRgb(r,g,b);
            ColorRect.Fill =new SolidColorBrush(color);


        }
    }
}