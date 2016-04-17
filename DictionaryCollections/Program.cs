using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable["1"] = "One";
            hashtable["2"] = "Two";
            hashtable["3"] = "Three";
            hashtable["4"] = "Four";
            hashtable["0"] = "Zero";
            hashtable["5"] = "Five";
            hashtable["6"] = "Six";
            hashtable["7"] = "Seven";
            hashtable["8"] = "Eight";
            hashtable["9"] = "Nine";

            string ourNumber = "5682=%=+837347+=())!+%589893)!7";


            foreach (char i in ourNumber)
            {
                string element = i.ToString();
                if (hashtable.ContainsKey(element))
                {
                    Console.WriteLine(hashtable[element]);
                }
            }
        }
    }
}
