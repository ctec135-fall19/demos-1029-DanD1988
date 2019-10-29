using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_WAY
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Dexter", "System Shock 2" };

            QueryOverString(currentVideoGames);

            #endregion

            
        }
        #region

        static void QueryOverString(string[] inputArray)
        {
            // build querry
            // IEnumerable<string> subset = from ...
            var subset = from game in inputArray
                         where game.Contains(" ")
                         orderby game
                         select game;

            // print results
            ReflectOverQueryResults(subset, "Querry Expression");

            // print results 
            Console.WriteLine("  Immediate results using LINQ query");
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();

            // demnstrate reuse of query 
            // example of deffered execution
            inputArray[0] = "some string";
            Console.WriteLine("  Immediate results using LINQ query");
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();

            // demonstrate returning result - immediate execution 
            List<string> outputList = (from game in inputArray
                                       where game.Contains(" ")
                                       orderby game
                                       select game).ToList<string>();
            return outputList;

        }

        static void ReflectOverQueryResults(object resultSet, string queryType)
        {
            Console.WriteLine("*** query type: {0}", queryType);
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location", resultSet.GetType().Assembly.GetName().Name);
        }

        #endregion
    }
}
