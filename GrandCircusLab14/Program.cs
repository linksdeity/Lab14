using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14
{
    class Program
    {
        static void Main(string[] args)
        {

            CountTestApp.Count();

            while (true)
            {
                Console.WriteLine("Would you like to make some more sheep?\n'y' for 'Y'es, anything else for no!");

                string sheepName = "";
                int cloneNumber = 0;

                char answer = Console.ReadKey(true).KeyChar;

                if (answer == 'y' || answer == 'Y')
                {
                    Console.Clear();

                    sheepName = Validator.GetString("What is the name of the sheep?", @"^[A-Z][a-z]+$");

                    cloneNumber = Validator.GetNumber("How many should we make? (up too 100)", 1,100);

                    Console.Clear();

                    Sheep userMade = new Sheep(sheepName);

                    CountUntil.Count(userMade, cloneNumber);

                    Console.WriteLine("\npress anything to continue...");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("GOODBYE!!");
                    break;
                }

            }
            

            Console.ReadKey();
        }
    }
}
