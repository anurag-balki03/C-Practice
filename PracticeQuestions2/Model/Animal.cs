using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Cat : Animal
    {
        public string Sound { get; set; }
        public Cat()
        {
            Sound = "MEOW";
            this.MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Cat : {this.Sound}");
        }
    }

    public class Dog : Animal
    {
        public string Sound { get; set; }
        public Dog()
        {
            Sound = "Bark";
            this.MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Dog : {this.Sound}");
        }
    }
}
