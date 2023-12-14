using System.Windows;
using System.Windows.Controls;

namespace IntroInheritance.WPF
{
    internal class Program
    {
        [STAThread]
        public void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel();
            window.Content = panel;
            app.Run(window);
        }
    }
}
