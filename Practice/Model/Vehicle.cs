using Practice.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a base class `Vehicle` with a method `Start()`. Override it in `Car` and `Bike` classes to provide specific implementations. Use the `override` keyword and demonstrate polymorphism.
namespace Practice.Model
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("vehicle starts when engine is on.");
        }
    }
    
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is started with turning on the engine.");
        } 
    }
    
    public class Bike :Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is started with turning on the engine.");
        }
    }
}
