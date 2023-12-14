using System.Windows.Controls;
using IntroInheritance.WPF.Model;

namespace IntroInheritance.WPF
{
    internal class PersonForm : Form
    {
        // Pause til 1337



        public PersonForm() : base("Fornavn", "E-post")
        {
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
