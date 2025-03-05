using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public class Person
    {
        public virtual void GetDetails( int flag)
        {
            if (flag == 1)
            {
                Console.WriteLine("Hello Student!!");
            }
            else
            {
                Console.WriteLine("Hello Faculty!!");
            }
        }
    }

    public class Students : Person
    {
        public override void GetDetails(int flag)
        {
            base.GetDetails(flag);
        }
    }
    public class Teacher : Person
    {
        public override void GetDetails(int flag)
        {
            base.GetDetails(flag);
        }
    }
}
