using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterFinder
{
    class Program
    {

        static void Main(string[] args)
        {

        }
          
        //create a new function for the letter finder 
        static void LetterFinder(string letterToFind, string stringToSearch)
        {
           //declare a counter for the number of matches
            int letterOfMatchesFound = 0;
            //loop through each letter of the stringToSearch
            for (int i = 0; i <= stringToSearch.Length; i++)
            {
                string currentLetter = stringToSearch[i].ToString().ToLower();
                if (currentLetter == letterToFind.ToLower())
                {
                    //found a match
                    letterOfMatchesFound++;
                }
            }
            Console.WriteLine(stringToSearch+" Has "+ letterOfMatchesFound+" "+ letterToFind +" in it ");
        }

    }
}
