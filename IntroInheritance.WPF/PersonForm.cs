using System.Windows.Controls;
using IntroInheritance.WPF.Model;

namespace IntroInheritance.WPF
{
    internal class PersonForm : Form
    {
        public PersonForm() : base("Fornavn", "E-post")
        {
            AddField("Fornavn");
            AddField("E-post");
        }

        public Person GetPerson()
        {
            return new Person
            {
                FirstName = _textBoxes[0].Text,
                Email = _textBoxes[1].Text
            };
        }
    }
}
