using System;
using System.Globalization;

namespace ThinkingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student("Manisha",23,"Female");
        }
        public static void Student(string name,int age,string gender)
        {
            Console.WriteLine("Name: {0} ,Age :{1} ,Sex: {2}", name, age, gender);
        }
    }
}
