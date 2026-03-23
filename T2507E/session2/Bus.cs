namespace T2507E.session2;

public class Bus : Vehicle
{
    public string Color { get; set; }

    public Bus()
    {
        
    }
    
    public Bus(string brand, string model, string color) : base(brand, model)
    {
        Color = color;
    }

    public void SpeedUp()
    {
        base.Run();
        Console.WriteLine("Speeding up.. 10km/h");
    }

    public void SpeedUp(int speed)
    {
        Console.WriteLine("Speeding up.. " + speed);
    }
    
    public override void Run()
    {
        
    }

    public new void Print()
    {
         
    }
}