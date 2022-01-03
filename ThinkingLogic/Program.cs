using System;
using System.Collections.Generic;
using System.Globalization;

namespace ThinkingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 56, 7, 8, 9, 0, 12, 12, 45, 67, 98, 100 };
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            var result = EvenNumber(numbers);
            foreach (var item in EvenNumber(numbers))
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            var numberList = ReturnEvenAndOddList(numbers, evenList, oddList);
            foreach(var number in numberList.OddNumbers)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            foreach (var number in numberList.EvenNumbers)
            {
                Console.Write(number+" ");
            }
           
        }
        public static List<int> EvenNumber(List<int> numbers)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
            }
            return evenList;
        }
        public static TypeOfListNumber ReturnEvenAndOddList(List<int> numbers,List<int> even,List<int> odd)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
                else
                {
                    odd.Add(numbers[i]);
                }
            }
            TypeOfListNumber typeOfList = new TypeOfListNumber();
            typeOfList.EvenNumbers = even;
            typeOfList.OddNumbers = odd;

            return typeOfList;
        }
    }
        public class TypeOfListNumber
        {
            public List<int> EvenNumbers { get; set; }
            public List<int> OddNumbers { get; set; }
        }

    
}
