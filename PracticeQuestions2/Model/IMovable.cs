using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    interface IMovable
    {
        void Move();
    }
    public class Machine
    {
        public virtual void Start()
        {
            Console.WriteLine("THE BACE CLASS");
        }
    }

    public class Robot : Machine, IMovable
    {
        public Robot()
        {
            Start();
            Move();
        }
        public void Move()
        {
            Console.WriteLine(".....THE ROBOT STARTS MOVING.....");
        }
        public override void Start()
        {
            Console.WriteLine("THE ROBOT IS TURNED ON!!!");
        }
    }
}
