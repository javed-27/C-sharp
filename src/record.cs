
public class Program
{
    public static void Main()
    {
        Point initialPoint = new Point(10, 5);
        var point = initialPoint with {Y=9};
        Console.WriteLine(initialPoint);
        Console.WriteLine(point);
        Console.WriteLine($"slope {initialPoint.Slope()}");
        Console.WriteLine(GetMessage());
        Person person = new Person("sivaji",20);
        Console.WriteLine(person.Greet());
        Console.WriteLine(person.parseName());
    }

    public static string GetMessage() => "Hello World";
}

public record Point(int X, int Y){
    public double Slope() => (double)Y / (double)X;
}

public class Person(String name, int age)
{
    public String Greet() => $"hello {name}";
    public int GetAge() => age;

    public string parseName()
    {
        int count = name.Length;
        return $"{count}:{name}";
    }
}