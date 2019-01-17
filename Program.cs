using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleco696464
{
    class Program
    {
        static void Main(string[] args)
        {
           // var dogs = new List<String>();
            //dogs.Add("Bichon");
          // dogs.Add("Podle");

            /* foreach (var dog in dogs)
             {
                 Console.WriteLine(dog + " ");
             }*/

            // Console.WriteLine(dogs[1]);
            //Console.ReadLine();

            //NOW CREATE AN ARRAY!!!

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine( i);
            }
            Console.ReadLine();
        }
    }
}
