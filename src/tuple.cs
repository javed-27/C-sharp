var tuple1 = (x:1, y:"Hello", z:3.14);
var tuple2 = tuple1 with {};

Console.WriteLine(tuple1);
Console.WriteLine(tuple2);
tuple1.x = 9;
Console.WriteLine(tuple1);
Console.WriteLine(tuple2);