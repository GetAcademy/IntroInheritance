 namespace IntroInheritance.Consolex
{
    internal class IndentedParagraph : TextElement
    {
        public IndentedParagraph(string text) : base(text)
        {
        }

        public override void Show()
        {
            Console.CursorLeft = 8;
            base.Show();
        }

        public void ShowHighlighted()
        {
            Console.CursorLeft = 8;
            base.ShowHighlighted();
        }
    }
}
