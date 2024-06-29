using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            //Q2

            double num1 = 2.3;
            string num2 = "33";
            char num3 = '1';
            bool num4 = false;
            int num5 = 0;
            const int num6 = 4;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);


            //Q3
            string[] car = { "BMW", "MARS", "VEVO" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car.Length);


            //Q4

            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastname ");
            string lname = Console.ReadLine();

            Console.WriteLine("Input your year of birth:  ");
            string year = Console.ReadLine();

            Console.WriteLine(fname + " " + lname + " " + year);

            //Q5

            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write(arr[0]);
            Console.Write(arr[1]);
            Console.Write(arr[2]);
            Console.Write(arr[3]);
            Console.Write(arr[4]);
            Console.Write(arr[5]);
            Console.Write(arr[6]);
            Console.Write(arr[7]);
            Console.Write(arr[8]);
            Console.WriteLine(arr[9]);


            //Q6
            int[] numbers = { 2, 5, 8 };

            Console.WriteLine(numbers[0] + numbers[1] + numbers[2]);
        }
    }
}
