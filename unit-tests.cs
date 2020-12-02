//To use the following unit tests, you can either replace the previous Main with this one or add them in it, for example

        static void Main(string[] args)
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
            //We can add that the function works also with the following example, even though it is useless for our file names.txt:
            Console.WriteLine(SumName("colin"));
            //it is in the contrary impossible to use this function for words with accents:
            Console.WriteLine(TotalNames(new List<string> { "léo" })); //returns 164 instead of 32

            //We can verify that the TotalSum is correct with the several following tests:
            //Nn a list with just the name "COLIN" returns the product of its value (53) with its position (1)
            Console.WriteLine(TotalNames( new List<string> { "COLIN" }));
                
            //On lists emty or almost empty, where the result is 0:
            Console.WriteLine(TotalNames(new List<string> { "" }));
            Console.WriteLine(TotalNames(new List<string> {  }));

            //With a small list where we do the calcul at hand, so here we obtain 146
            //Indeed the value of "LINDA" is 12+9+14+4+1=40, et on a bien 1*40+2*53=146
            Console.WriteLine(TotalNames(new List<string> { "LINDA", "COLIN" }));
        }
