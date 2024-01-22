using System;

namespace Accumulative
{
    internal class Accumulative
    {
        static double get_ave(int[] numbers)
        {
            int sum = 0;
            double ave = 0; 
            for (int i = 0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            ave = sum / numbers.Length; 

            return ave;            
        }

        static int get_fact(int num)
        {
            int fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }


        static void Main6(string[] args)
        {
            // Average for numbers from 1 to 10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sum = 0;
            double ave = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            ave = sum / numbers.Length;
            Console.WriteLine("Average for 1 to 10 is : {0}", ave);
            Console.WriteLine("Average for 1 to 10 from the method is : {0}", get_ave(numbers));

            int num = 5;
            int fact = 1;
            for(int i = num; i>= 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of {0} is {1}", num, fact);
            Console.WriteLine("Factorial of {0} using method is {1}", num, get_fact(num));

            Console.ReadKey();
        }
    }
}
