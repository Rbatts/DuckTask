using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTask
{
    public class Program
    {

        static void Main(string[] args)
        {
            Dictionary<Duck, string> duckDictionary = new Dictionary<Duck, string>
            {
                {new Duck("Sir Quacksalot", "Mallard", 100, 17), ""},
                {new Duck("Quackers", "Legend", 120, 20), ""},
                {new Duck("Lenny", "Flappy", 80, 10), ""},
                {new Duck("Rodger", "Old", 110, 25), ""},
                {new Duck("Harold", "Fancy", 200, 23), ""},
                {new Duck("Bread Boy", "Mallard", 190, 30), ""}
            };

            List<Duck> duckList = duckDictionary.OrderByDescending(d => d.Value).Select(d => d.Key).ToList();

            foreach (var duck in duckList)
            {
                Console.WriteLine(duck);
                Console.ReadLine();
            }
        }
    }

}
