//Create a base class `Vehicle` with properties `Brand` and `Speed`. Derive two classes `Car` and `Bike` from `Vehicle`.
//Add a method `DisplayInfo()` in `Vehicle` that should be accessible in the derived classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    public class Vehicle
    {
        public static string Brand { get; set; }
        public static string Speed { get; set; }
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The bike brand {Brand} has a top speed of {Speed}");
        }
    }
    public class Car : Vehicle
    {
        public Car(string brand, string speed)
        {
            Brand = brand;
            Speed = speed;
            DisplayInfo();
        }
    }
    public class Bike : Vehicle
    {
        public Bike(string brand, string speed)
        {
            Brand = brand;
            Speed = speed;
            DisplayInfo();

        }
    }
}
