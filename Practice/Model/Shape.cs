using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            Console.Write("enter radius of the circle : ");
            int Radius = int.Parse(Console.ReadLine());
            double Result = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area of the cirle : {Result}");
        }
    }

    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            Console.Write("enter Length of the Rectangle : ");
            int Len = int.Parse(Console.ReadLine());
            Console.Write("Enter Breadth of the Rectangle : ");
            int Bred = int.Parse(Console.ReadLine());
            int result = Len * Bred;
            Console.WriteLine($"Area of the Rectangle : {result}");
        }
    }
}
