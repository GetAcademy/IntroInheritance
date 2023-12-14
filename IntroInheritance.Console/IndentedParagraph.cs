 namespace IntroInheritance.Console
{
    internal class IndentedParagraph : ITextElement
    {
        private string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            System.Console.CursorLeft = 8;
            System.Console.WriteLine(_text);
        }

        public void ShowHighlighted()
        {
            
            System.Console.CursorLeft = 8;
            System.Console.WriteLine(_text.ToUpper());
        }
    }
}
