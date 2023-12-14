namespace IntroInheritance.Consolex
{
    internal class CenteredHeader : TextElement
    {
        public CenteredHeader(string text)
        : base(text)
        {
        }

        public override void Show()
        {
            Show('-');
        }

        public override void ShowHighlighted()
        {
            Show('*');
        }
    }
}
