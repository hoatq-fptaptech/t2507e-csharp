namespace T2507E.session4;

public delegate void PrintMessage(string msg);
public class Demo1
{
    public void SayHello(string s)
    {
        Console.WriteLine($"Say hello: {s}");
    }

    public static void Goodbye(string s)
    {
        Console.WriteLine($"Goodbye: {s}");
    }
}