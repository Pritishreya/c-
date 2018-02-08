using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace edo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] edos= { "Boat", " house", "cat", "river", "cupboard" };
                for (int i = 0; i < edos.Length; i++)
                {
                    edos[i] = edos[i] + "s";
                    Console.WriteLine("Plurals are: " + edos[i]);
                }
            Console.WriteLine("After Replacing into Synonyms: ");
            edos = String.Join(",", edos).Replace("house", "accomodation").Split(new Char[] { ',' });
            foreach (String item in edos)
            {
                Console.WriteLine(item);   
            }
            Console.WriteLine("Adding new words in array and print the length: ");
            edos[4]="Window";
            Console.WriteLine("Array length: "+ edos.Length);
            Console.WriteLine("Print the list of words which contains the length of characters as 7.");
            for (int i = 0; i < edos.Length; i++)
            {
                //problem in this part
                if (edos[i].Length==7)
                Console.WriteLine(edos[i]);
            }
            Console.WriteLine("print word on 3 rd position");
            edos[2] = "Doors";
            for (int i = 0; i < edos.Length; i++)
            {
                
                Console.WriteLine("print the array " + edos[i]);
            }
            Console.WriteLine("sort the array:");
            Array.Sort(edos);
            for (int i = 0; i < edos.Length; i++)
            {

                Console.WriteLine("print the array " + edos[i]);
            }
            Console.WriteLine("reverse the array:");
            Array.Reverse(edos);
            for (int i = 0; i < edos.Length; i++)
            {

                Console.WriteLine("print the array " + edos[i]);
            }
        } 
                
        }
        
        }
    

