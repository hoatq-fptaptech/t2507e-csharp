namespace T2507E.session1;

public class Demo1
{
   private string name;
   private int age;

   public Demo1()
   {
   }

   public Demo1(string name, int age)
   {
      this.name = name;
      this.age = age;
   }

  // properties
  public string Name
  {
     get{ return name; }
     // set{ name = value; }
  }
  public int Age
  {
     // get => age;
     set => age = value;
  }
  // abstract propeties
  public string Telephone { get; set; }
   
   public void Print()
   {
      Console.WriteLine(name);
      Console.WriteLine(age);
   }
}