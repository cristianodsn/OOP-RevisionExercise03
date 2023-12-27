using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Console.WriteLine("Enter the three grades of the student:");
            Console.Write("Stuent's name:");
            string name = Console.ReadLine();
            double grade01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double grade02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double grade03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student = new Student() { Name = name, Grade01 = grade01, Grade02 = grade02, Grade03 = grade03 };

            Console.WriteLine();

            if(student.RemainingGrade() == 0.0)
            {
                Console.WriteLine(student);
                Console.WriteLine("APPROVED");                
            }

            else
            {
                Console.WriteLine(student);
                Console.WriteLine("DISAPROVED");
                Console.WriteLine("Remaining grade: " + student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
