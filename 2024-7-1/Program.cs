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
            
            private string make;
            private int year;
            private string type;
            private double price;
            private string model;
            private string palletNo;
            private string color;
            private bool Running;

            public Car(string make, int year, string type, double price, string model, string palletNo, string color)
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

            public double Price
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
               
                   Console.WriteLine("the car started ");
                
                
            }

          
            public void StopEngine()
            {
               
                    Console.WriteLine("the car stopped.");
                
                
            }


            public string informationCar()
            {
                return $"Make: {make}, Year: {year}, Type: {type}, Price: {price:C}, Model: {model}, Pallet No: {palletNo}, Color: {color}";
            }

            public class BMW : Car
            {
                public BMW(string make, int year, string type, double price, string model, string palletNo, string color)
                : base(make, year, type, price, model, palletNo, color)
                {
                }
            }


        }
            static void Main(string[] args)
        {
            Car car =new Car("h", 2020 ,"js", 9990, "X", "zzzz", "black");

            Console.WriteLine(car.informationCar());
            car.StartEngine();
            car.StopEngine();

            BMW bmw = new BMW("BMW", 2023, "hnl", 6600, "X", "zzzz", "red");

            // Display car details
            Console.WriteLine(bmw.informationCar());

           
           
        }
    }
}
