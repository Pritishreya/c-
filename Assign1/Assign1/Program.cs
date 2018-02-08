using System;
using System.Collections;

namespace Assign1
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

    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            ArrayList productList = new ArrayList();
            productList.Add(new Product("lettuce", 10.5, 50, "Leafygreen"));
            productList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            productList.Add(new Product("cauliflower", 20, 100, "Cruciferous"));
            productList.Add(new Product("zucchini", 20.5, 50, "marrow"));
            productList.Add(new Product("yam", 30, 50, "Root"));
            productList.Add(new Product("spinach", 10, 100, "leafygreen"));
            productList.Add(new Product("brocolli", 20.2, 75, "Cruciferous"));
            productList.Add(new Product("Garlic", 30, 20, "Leafygreen"));
            productList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            Console.WriteLine("Total no. of product: " + productList.Count);
            productList.Add(new Product("potato", 10, 50, "Root"));
            foreach (Product item in productList)
            {
                Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);
            }
            Console.WriteLine("Total no. of product: " + productList.Count);
            foreach (Product item in productList)
            {
                if (item.type == "Leafygreen")
                {
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);
                }
            }
            Console.WriteLine("If all the garlic are sold out..");
            productList.RemoveAt(8);
            foreach (Product item in productList)
            {

                Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);

            }
            Console.WriteLine("If user add 50 cabbage in the inventory");
            foreach (Product item in productList)
            {
                if (item.name == "cabbage")
                {
                    item.quantity = item.quantity + 50;
                    Console.WriteLine("Name: " + item.name + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);
                }
            }
            Console.WriteLine("If user purchases 1 kg lettuce,2 kg zucchini,1 kg broccoli");
            double range=0;
            foreach (Product item in productList)
            {
                if (item.name == "lettuce")
                {
                    range = item.price;
                }
                else if (item.name == "zucchini")
                {
                    range += 2 * item.price;
                }
                else if (item.name == "brocolli")
                {
                    range += item.price;
                }
            }
                Console.WriteLine("Round amount user need to pay: " + range);

            
        }
    }
}