using System;
using System.Globalization;

namespace ThinkingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your FirstName? ");
            var fName = Console.ReadLine();

            Console.Write("Enter your LastName? ");
            var lName = Console.ReadLine();

            
            Console.Write("Enter your date of birth in: ");
            var dateOfBirth = Console.ReadLine();

            
            var date = Convert.ToDateTime(dateOfBirth);
            //Student student1 = new Student();
            Student.GetAge(date,fName+" "+lName );
        }
    }
     public  class Student
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public static void GetAge(DateTime studentDateOfBirth,string name)
        {
            DateTime date = DateTime.Now.AddMonths(-11);
            //int presentMonth = Int32.Parse(DateTime.Now.Month.ToString());
            //int presentDay = Int32.Parse(DateTime.Now.Day.ToString());
            //int presentYear = DateTime.Now.Year;
            int presentMonth = Int32.Parse(date.Month.ToString());
            int presentDay = Int32.Parse(date.Day.ToString());
            int presentYear = date.Year;
            int pastMonth = Int32.Parse(studentDateOfBirth.Month.ToString());
            int pastDay = Int32.Parse(studentDateOfBirth.Day.ToString());
            int pastYear = studentDateOfBirth.Year;
            var age = presentYear- pastYear;
            if (age > 0)
            {
                if (presentMonth > pastMonth)
                {
                    if (presentDay > pastDay)
                    {
                        Console.WriteLine("{0} is {1} year old now.", name, age);
                    }
                    else
                    {
                        Console.WriteLine("{0} is {1} year old now.", name, age-1);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is {1} year old now.", name, age - 1);
                }
               
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
    }
}
