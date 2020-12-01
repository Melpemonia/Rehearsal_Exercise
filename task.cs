using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        //A function to separate the names of the files in a List<string>;
        static List<string> SplitWords(string text)
        {
            List<string> l_names = new List<string>();
            int i = 0;

            while (i < text.Length)
            {
                string name = "";
                while (text[i] != '"' && text[i]!= ',')
                {
                    name += text[i];
                    i += 1;
                }
                if (name != "")
                {
                    l_names.Add(name);
                }
                i += 1;
            }

            return l_names;
        }

        //Returns the value of a letter:
        static int ValChar(char c)
        {
            return char.ToUpper(c) - 64;
        }
        
        //Returns the value of a word:
        static int SumName(string name)
        {
            int s = 0;
            foreach(char c in name)
            {
                s += ValChar(c);
            }
            return s;
        }

        //Returns the value of a SORTED list of string containing the names:
        static int TotalNames(List<string> l_names)
        {
            int n = 0;
            for (int i=0; i<l_names.Count; i++)
            {
                n += (i+1) * SumName(l_names[i]);
            }
            return n;
        }
        
        //Main programm:
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"names.txt"); //You have to write the path of the file name.txt here, or to put it on the bin/Debug repertory of a Visual Studio project
            
            List<string> l_names = SplitWords(text); //Splits the string of names in a list

            l_names.Sort(); //Sorts the list

            //Calculates the sum of all name values that are stored in the attached names.txt file
            //and writing it in the Console
            Console.WriteLine(TotalNames(l_names));
        }
    }
}
