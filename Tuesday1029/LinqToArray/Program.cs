using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with LINQ to objects ****\n");

            // define an array of strings

            // This is the input array
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Dexter", "System Shock 2" };

            // desired query: Games that have a space in the title

            #region First let's try it the olde fashioned way 
            string[] result = QueryOverStringLongHand(currentVideoGames);

            #endregion

        }

        #region
        // This is the result array
        // creates an array of strings. Nothing in it...
        // If it has space puts it in array
        static void QueryOverStringLongHand(string[] s)
        {
            // temp array
            string[] resultsWithSpaces = new string[s.Length];

            // find the results 
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Contains(" "))
                    resultsWithSpaces[i] = s[i];
            }

            // sort results
            Array.Sort(resultsWithSpaces);

            // print results

            Console.WriteLine("Immediate results from longhand version.");
            foreach (string s1 in resultsWithSpaces)
            {
                if (s1 != null)
                    Console.WriteLine("Item: {0}", s1);

            }
            Console.WriteLine();

            // Generate a return array
            // Figure out size

            int count = 0;
            foreach (string s2 in resultsWithSpaces)
            {
                if (s2 != null) count++;
            }

            // create output array
            string[] outPutArray = new string[count];

            // Populate output array
            count = 0;
            foreach (string s1 in resultsWithSpaces)
            {
                if (s1 != null)
                {
                    outPutArray[count] = s1;
                    count++;
                }
            }

            return outPutArray;

        }

        #endregion


    }
}
