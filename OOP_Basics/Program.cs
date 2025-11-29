using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{    
    internal class Program
    {
        public class Vehicle
        {
            public string color { get; private set; }
            public string brand;
            public string type;
            
            public Vehicle(string color, string brand, string type)
            {
                this.color = color;
                this.brand = brand;
                this.type = type;
            }

            public string GetBrand()
            {
                return this.brand;
            }
            public string GetType()
            {
                return this.type;
            }

            public void SetColor(string color)
            {
                this.color = color;
            }
            public void Move()
            {
                if(this.type == "Ship")
                {
                    Console.WriteLine($"This {this.color} {this.type} sails in the water.");
                }else if(this.type == "Car")
                {
                    Console.WriteLine($"This {this.color} {this.type} rolls on the road on four wheels.");
                }
                else if(this.type == "Bike")
                {
                    Console.WriteLine($"This {this.color} {this.type} rolls on the road on two wheels.");
                }
            }
        }

        static string GreetTheUser (string name)
        {
            return $"Hello {name}";
        }
        static int AddTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static void BarkMachine()
        {
            Console.WriteLine("Bark bark bark vagy VAU VAU VAU");
        }
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("White", "Audi", "Car");
            Vehicle ship = new Vehicle("Red", "Ship Brand", "Ship");
            Vehicle bike = new Vehicle("Pink", "Csepel", "Bike");            

            car.Move();
            ship.Move();
            bike.Move();            
            Console.WriteLine($"Brand property: {car.GetBrand()}");
            Console.WriteLine(car.color);
            car.SetColor("Black");
            Console.WriteLine(car.color);            

            /*
            Console.WriteLine(GreetTheUser("Béla"));
            Console.WriteLine(GreetTheUser("Géza"));
            Console.WriteLine(GreetTheUser("Gábor")); */
            Console.ReadKey();
        }
    }
}
