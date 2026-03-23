namespace T2507E.session2;

public class Vehicle
{
    public Vehicle()
    {
        
    }
    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void Run()
    {
        Console.WriteLine($"{Brand} {Model} running...");
    }
    public void Print()
    {
        Console.WriteLine("Print...");
    }
}