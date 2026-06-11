var names = new List<String> { "javed", "test", "c-sharp" };
List<int> numbers = [1,2,3,4,5];
int[] num = [21,2,4,5];
Console.WriteLine(num[0]);
Console.WriteLine(numbers[0]);
numbers.Add(9);

foreach (var name in numbers)
{
  Console.WriteLine(name);
}