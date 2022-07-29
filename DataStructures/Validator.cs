using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    internal class Validator
    {

        //METHODS

        //Check if string contains characters or spaces
        public static bool ContainsOnlyLetters(string str)
            => str.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));

        //Check if user wishes to continue
        public static bool GetContinue()
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.Write("\nWould you like to continue? y/n: ");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if(choice == "y")
                {
                    result = true;
                    break;
                }
                else if(choice == "n")
                {
                    result = false;
                    Console.Write("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine("That was an invalid entry. Try again.");
                }
            }
            return result;
        }

    }
}
