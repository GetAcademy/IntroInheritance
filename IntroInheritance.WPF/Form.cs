using System.Windows.Controls;

namespace IntroInheritance.WPF
{
    internal class Form : Grid
    {
        protected readonly TextBox[] _textBoxes;

        public Form(params string[] labelTexts)
        {
            _textBoxes = new TextBox[labelTexts.Length];

            ColumnDefinitions.Add(new ColumnDefinition());
            ColumnDefinitions.Add(new ColumnDefinition());
            for (var index = 0; index < labelTexts.Length; index++)
            {
                RowDefinitions.Add(new RowDefinition());
            }

            for (var index = 0; index < labelTexts.Length; index++)
            {
                var labelText = labelTexts[index];
                var label = new Label { Content = labelText };
                var textBox = new TextBox();
                _textBoxes[index] = textBox;

                SetRow(label, index);
                SetRow(textBox, index);
                SetColumn(label, 0);
                SetColumn(textBox, 1);
                Children.Add(label);
                Children.Add(textBox);
            }
        }

        protected void AddField(string label)
        {

        }
    }
}
