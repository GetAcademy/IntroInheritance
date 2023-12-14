namespace IntroInheritance.Console
{
    internal class CenteredHeader : ITextElement
    {
        private string _text;

        public CenteredHeader(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Show('-');
        }

        public void Show(char paddingChar)
        {
            var startPos = (System.Console.WindowWidth - _text.Length) / 2;
            var dashCount = startPos - 4;
            var dashes = "  " + new string(paddingChar, dashCount) + "  ";
            System.Console.Write(dashes);
            System.Console.Write(_text);
            System.Console.WriteLine(dashes);
        }

        public void ShowHighlighted()
        {
            Show('*');
        }
    }
}
