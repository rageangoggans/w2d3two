using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Enter Age");
            

            int x = Convert.ToInt32(Console.ReadLine());
            
           

            if (x >= 17)
            {
                Console.WriteLine("You can enter.");
            }
            
              else 

               {
                    Console.WriteLine("Do not enter!");
                }

            
        }
    }
}
