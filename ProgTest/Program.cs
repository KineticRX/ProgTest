using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ProgTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = 60;
            int[] multiples = new int[] { 2, 5, 6, 10, 15 };
            String[] multReps = new String[] { "Two", "Five", "Six", "Ten", "Fifteen" };
            List<String> testList = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);
            foreach (String str in testList)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }

        
    }
}
