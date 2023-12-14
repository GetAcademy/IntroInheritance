using IntroInheritance.WPF.Model;
using System.Windows.Controls;

namespace IntroInheritance.WPF
{
    internal class CityForm : Grid
    {
        private TextBox _nameTextBox;
        private TextBox _countryTextBox;

        public CityForm()
        {
            var nameLabel = new Label { Content = "Navn" };
            _nameTextBox = new TextBox();
            var countryLabel = new Label{Content = "Land"};
            _countryTextBox = new TextBox();

            ColumnDefinitions.Add(new ColumnDefinition());
            ColumnDefinitions.Add(new ColumnDefinition());
            RowDefinitions.Add(new RowDefinition());
            RowDefinitions.Add(new RowDefinition());

            SetRow(nameLabel, 0);
            SetColumn(nameLabel, 0);

            SetRow(_nameTextBox, 0);
            SetColumn(_nameTextBox, 1);

            SetRow(countryLabel, 2);
            SetColumn(countryLabel, 0);
            
            SetRow(_countryTextBox, 2);
            SetColumn(_countryTextBox, 1);

            Children.Add(nameLabel);
            Children.Add(_nameTextBox);
            Children.Add(countryLabel);
            Children.Add(_countryTextBox);
        }

        public City GetPerson()
        {
            return new City
            {
                Name = _nameTextBox.Text,
                Country = _countryTextBox.Text
            };
        }
    }
}
