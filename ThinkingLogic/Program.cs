using System;
using System.Globalization;

namespace ThinkingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var data =Info("Manisha",'F',23);
            Console.WriteLine(data.name);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.age);

        }
        public static StudentInfo Info(string name,char gender,int age)
        {
            var info = new StudentInfo()
            {
                name = name,
                gender = gender,
                age = age
            };
            return info;
        }  
    }
    public class StudentInfo
    {
        public string name {get; set; }
        public char gender { get; set; }
        public int age { get; set; }
    }
}
