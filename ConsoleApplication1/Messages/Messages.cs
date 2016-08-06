using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphabits.Extras;

namespace Alphabits.Messages
{
    //Use the String.Format method to craft your messages to users
    public static class Messages
    {
        public static string NotALetter(char attemptedCharToAdd)
        {
            return String.Format("You dumb dumb, {0} is not a letter. Try Again.", attemptedCharToAdd);
        }

        public static string AlreadyEnteredThisLetter(char attemptedCharToAdd)
        {
            return String.Format("Close but no cigar, {0} has already been entered. Try Again.", attemptedCharToAdd);
        }

        public static string CompletedAlphabet()
        {
            return String.Format("Woohoo you did it!");
        }

        public static string EasterEggPrintExistingList()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            return String.Format("You clever fellow, you've discovered the Easter Egg. {0} {1} {0}I hope you like pink.{0}", Environment.NewLine, ASCII.EasterEggLiterally());
        }
    }
}
