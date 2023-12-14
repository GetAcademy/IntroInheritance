using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

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

            var personForm = new PersonForm();
            //var personForm = new TwoFieldForm("Fornavn", "Etternavn", "E-post");
            //var cityForm = new CityForm();

            panel.Children.Add(personForm);
            panel.Children.Add(new Rectangle{Height = 30});
            //panel.Children.Add(cityForm);

            var textAndNumberForm = new TextAndNumberForm();
            panel.Children.Add(textAndNumberForm);

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



