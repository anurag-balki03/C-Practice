using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    interface IFlyable
    {
        void Fly();
    }
    interface ISwimmable
    {
        void Swim();
    }
    class Duck : IFlyable,ISwimmable
    {
        public Duck()
        {
            Swim();
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("DUCK CAN FLY FOR SHORTER DISTANCES");
        }

        public void Swim()
        {
            Console.WriteLine("DUCK CAN SWIM");
        }
    }
}
