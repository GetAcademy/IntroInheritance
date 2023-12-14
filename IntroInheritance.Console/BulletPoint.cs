namespace IntroInheritance.Console
{
    internal class BulletPoint : ITextElement
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            System.Console.Write(" * ");
            System.Console.WriteLine(_text);
        }

        public void ShowHighlighted()
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Show();
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
