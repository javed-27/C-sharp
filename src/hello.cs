
String msg = "Hello world";
int i = 0;

while(i < 5)
{
  Console.WriteLine(i++ * 5);
}

Console.WriteLine(msg);

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = min - 3;
Console.WriteLine($"An example of overflow: {what}");

double dmax = double.MaxValue;
double dmin = double.MinValue;
Console.WriteLine($"The range of double is {dmin} to {dmax}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

Console.WriteLine("Decimal") ;
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

decimal dimin = decimal.MinValue;
decimal dimax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {dimin} to {dimax}");

Console.WriteLine("----------------------------------------------------------------------------\n");