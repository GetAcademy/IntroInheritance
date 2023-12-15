using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace IntroInheritance.WPF
{
    internal class MultiForm<T> : Grid
    {
        protected readonly List<TextBox> _textBoxes;

        public MultiForm(params string[] labelTexts)
        {
            _textBoxes = new List<TextBox>();
            ColumnDefinitions.Add(new ColumnDefinition());
            ColumnDefinitions.Add(new ColumnDefinition());
        }

        public void AddField(string labelText, bool isLast = false)
        {
            RowDefinitions.Add(new RowDefinition());
            var label = new Label { Content = labelText };
            var textBox = new TextBox();
            var index = _textBoxes.Count;
            _textBoxes.Add(textBox);
            SetRow(label, index);
            SetRow(textBox, index);
            SetColumn(label, 0);
            SetColumn(textBox, 1);
            Children.Add(label);
            Children.Add(textBox);
            if (isLast) AddButton();
        }

        private void AddButton()
        {
            RowDefinitions.Add(new RowDefinition());
            var button = new Button { Content = "Registrer" };
            button.Click += ButtonClick;
            Children.Add(button);
            var index = _textBoxes.Count;
            SetRow(button, index);
            SetColumnSpan(button, 2);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var obj = Get<T>();
            var type = obj.GetType().FullName;
            var json = JsonSerializer.Serialize(obj);

            var messageBoxText = type + "\n" + json;
            var caption = "Objekt";
            var button = MessageBoxButton.OK;
            var icon = MessageBoxImage.Information;
            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        public T Get<T>()
        {
            var instance = Activator.CreateInstance<T>();
            var type = instance.GetType();
            var properties = type.GetProperties();
            for (var index = 0; index < properties.Length; index++)
            {
                var property = properties[index];
                var textBox = _textBoxes[index];
                object value = textBox.Text;
                if (property.PropertyType == typeof(int))
                {
                    value = Convert.ToInt32(value);
                }
                property.SetMethod.Invoke(instance, new object[] { value });
            }
            return instance;
        }
    }
}
