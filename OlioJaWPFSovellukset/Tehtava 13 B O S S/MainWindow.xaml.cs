using System;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace WindowAreaCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtWidth.Text, out double width) &&
                double.TryParse(txtHeight.Text, out double height) &&
                double.TryParse(txtFrameWidth.Text, out double frameWidth))
            {
                // Laske ikkunan pinta-ala
                double windowArea = width * height;

                // Laske karmin piiri
                double framePerimeter = 2 * (width + height);

                // Laske koko ikkunan pinta-ala (ikkunalasi + karmi)
                double totalArea = (width + 2 * frameWidth) * (height + 2 * frameWidth);

                // Päivitä tulos näytölle
                lblResult.Text = $"Ikkunan Pinta-ala: {windowArea} cm²\nKarmin Piiri: {framePerimeter} cm\nKoko Ikkunan Pinta-ala: {totalArea} cm²";

                // Piirrä ikkuna näytölle
                DrawWindow(width, height, frameWidth);
            }
            else
            {
                MessageBox.Show("Syötä kelvolliset numerot.");
            }
        }

        private void DrawWindow(double width, double height, double frameWidth)
        {
            // Piirrä ikkuna Canvas-elementille
            canvas.Children.Clear();

            RectangleGeometry windowGeometry = new RectangleGeometry(new Rect(0, 0, width, height));
            RectangleGeometry frameGeometry = new RectangleGeometry(new Rect(-frameWidth, -frameWidth, width + 2 * frameWidth, height + 2 * frameWidth));

            GeometryGroup windowGroup = new GeometryGroup();
            windowGroup.Children.Add(windowGeometry);
            windowGroup.Children.Add(frameGeometry);

            Path windowPath = new Path
            {
                Fill = Brushes.Transparent,
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Data = windowGroup
            };

            canvas.Children.Add(windowPath);
        }
    }
}
