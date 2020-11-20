using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string seasons;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Season Name :");
            seasons = Console.ReadLine();
            switch (seasons)
            {
                case "spring":
                    Console.WriteLine("January , February , March");
                    break;
                case "summer":
                    Console.WriteLine("April , May , June");
                    break;
                case "fall":
                    Console.WriteLine("July , August , September");
                    break;
                case "winter":
                    Console.WriteLine("October , November , December");
                    break;
            }
        }
    }
}
