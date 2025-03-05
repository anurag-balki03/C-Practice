using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    public class Account
    {
        public virtual void CalculateInterest(int flag)
        {
            Console.WriteLine("base class ");
        }
    }

    sealed class SavingsAccount : Account
    {
        public int Principle { get; set; }
        public int Roi { get; set; }
        public int Time { get; set; }
        public Double Result { get; set; }
        public override void CalculateInterest(int flag)
        {
            Console.Write("Enter the Principle Amount : ");
            Principle = int.Parse(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            Roi = int.Parse(Console.ReadLine());
            Console.Write("Enter the Time Period : ");
            Time = int.Parse(Console.ReadLine());
            if (flag == 1)
            {
                Result = (Principle * Time * Roi) / 100;
            }
            else
            {
                Result = Principle * Math.Pow((1 + Roi ), Time);
            }
            Console.WriteLine();
        }
    }
}
