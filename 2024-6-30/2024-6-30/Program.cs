using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2024_6_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number-{i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
             
            var (sum, average) = SumAndAverage(numbers);


            Console.WriteLine($"The sum of 10 numbers is: {sum}");
            Console.WriteLine($"The Average is: {average:F6}");

            Console.Write("Input number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());
















            DisplayCubes(terms);

            Console.Write("Input number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());
            CalculateAgeInDays(term);


            //Q3
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] newYears=GetYears(years);
            Console.WriteLine("years greater that 1950: ");
            foreach(int year in newYears)
            {
                Console.WriteLine(year);
            }
           
        }

        //Q1
        static (int, double) SumAndAverage(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            return (sum, average);
        }

        //Q2:

        static void DisplayCubes(int terms)
        {
            for (int i = 1; i <= terms; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}");
            }

        }

        //Q3
        static int[] GetYears(int[] years)
        {
            List<int> otherYears =new List<int>();
            for (int i= 0;i<years.Length;i++)
            {
                if (years[i] > 1950)
                {
                    otherYears.Add(years[i]);
                }
            }
            return otherYears.ToArray();
        }

        //Q4
        public static int CalculateAgeInDays(int years)
        {
            if (years <= 0)
            {
                Console.WriteLine("inter a valid age");
            }
            else
            {
                const int daysInYear = 365;
                Console.WriteLine($"the age in days is: {years * daysInYear}");
            }
            return 0;
        }


       


    } 
}
