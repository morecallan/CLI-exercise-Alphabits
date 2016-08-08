using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphabits.Extras;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            AlphabitCommands alphabits = new AlphabitCommands();
            alphabits.running = true;

            while (alphabits.running)
            {
                Console.WriteLine("Enter a character to add to your Alphabit. Enter all 26 characters to win!");
                Console.Write("> ");
                char turdUserWantsToGetThisChar = Console.ReadLine().ToString().ToCharArray()[0];
                alphabits.addChar(turdUserWantsToGetThisChar);
            }


            Console.ReadLine();
        }
    }
}
