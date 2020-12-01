using System;
using System.Collections.Generic;
using task;

namespace unit-tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noms = new List<string>
            {
            string text = System.IO.File.ReadAllText(@"names.txt");

            List<string> l_names = SplitWords(text);

            l_names.Sort();
            
            //We can verify that the name "COLIN" is at the position 938 with the following code:
            Console.WriteLine(l_names[937]);
            //It indeed returns "COLIN"

            //We can verify the function ValChar with the following code:
            Console.WriteLine(ValChar('A'));
            Console.WriteLine(ValChar('B'));
            Console.WriteLine(ValChar('b'));
            //We obtain indeed "1", "2", "2", which are the vallues of this letters

            //This code verifies that the function SumName returns 53 for the name "COLIN", which is its value
            Console.WriteLine(SumName("COLIN"));

            //We can verify with this code that the TotalSum on a list with just the name "COLIN" returns the product of its value (53) with its position (1)
            Console.WriteLine(TotalNames( new List<string> { "COLIN" }));
        }
    }
}
