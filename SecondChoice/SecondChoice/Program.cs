

using SecondChoice;

var forloop = new ForLoop();
forloop.Loop();

var employee = new Employee(34000, "Bachana");
Console.WriteLine(employee.DisplayInfo());


var fruit = new Fruit(23, 12);
Console.WriteLine(fruit.CalculateTotalPrice());

var electronics = new Electronics(12, 3);
Console.WriteLine(electronics.CalculateTotalPrice());

var sparrow = new Sparrow();
sparrow.MakeSound();
var pigeon = new Pigeon();
pigeon.MakeSound();

var myLocation = new MyLocation<int>();
myLocation.AddItem(10);
myLocation.AddItem(20);
myLocation.AddItem(30);

Console.WriteLine(myLocation.GetIndex(2));
