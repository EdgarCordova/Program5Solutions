using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            int myageDoubled = Doubleit(18);

            Console.WriteLine(Doubleit(myageDoubled));
            loopTest();
            Console.ReadKey();
        }
      /// <summary>
      /// Writes Hello World to the console 
      /// </summary>
        static void HelloWorld()
        {
            //to display hello world
            Console.WriteLine("Hello World"); 
            
        }
       
        static int Doubleit(int someNumber)
        {
            //to return a number multiplied by 2 
            return someNumber * 2;
        }
 /// <summary>
 ///prints number to te console fromn the start to the end 
 /// </summary>
 /// <param name="startNumber"></param>
 /// <param name="endNumber"></param>
        static void loopSumNumbers(int startNumber, int endNumber)
        {
          
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void loopTest()
        {
            loopSumNumbers(5,10);
            loopSumNumbers(864123,867123);
            loopSumNumbers(19,Doubleit(19));

        }
        /// <summary>
        /// to count the vowel in the string 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        static int VowelCounter3000(string inputString)
        {
            //delcare a cunter of the vowel
            int numberOfVowelsFound = 0;
            //lp
            //loop over each letter of the string
            for (int i = 0; i < inputString.Length; i++)
            {
                string letter = inputString[i].ToString().ToLower;

               if(letter == "a"|| letter=="e"||letter=="i"||letter=="o"||letter=="u")
               {
                    //we found a vowel
                   numberOfVowelsFound++;
               }
            }
               //Alternate way of checking to see 
               // a vowel
               //if("aeiou".Contains(letter)){}
            
            //loop complete, tie to write the output 
            Console.WriteLine(inputString+" has " +numberOfVowelsFound + " VOWELS IN ITS");
            return numberOfVowelsFound;
        }

        static void VowelCounter3000Test()
        {
            //count the number of vowels
            int totalNumberOfVowelsCountered=0;
             totalNumberOfVowelsCountered+=VowelCounter3000("I hate your potatos. they taste like burnt hair and tar");
               
        }
        }
    }

 
}

