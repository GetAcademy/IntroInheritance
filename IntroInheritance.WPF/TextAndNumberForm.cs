using IntroInheritance.WPF.Model;

namespace IntroInheritance.WPF
{
    internal class TextAndNumberForm : MultiForm<TextAndNumber>
    {
        public TextAndNumberForm()
        {
            AddField<string>("Tekst");
            AddField<int>("Tall", true);
        }

        // Denne er overflødig, men gir kanskje litt økt forståelse
        public TextAndNumber GeTextAndNumber()
        {
            return Get<TextAndNumber>();
        }
    }
}
