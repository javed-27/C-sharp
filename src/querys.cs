
var s1 = new Student("javed", new DateOnly(2005, 05, 27));
var s2 = new Student("tony", new DateOnly(2010, 05, 27));
var s3 = new Student("ahmed", new DateOnly(2008, 05, 27));
var s4 = new Student("laptop", new DateOnly(2015, 05, 27));
var s5 = new Student("test", new DateOnly(1985, 05, 27));

void dbg(object exp) { Console.WriteLine(exp); }


List<Student> data = [s1, s2, s3, s4];

var major = from student in data
            where student.getAge() > 18
            select $"name: {student.getName()}, age : {student.getAge()}";

var after2000 = from student in data
                where (DateTime.Now.Year - 2000) > student.getAge()
                select $"name: {student.getName()} , age:{student.getAge()}";

data.Add(s5);

Console.WriteLine("students who are born after 2000 are");

foreach (var student in  after2000)
{
  Console.WriteLine(student);
} 

Console.WriteLine("\nstudents who are over 18");

foreach (var student in  major)
{
  Console.WriteLine(student);
} 

public class Student(String name, DateOnly dob)
{
  private readonly String name = name;
  private readonly DateOnly dob = dob;
  public String getName()
  {
    return this.name;
  }

  public int getAge()
  {
    int currentYear = DateTime.Now.Year;
    return currentYear - this.dob.Year;
  }

}