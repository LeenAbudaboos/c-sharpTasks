using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2024_7_1.Program.Car;

namespace _2024_7_1
{
    internal class Program
    {

        public class Car
        {
            // Fields to store car's details
            private string make;
            private int year;
            private string type;
            private decimal price;
            private string model;
            private string palletNo;
            private string color;
            private bool Running;

            public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
            {
                this.make = make;
                this.year = year;
                this.type = type;
                this.price = price;
                this.model = model;
                this.palletNo = palletNo;
                this.color = color;
                this.Running = false;
            }

            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string PalletNo
            {
                get { return palletNo; }
                set { palletNo = value; }
            }

            public string Color
            {
                get { return color; }
                set { color = value; }
            }


            // Method to start the engine
            public void StartEngine()
            {
                if (!Running)
                {
                    Running = true;
                    Console.WriteLine("Engine started ");
                }
                
            }

          
            public void StopEngine()
            {
                if (Running)
                {
                    Running = false;
                    Console.WriteLine("Engine stopped.");
                }
                
            }


            public string informationCar()
            {
                return $"Make: {make}, Year: {year}, Type: {type}, Price: {price:C}, Model: {model}, Pallet No: {palletNo}, Color: {color}";
            }

            public class BMW : Car
            {
                public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color)
                : base(make, year, type, price, model, palletNo, color)
                {
                }
            }


        }
            static void Main(string[] args)
        {
            // Create a new BMW object
            BMW bmw = new BMW("BMW", 2023, "hnl", 6600, "X", "zzzz", "red");

            // Display car details
            Console.WriteLine(bmw.informationCar());

            // Start and stop the engine
            bmw.StartEngine();
            bmw.StopEngine();
        }
    }
}
