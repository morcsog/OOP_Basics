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
            public string color;
            public string brand;
            public string type;
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
            Vehicle car = new Vehicle();
            Vehicle ship = new Vehicle();
            Vehicle bike = new Vehicle();

            car.type = "Car";
            car.brand = "Audi";
            car.color = "Grey";

            ship.type = "Ship";
            ship.brand = "Audi";
            ship.color = "White";

            bike.type = "Bike";
            bike.brand = "Kawasaki";
            bike.color = "Kawasaki Green";

            car.Move();
            ship.Move();
            bike.Move();

            /*
            Console.WriteLine(GreetTheUser("Béla"));
            Console.WriteLine(GreetTheUser("Géza"));
            Console.WriteLine(GreetTheUser("Gábor")); */
            Console.ReadKey();
        }
    }
}
