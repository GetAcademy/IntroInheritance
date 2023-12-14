using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace IntroInheritance.WPF
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();

            var panel = new StackPanel();



            window.Content = panel;
            app.Run(window);
        }
    }
}


//var yellowButton = new YellowButton();
//yellowButton.Content = "Hei";
//panel.Children.Add(yellowButton);

//var bigButton = new BigYellowButton();
//bigButton.Content = "Hei";
//panel.Children.Add(bigButton);

//panel.Children.Add(new ExitButton());
//panel.Children.Add(new ExitButton());
//panel.Children.Add(new ExitButton());
//panel.Children.Add(new ExitButton());



