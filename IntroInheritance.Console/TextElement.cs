namespace IntroInheritance.Consolex
{
    internal abstract class TextElement
    {
        protected string _text;

        protected TextElement(string text)
        {
            _text = text;
        }

        public abstract void Show();
        //{
        //    Console.WriteLine(_text);
        //}

        public virtual void ShowHighlighted()
        {
            Console.WriteLine(_text.ToUpper());
        }

        protected void Show(char paddingChar)
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var dashCount = startPos - 4;
            var dashes = "  " + new string(paddingChar, dashCount) + "  ";
            Console.Write(dashes);
            Console.Write(_text);
            Console.WriteLine(dashes);
        }
    }
}
