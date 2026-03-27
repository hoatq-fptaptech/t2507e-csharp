using T2507E.session4;

var d = new Demo1();
var g = new PrintMessage(d.SayHello);
var h = new PrintMessage(Demo1.Goodbye);

g("T2507E"); // d.SayHello("T2507E");
h("Nguyen Van A"); // Demo1.Goodbye("Nguyen Van A");

g+= Demo1.Goodbye;
g+= d.SayHello;
g+=h;

g("FPT APTECH");

PrintMessage t = msg =>
{
    Console.WriteLine($"Anonymous {msg}");
};
t("XYZ");

var btn = new Button();
btn.OnClick(Demo1.Goodbye);
btn.Clicked("Button was Clicked");