using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prefer to read the jumbled jargon behind a webpage instead"
                + " of that ridiculously readable format?");

            Console.WriteLine("Here's the answer to all your problems.");

            Console.WriteLine("Copy a URL here:");

            string userInput = Console.ReadLine();

            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebpage(userInput);

            //sample hardcoded instead of user Input
            //string value = myScrape.ScrapeWebpage("https://msdn.microsoft.com/en-us/");

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
