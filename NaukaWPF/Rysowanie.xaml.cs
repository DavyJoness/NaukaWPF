using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NaukaWPF
{
    /// <summary>
    /// Interaction logic for Rysowanie.xaml
    /// </summary>
    public partial class Rysowanie : Window
    {
        public Rysowanie()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clear();

            SolidColorBrush scb = new SolidColorBrush();
            scb.Color = Color.FromArgb(100, 25, 50, 0);

            Ellipse el = new Ellipse();
            el.Width = 200;
            el.Height = 100;
            el.Fill = scb;

            drawSpace.Children.Add(el);
        }

        private void ButtonDrawRectangle_Click(object sender, RoutedEventArgs e)
        {
            Clear();

            SolidColorBrush scb = new SolidColorBrush();
            scb.Color = Color.FromArgb(100, 25, 50, 0);

            Rectangle rec = new Rectangle();
            rec.Width = 200;
            rec.Height = 100;
            rec.Fill = scb;

            drawSpace.Children.Add(rec);
        }

        public void Clear()
        {
            drawSpace.Children.Clear();
        }
    }
}
