using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 7, 9, 1, 2, 5};

            // length
            Console.WriteLine("Length : " + numbers.Length);

            //indexof()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4: "  +index);

            //clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("After clear");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //copy

            int[] a = new int[3];
            Array.Copy(numbers, a, 3);

            Console.WriteLine("Copy");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            //sort
            Array.Sort(numbers);
            Console.WriteLine("Sort");
            foreach( var n in numbers)
            {
                Console.WriteLine(n);
            }

            // reverse
            Array.Reverse(numbers);
            Console.WriteLine("Reverse");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
                //Console.ReadLine
            }
        }
        
    }
}
