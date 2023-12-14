using System.Windows;
using System.Windows.Controls;

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
            panel.Children.Add(new ExitButton());
            app.Run(window);
        }
    }
}
