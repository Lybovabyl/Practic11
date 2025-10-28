using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп__5
{
    internal class Program
    {
        internal class Product
        {
            private double price;
            private double discount;

            public string Name
            { get; set; } = "Без названия"; 

            public double Price
            {
                get
                { return price; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Цена не может быть отрицательной!");
                        price = 0;
                    }
                    else
                    {
                        price = value;
                    }
                }
            }

            public double Discount
            {
                get
                { return discount; }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        discount = 0;
                    }
                    else
                    {
                        discount = value;
                    }
                }
            }

            public double FinalPrice
            {
                get
                { return Price * (1 - Discount / 100); }
            }

            public Product(double price, double discount)
            {
                Price = price;
                Discount = discount;
            }

            public void Show()
            {
                Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
            }
        }

    

        static void Main(string[] args)
        {
            Product product = new Product(1000, 10);
            product.Name = "Ноутбук";

            product.Show(); 
           
            product.Discount = 20;
            product.Show(); 

            
            product.Price = -500;
            product.Show();
            Console.ReadLine();
        }
    }
}
