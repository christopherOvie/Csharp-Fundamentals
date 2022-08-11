using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFive
{
    public class Exercise_FiveHomework
    {

        public static void Main(string[] args)
        {
            //addNumbers(6, 9);
            PrintName();
            PrintName("john");
            PrintName("john","mike");


        }
        public static void addNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);

        }
            public static void PrintName()
            {
            Console.WriteLine("chris");  
            }
        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static void PrintName(string firstname,string lastname)
        {
            Console.WriteLine($"My names are {firstname}{lastname}");
        }
    }
    
}
