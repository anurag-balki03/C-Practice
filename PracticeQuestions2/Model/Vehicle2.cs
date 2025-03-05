using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    public class Vehiclee
    {
        public virtual void DisplayInfo(string brand, int speed)
        {
            Console.WriteLine($"{brand} has a top speed of {speed}");
        }
    }
    public class Car1 : Vehiclee
    {
        public string? Brand { get; set; }

        public int Speed { get; set; }

        public override void DisplayInfo(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
            base.DisplayInfo(Brand, Speed);
        }
    }

    public class Bike1 : Vehiclee
    {
        public string? Brand { get; set; }

        public int Speed { get; set; }

        public override void DisplayInfo(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
            base.DisplayInfo(Brand, Speed);
        }

    }
}
