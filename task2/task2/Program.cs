using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Enter tow Number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int smallnum = Math.Min(num1, num2);

            Console.WriteLine($"The Small Number {smallnum}");


            //Q2
            Console.WriteLine("Enter Number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sample numbers:{num3}");
            int sign = Math.Sign(num3);

            Console.WriteLine($"sign:{sign}");

            //Q3
            int[] sorting = { 0, -1, 4 };
            Array.Sort(sorting);
            Console.Write(sorting[0] + " ");
            Console.Write(sorting[1] + " ");
            Console.WriteLine(sorting[2]);


            //Q4

            int[] max = { -5, -2, -6, 0, -1 };
            int num4 = Math.Max(max[0], Math.Max(max[1], Math.Max(max[2], Math.Max(max[3], max[4]))));
            Console.WriteLine("max number:" + num4);


            //Q5
            Console.WriteLine("Enter kilometers ");
            double kilometers = double.Parse(Console.ReadLine());
            Console.WriteLine("Input kilometers per hour: " + kilometers);
            double minutes = kilometers * 0.621371;
            Console.WriteLine(minutes + "  miles per hour ");

            //Q6


            Console.Write("Input hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Input minutes: ");
            int minute = int.Parse(Console.ReadLine());

            int total = (hours * 60) + minute;
            Console.WriteLine($"Total: {total} minutes.");

            //Q7

            Console.Write("Input minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());
            int hours1 = totalMinutes / 60;
            int minute1 = totalMinutes % 60;

            Console.WriteLine($"{hours1} Hours, {minute1} Minutes");

            //Q8

            string[] sentences = {"Hello, world!", "leen abudaboos","softwer engener","good day!","c# programing"};
            Console.WriteLine(sentences[0].Length);
            Console.WriteLine(sentences[1].Length);
            Console.WriteLine(sentences[2].Length);
            Console.WriteLine(sentences[3].Length);
            Console.WriteLine(sentences[4].Length);

            Console.WriteLine(sentences[0].Substring(0,5));
            Console.WriteLine(sentences[1].Substring(0, 5));
            Console.WriteLine(sentences[2].Substring(0, 5));
            Console.WriteLine(sentences[3].Substring(0, 5));
            Console.WriteLine(sentences[4].Substring(0, 5));


        }
    }
}
