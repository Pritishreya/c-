using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> InList = new List<string>()
            {
                "Tomato","Potato","ToMato","Potato","Red Tomato","Tomato Catchup","Grapes","grapes","potato"
            };

            var chk = InList.ConvertAll(ar => ar.ToUpper());
            int cnt = 0;
            foreach (string w in chk)
            {
                if (w == "TOMATO")
                    cnt++;
            }
            Console.WriteLine("The Number of Tomato string: " + cnt);
            for (int i= 0;i < InList.Count;i++)
            {
                    if(InList[i]=="Potato")
                    Console.WriteLine("The index of Potato is " + i);
            }
        }
    }
}