using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Nodes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input expression in polish inverted recording. Numbers and expressions should be separated by space.");
            string expression = Console.ReadLine();
            Console.WriteLine(PolishInvertedEntryParser.Parse(expression).GetDoubleValue());
            Console.ReadKey();
        }
    }
}
