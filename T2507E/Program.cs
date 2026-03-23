// See https://aka.ms/new-console-template for more information

using T2507E.session1;
using T2507E.session2;

Console.WriteLine("Hello, World!");
int x = 10;
string y = "T2507E";
var z = 3.14;
var t = "ABC";
Console.WriteLine(z);
Console.WriteLine(t);
List<int> arr = new List<int>();
arr.Add(10);
arr.Add(20);
arr[0] = 10;
arr[1] = 20;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
foreach (var item in arr)
{
    Console.WriteLine(item);
}
var d = new Demo1("Huy",19){Telephone = "0987654321"};
var v = new Demo1{Telephone = "0987654321"};
d.Print();
v.Print();
var b = new Bus{Color = "Blue",Brand = "Toyota"};
