using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public string Name { get; set; }
    public string Course { get; set; }
    public int Age { get; set; }
    
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Alexis Torres",
            Course = "Computer Engineer",
            Age = 43
        };
        Console.Write("Student Name:" + student.Name);
        Console.Write(",");
        Console.Write("Age:" + student.Age);
        Console.Write(",");
        Console.Write("Course:" + student.Course);
    }
}
