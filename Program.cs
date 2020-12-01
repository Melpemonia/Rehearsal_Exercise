using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_fraunhofer
{
    class Program
    {
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

        static int ValChar(char c)
        {
            return char.ToUpper(c) - 64;
        }
        
        static int SumName(string name)
        {
            int s = 0;
            foreach(char c in name)
            {
                s += ValChar(c);
            }
            return s;
        }

        static int TotalNames(List<string> l_names)
        {
            int n = 0;
            for (int i=0; i<l_names.Count; i++)
            {
                n += (i+1) * SumName(l_names[i]);
            }
            return n;
        }
        
        static void Main(string[] args)
        {
            List<string> noms = new List<string>
            {
                "MARY",
                "PATRICIA",
                "LINDA",
                "BARBARA",
                "ELIZABETH",
                "JENNIFER",
                "AGNES",
                "VERA",
                "WILLIE",
                "CHARLENE",
                "BESSIE",
                "DELORES",
                "MELINDA",
                "PEARL",
                "ARLENE",
                "MAUREEN",
                "COLLEEN",
                "ALLISON",
                "TAMARA",
                "JOY",
                "GEORGIA"
            };
            noms.Sort();
            foreach (string personne in noms)
            {
                System.Diagnostics.Debug.WriteLine(personne);
            }

            string text = System.IO.File.ReadAllText(@"names.txt");


            // Display the file contents to the console. Variable text is a string.

            List<string> l_names = SplitWords(text);

            l_names.Sort();

            Console.WriteLine(l_names.Count);

            Console.WriteLine(ValChar('a'));

            Console.WriteLine(ValChar('b'));

            Console.WriteLine(l_names[2]);

            Console.WriteLine(SumName("COLIN"));

            Console.WriteLine(l_names[937]);

            Console.WriteLine(TotalNames( new List<string> { "COLIN" }));

            Console.WriteLine(TotalNames(l_names));

            //Console.WriteLine(text);

        }
    }
}
