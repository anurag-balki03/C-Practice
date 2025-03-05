using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PracticeQuestions2.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public virtual int GetDiscount(string type)
        {
            int Discount = 400;
            if (type == "Electronic")
                Discount = 5000;
            return Discount;
        }
    }
    public class ElectronicProduct : Product
    {
        public ElectronicProduct()
        {
            Console.Write("Enter the name of the electronic Product : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter the price of the Product : ");
            Price = int.Parse(Console.ReadLine());
            Type = "Electronic";
            Console.WriteLine($"Product Name : {ProductName} \nType of the Product : {Type} \nPrice of the Product : {Price}");
            int DiscountOnTotal = GetDiscount(Type);
            Price -= DiscountOnTotal;
            Console.WriteLine($"Total price after Discount : {Price}");
        }
        public override int GetDiscount(string type)
        {
            return base.GetDiscount(type);
        }
    }

    public class ClothingProduct : Product
    {
        public ClothingProduct()
        {
            Console.Write("Enter the name of the Clothing Product : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter the price of the Product : ");
            Price = int.Parse(Console.ReadLine());
            Type = "Clothing";
            Console.WriteLine($"Product Name : {ProductName} \nType of the Product : {Type} \nPrice of the Product : {Price}");
            int DiscountOnTotal = GetDiscount(Type);
            Price -= DiscountOnTotal;
            Console.WriteLine($"Total price after Discount : {Price}");
        }
        public override int GetDiscount(string type)
        {
            return base.GetDiscount(type);
        }
    }
}
