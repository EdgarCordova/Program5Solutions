using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekonepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Edgar";
            string currentGear;
            //string productList = ();
            List<string> sportGear = new List<string>() { " basketball", "baseball glove", "tennis shoes", "hockey puck" };
            for (int i = 0; i < sportGear.Count(); i++)
            {

                //get the curent sport out of sportslist 
                currentGear = sportGear[i];
                if (currentGear.Contains(" "))
                {
                    Console.WriteLine(currentGear.Trim(new Char[] { ' ' }));
                }
                else
                    Console.WriteLine(currentGear);




            }

            int myAge = 19;
            bool myBool = true;
            int q = 1;
            Console.WriteLine("my name is " + myName + " and I'm a beast of a programmer!");
            Console.WriteLine("I am " + myAge + " years of awesome");
            Console.WriteLine("I set my boolean value equal to " + myBool);





            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i <= 30; i = 2 + i)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i >= 0; i -= 5)
            {
                Console.WriteLine(i);
            }



            while (q < 11)
            {
                Console.WriteLine(q);
                q++;
            }
            int t = 10;
            while (t < 0)
            {
                Console.WriteLine(t);
                t--;
            }
            int even = 16;
            while (even <= 30)
            {
                Console.WriteLine(even);
                even++;
            }
            int HightoLow = 100;
            while (HightoLow >= 75)
            {
                Console.WriteLine(HightoLow);
                HightoLow -= 5;
            }
            q = 0; 
            while (myBool)
            {
                q++;
                Console.WriteLine(q);
                
                if (q%4==0)
                {
                    myBool = false;

                }
            }
            int count = sportGear.Count;
            Console.WriteLine("my name," + myName + " only has " + myName.Length + " letters in it");
            Console.WriteLine("my product list has " + count);
            for (int i = 0; i < sportGear.Count(); i++)
            {


                currentGear = sportGear[i];
                if (currentGear.Contains(" "))
                {
                    Console.WriteLine((currentGear.Trim(new Char[] { ' ' })) + " has " + currentGear.Length + " letters in it.");

                }
                else
               
                    Console.WriteLine(currentGear + " has " + currentGear.Length + " letters in it.");
               
                

            }

            Greeting("Beef HardChest");
            Greeting(myName);
            Doubleit(1337);
            Doubleit(myAge);
            multiply(2, 8);
            multiply(3, myAge);
            loopThis(20, 30);
            loopThis(0, myAge);
            superLoop(0, 100, 15);
            superLoop(0, 200, myAge);
            newGreeting("Neil deGrasse-Tyson");
            newGreeting(myName);
            
            Console.WriteLine(myAge + " tripled is "+ tripleit(myAge) );
            Console.WriteLine(realMultiply(5, 10));
            Console.WriteLine(realMultiply(2, myAge));
            superLoop(realMultiply(1, 5), tripleit(myAge), tripleit(myAge - 10));
            superLoop(realMultiply(1,tripleit(3)),tripleit(realMultiply(myAge,7)),tripleit(myAge-realMultiply(2,4)));

            Console.ReadKey();
        }
        static int realMultiply (int num1, int num2)
        {
            return num1 * num2;
        }
        static int tripleit(int number)
        {
          return  number=(number*3);
           
        }
        static void newGreeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void superLoop(int startNum,int endNum, int increasment)
        {
            int loopcount=0;
            if (startNum < endNum)
            {
                for (int i = startNum; i <= endNum; i += increasment)
                {
                    loopcount++;
                }
            }
           if (startNum < endNum)
            {
                for (int i = startNum; i <= endNum; i+=increasment)
                {
                loopcount++;
                }
           }
           Console.WriteLine("I'm looping from " +startNum+" to "+endNum+" , incrementing " + increasment+" each time!");
           Console.WriteLine("That loop was craaaaazy, we looped " +loopcount+ " times!");
        }
        static void loopThis(int startNum,int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
     
            if (startNum < endNum)
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void  Greeting(string name)
        {
           Console.WriteLine("Hello " + name);
           

        }
        static void Doubleit(int number)
        {
            Console.WriteLine(number + " doubled is " + (2*number));
        }
        static void multiply(int num1, int num2)
    {
        Console.WriteLine(num1 + " times " + num2 + " is " + (num2 * num1));
    }
        
    }
}

