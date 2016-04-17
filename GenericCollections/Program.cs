using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> countryLookup = new Dictionary<int, String>();

            countryLookup[44] = "United Kingdom";
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands";
            countryLookup[55] = "Brazil";

            Console.WriteLine($"The 33 Code is for: {countryLookup[31]}");

            foreach (KeyValuePair<int, String> item in countryLookup)
            { 
                Console.WriteLine($"Code {item.Key} = {item.Value}");
            }

        }
    }
}
