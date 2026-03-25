namespace T2507E.session3;

public abstract class Animal
{
    public string Kind { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
    public abstract void Sleep();
}