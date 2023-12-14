using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace IntroInheritance.WPF
{
    internal class ExitButton : Button
    {
        public ExitButton()
        {
            var borderStyle = new Style(typeof(Border));
            borderStyle.Setters.Add(new Setter(Border.CornerRadiusProperty, new CornerRadius(20)));
            Resources.Add(typeof(Border), borderStyle);
            Background = Brushes.Red;
            Foreground = Brushes.White;
            Width = 50;
            Height = 50;
            Content = "EXIT";
            Click += Exit;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
