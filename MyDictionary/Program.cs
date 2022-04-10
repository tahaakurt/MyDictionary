using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> liste = new Dictionary<string, int>();
            liste.Add("Resul", 178);
            liste.Add("Emre", 170);
            liste.Add("Taha", 173);
            liste.Add("Yasin", 180);


            Console.WriteLine("");
            Console.WriteLine("Listeye:" +liste.Count+ " Adet veri eklendi");
            Console.WriteLine("");
            Console.WriteLine("Listedeki değerler;");
            foreach (var item in liste.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("Listedeki Keyler;");

            foreach (var item in liste.Keys)
            {
                Console.WriteLine(item);
            }


        }

    }


}

