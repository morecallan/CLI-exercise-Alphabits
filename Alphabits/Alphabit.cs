using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphabits.Messages;

namespace Alphabits
{
    //Use one Class in addition to the program file.
    public class AlphabitCommands
    {
        //Keep your user's successfully input letters as a list of characters
        public List<char> existingAlphabitsList = new List<char>();

        //Decide when to quit program
        public bool running { get; set; }

        public void addChar(char charToAdd)
        {
            charToAdd = char.ToLower(charToAdd);
            //Check to see if character is contained within the Alphabet
            if (Char.IsLetter(charToAdd))
            {
                //Check to see if charToAdd already exits in the list.
                if (existingAlphabitsList.Contains(charToAdd))
                {
                    //After each unsuccessful input, display a helpful message explaining why the input was unsuccessful (e.g. 'not a letter', 'duplicate letter', etc.)
                    Console.WriteLine(Messages.Messages.AlreadyEnteredThisLetter(charToAdd));
                }
                else
                {
                    //After each successful input, display the number of letters already entered.
                    existingAlphabitsList.Add(charToAdd);
                    Console.WriteLine(String.Format("You've added {0} valid, unique Alphabits", returnListLength()));
                    CheckLengthCountForSuccess();
                }
            }
            else if (charToAdd == '!')
            {
                //Create a non - letter "Easter egg" character that will display the current list of successfully input letters(but will not add itself to the list!)
                Console.WriteLine(Messages.Messages.EasterEggPrintExistingList());
                PrintList();
            }
            else
            {
                //After each unsuccessful input, display a helpful message explaining why the input was unsuccessful (e.g. 'not a letter', 'duplicate letter', etc.)
                Console.WriteLine(Messages.Messages.NotALetter(charToAdd));
            }
        }



        //Upon completing the task (entering in all 26 letters), the user should receive some gratifying message like "Congratulations"
        public void CheckLengthCountForSuccess()
        {
            if (existingAlphabitsList.Count() == 26)
            {
                Console.WriteLine(Messages.Messages.CompletedAlphabet());
                running = false;
            }
        }

        //RETURN LIST
        //Your class should include a constructor function, an "addChar" method, and a "listLength" method.
        public List<char> returnExistingList()
        {
            return existingAlphabitsList;
        }

        //RETURN LIST LENGTH
        //Your class should include a constructor function, an "addChar" method, and a "listLength" method.
        public int returnListLength()
        {
            return existingAlphabitsList.Count();
        }

        //PRINT LIST
        //Create a non-letter "Easter egg" character that will display the current list of successfully input letters (but will not add itself to the list!)
        public void PrintList()
        {
            Console.WriteLine(String.Format("You've successfully input {0} characters, you need {1} more. {2}", existingAlphabitsList.Count(), 26 - existingAlphabitsList.Count(), Environment.NewLine));
            Console.WriteLine(String.Format("Your current successful alphabits are:"));
            for (int i = 0; i < existingAlphabitsList.Count(); i++)
            {
                if (i == existingAlphabitsList.Count() - 1)
                {
                    Console.Write(String.Format("{0}", existingAlphabitsList[i]));
                }
                else
                {
                    Console.Write(String.Format("{0}, ", existingAlphabitsList[i]));
                }
            }

            Console.WriteLine();
        }


    }
}
