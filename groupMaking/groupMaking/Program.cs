using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            //class list 
            List<int> classList= new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            List<int> Group= new List<int>();
            Random rng = new Random();

            while (classList.Count > 0)
            {
                int picker = rng.Next(0,classList.Count);
                int classMate= classList[picker];
                classList.Remove(classMate);
                Group.Add(classMate);
                
                if (Group.Count == 4)
                {
                    // need to figue out how to print out 
                    Console.WriteLine("Group \n #{1} #{0} #{2} #{3}", Group[0], Group[1], Group[2], Group[3]);
                    Group.Clear();
                }

            }

            Console.ReadKey(); 
        }
       
       
    }
}
