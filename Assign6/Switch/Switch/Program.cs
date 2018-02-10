using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Switch
{
    public class Product
    {
        public Product(string name, double price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public string name;
        public double price;
        public int quantity;
        public string type;
        public double range, range1, range2;
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Product> productList = new List<Product>();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "Leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));
            /* foreach (Product item in productList)
             {
                 Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);
             }*/
            Console.WriteLine("Print each product list based Type of product (i.e. Leafy green, Cruciferous, Marrow etc.)");
            Console.WriteLine();
            Console.WriteLine("Enter the choice as follows......1.(type) for print product according to type");
            Console.WriteLine(" @2.(price) for print total price.  ");
            Console.WriteLine("@3.(avg) for calculating average of total price ");
            Console.WriteLine("@4.(costly) for calculating costly and cheap ");
            string value = Console.ReadLine();
            switch (value)
            {
                case "type":
                    Lg();
                    break;
                case "price":
                    Cs();
                    break;
                case "avg":
                    Mw();
                    break;
                case "costly":
                     costly(); 
                    break;
                default:
                    Console.WriteLine("Case not exit");
                    break;

            }
            void Lg()
            {
                Console.WriteLine("!!!!!!!!!Type Leafygreen!!!!!!!!");
                var result = productList.Where(item => item.type == "Leafygreen").ToList();
                foreach (var item in result)
                {
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity);
                }
                Console.WriteLine("!!!!!!!!Type Crusiferous!!!!!!!!");
                var result1 = productList.Where(item => item.type == "Cruciferous").ToList();
                foreach (var item in result1)
                {
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity);
                }
                Console.WriteLine("!!!!!!!!Type Marrow!!!!!!!!");
                var result2 = productList.Where(item => item.type == "Marrow").ToList();
                foreach (var item in result2)
                {
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity);
                }
                Console.WriteLine("!!!!!!!!Type Root!!!!!!!!");
                var result3 = productList.Where(item => item.type == "Root").ToList();
                foreach (var item in result3)
                {
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity);
                }
            } 
            void Cs()
            {
                Console.WriteLine("The total price of whole productlist including the quantities of products. ");
                double price1 = 0;
                foreach (var i in productList)
                {
                    price1 += (i.price * i.quantity);
                }
                Console.WriteLine(price1);
            }
            void Mw()
            {
                Console.WriteLine(" Print the Average price of the product. ");
                double tp = 0;
                double avg=0;
                foreach (var i in productList)
                {
                    tp = tp + (i.price * i.quantity);
                    avg += tp / productList.Count;
                }
                Console.WriteLine(avg);
            }
            void costly()
            {
                Console.WriteLine(" ---Compare the Costly product and chip product.---- ");
                foreach (var i in productList)
                {
                    if(i.price*i.quantity>50)
                    {
                        Console.WriteLine(i.name +" "+ "is costly product");
                    }
                    else
                        Console.WriteLine(i.name + " " + "is chip product");
                }
            }
        }
    }
}      
