using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingoverthis
{
    class Program
    {
        static void Main(string[] args)
        {
            loopOverAList();
            LoopOverWordsInAString("the quick brown fox jump over the lazy dog");
            Console.ReadKey();
        }
        static void loopOverAList()
        {
            //create a list of sports 
            List<string> sportsList = new List<string>() { "Baseball", "Tennis" };
            //add Football to the sportsLis 
            sportsList.Add("Football");
            //loopover the sports list and display all
            //elments that contain the word "ball"
            for (int i = 0; i < sportsList.Count(); i++)
            {
                //get the curent sport out of sportslist 
                string currentSport = sportsList[i];
                //check to see if its a sportwith the word 
                //"ball" in it 
                while (currentSport.Contains(" "))
                {
                    Console.WriteLine(currentSport.Trim( new Char[] { ' ' } ));
                }


            }
        }
         static void LoopOverWordsInAString(string inputString)
         {
             List<string> wordList=inputString.Split(' ').ToList();
             for (int i=0;i<wordList.Count();i=i+1)
             {
                Console.WriteLine(wordList[i]);
             }
         
        }
    }
}
