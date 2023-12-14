using IntroInheritance.Consolex;

var a = new CenteredHeader("Overskrift 1");
var b = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
var c = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
var d = new CenteredHeader("Overskrift 2");
var e = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");

var f1 = new BulletPoint("a");
var f2 = new BulletPoint("b");
var f3 = new BulletPoint("c");

//var te = new TextElement("Terje");

var textElements = new TextElement[] { a, b, c, d, e, f1, f2, f3};
foreach (var textElement in textElements)
{
    textElement.Show();
}

Console.ReadKey();

Console.Clear();
foreach (var textElement in textElements)
{
    textElement.ShowHighlighted();
}