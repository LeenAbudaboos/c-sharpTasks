using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_6_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Q1-	Correct the syntax error:

             */


            int[] ARR = { 1, 7, 9, 45 };

            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //Q2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };

            int index1 = Array.IndexOf(fruits, "Tomato");
            int index2 = Array.IndexOf(fruits, "Banana");

            Console.WriteLine("index of Tomato :" + index1);
            Console.WriteLine("index of Banana :" + index2);


            //Q3

            string[] favoriteFoods = { "cabab", "meat", "rice", "Pasta", "Mushroom soup" };
            string[] favoriteSports = { "tennis", "pool", "ski" };

            string[] favoriteMovies = { "harry potter", "cell 7", "the smurfs", "the message" };

            Console.WriteLine("favorite Foods: ");
            foreach (string f in favoriteFoods)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("favorite Sports: ");
            foreach (string s in favoriteSports)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("favorite Movies: ");
            foreach (string m in favoriteMovies)
            {
                Console.WriteLine(m);
            }

            //Q4

            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            int sum = num1 + num2 + num3;

            Console.WriteLine("The sum of three numbers: " + sum);

            //Q5

            int sum4 = 0;
            for (int i = -1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum4 += i;
                }
            }
            Console.WriteLine("\nThe Sum of odd Numbers is: " + sum4);

            //Q6
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {

                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //Q7

            int rows1 = 4;

            int currentNumber = 1;

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = rows1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }


                Console.WriteLine();
            }
        }
    }
}
