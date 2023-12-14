using System.Windows.Controls;

namespace IntroInheritance.WPF
{
    internal class PersonForm : Grid
    {
        public PersonForm()
        {
            var firstNameTextBox = new TextBox();
            var emailTextBox = new TextBox();

            // Legg til andre UI-komponenter eller konfigurasjon etter behov

            // Sett opp radene og kolonnene i griden
            ColumnDefinitions.Add(new ColumnDefinition());
            ColumnDefinitions.Add(new ColumnDefinition());
            RowDefinitions.Add(new RowDefinition());
            RowDefinitions.Add(new RowDefinition());

            // Legg til komponentene i riktig rute i griden
            Grid.SetRow(firstNameTextBox, 0);
            Grid.SetColumn(firstNameTextBox, 1);

            Grid.SetRow(emailTextBox, 2);
            Grid.SetColumn(emailTextBox, 1);
        }
    }
}
