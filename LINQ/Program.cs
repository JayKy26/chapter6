using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }

    public Student(string name, int age, double score)
    {
        Name = name;
        Age = age;
        Score = score;
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("John", 20, 85.5),
            new Student("Alice", 22, 90.0),
            new Student("Bob", 21, 75.3),
            new Student("Emily", 20, 88.9),
            new Student("David", 23, 78.6)
        };

        // chọn ra sinh viên có điểm số cao hơn 80
        var highScorers = from student in students
                          where student.Score > 80
                          select student;

        Console.WriteLine("High Scorers:");
        foreach (var student in highScorers)
        {
            Console.WriteLine($"{student.Name} - Age: {student.Age}, Score: {student.Score}");
        }

        Console.WriteLine();

        // sắp xếp sinh viên theo tuổi
        var sortedByAge = from student in students
                          orderby student.Age
                          select student;

        Console.WriteLine("Sorted by Age:");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"{student.Name} - Age: {student.Age}, Score: {student.Score}");
        }

        Console.WriteLine();

        // nhóm sinh viên theo tuổi
        var groupedByAge = from student in students
                           group student by student.Age;

        Console.WriteLine("Grouped by Age:");
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($" - {student.Name}, Score: {student.Score}");
            }
        }
    }
}
