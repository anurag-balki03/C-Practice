using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    public abstract class User
    {
        public string? UserName { get; set; }

        public string? Role { get; set; }

        public string? Product { get; set; }

        protected static int ProductPrice { get; set; }

        public abstract void AccessControl();
    }
    public class Admin : User
    {
        public Admin(string username, string role)
        {
            Console.WriteLine($"HELLO {username}!!");
            if (role == "admin")
            {
                AccessControl();
            }
        }
        public override void AccessControl()
        {
            Console.Write("enter the price of the product : ");
            int Price = int.Parse(Console.ReadLine());
            SetPrice(Price);

        }
        public void SetPrice(int price)
        {
            ProductPrice = price;
        }
    }

    public class Customer : User
    {
        public Customer(string username, string role)
        {
            Console.WriteLine($"HELLO {username}!!");
            if(role == "customer")
            {
                AccessControl();
            }
        }
        public override void AccessControl()
        {
            Console.Write("Enter the product you want to buy : ");
            Product = Console.ReadLine();
            Console.WriteLine($"Your order for {Product} is placed sucessfully...");
            Console.WriteLine($"Cart Total : {ProductPrice}");
        }
    }
}
