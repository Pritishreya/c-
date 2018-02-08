using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assign3
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Dictionary<string, int> pmList = new Dictionary<string, int>();
                pmList.Add("Atal Bihari Vajpayee", 1998);
                pmList.Add("Narendra Modi", 2014);
                pmList.Add("Manmohan Singh", 2004);
            foreach(var item in pmList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Find the Prime minister of 2004.");
            foreach (var pm in pmList)
            {
                if(pm.Value==2004)
                    Console.WriteLine("Minister: {0}, Year: {1}", pm.Key, pm.Value);
            }
            Console.WriteLine(" Add current prime minister in the dictionary.");
            pmList.Add("vvvvvv", 2017);
            foreach (var pm in pmList)
            {
                Console.WriteLine("Minister: {0}, Year: {1}", pm.Key, pm.Value);
            }
            Console.WriteLine("Sort the dictionary by year.");
            Console.WriteLine("/* Dictionary Before Sorted */");
            foreach (var item in pmList)
            {
                Console.WriteLine("Minister : " + item.Key + " And   Year : " + item.Value);
            }
            var list = pmList.Keys.ToList();
            list.Sort();
            Console.WriteLine();
            Console.WriteLine("/* Dictionary After Sorted */");
            foreach (var item in list)
            {
                Console.WriteLine("{0} : {1}", item, pmList[item]);
            }
        }
    }
}
