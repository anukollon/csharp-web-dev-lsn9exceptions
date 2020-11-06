using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if(y == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if(fileName == null || fileName.Trim() == "")
            {
                throw new ArgumentNullException();
            }
            if (fileName.Contains(".cs"))
            {
                return 1;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine("Enter value of x: ");
            
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y: ");
            double y = Double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Divide(x, y));
            }
            catch
            {
                Console.WriteLine("Value of y cannot be zero!");
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            foreach(KeyValuePair<string, string> student in students)
             {
                try
                {
                    CheckFileExtension(student.Value);
                }

                 catch
                {
                    Console.WriteLine("Invalid file name for " + student.Key);
                    
                }
            }
            



        }
    }
}
