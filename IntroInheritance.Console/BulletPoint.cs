namespace IntroInheritance.Consolex
{
    internal class BulletPoint : TextElement
    {
        public BulletPoint(string text)
        :base(text)
        {
        }

        public override void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }

        public void ShowHighlighted()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
