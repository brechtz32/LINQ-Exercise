using System;
using System.Collections.Generic;
using LINQ;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myVideoGames = new List<string>() { "call of duty", "league of legends", "raid shadow legens", "clash of clans"};

            var myGames = myVideoGames.OrderBy(x => x);

            foreach (var x in myGames)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
