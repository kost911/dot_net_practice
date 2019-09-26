using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace good_day2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            var today = DateTime.Now.TimeOfDay;
            
            if (today.Hours >= 9 && today.Hours <= 12)
            {
                Console.WriteLine(today);
                Console.WriteLine("Good morning, guys");
            }
            else if (today.Hours >= 12 && today.Hours <= 15)
            {
                Console.WriteLine(today);
                Console.WriteLine("Good day, guys");
            }
            else if (today.Hours >= 15 && today.Hours <= 22)
            {
                Console.WriteLine(today);
                Console.WriteLine("Good evening, guys");
            }
            else if (today.Hours >= 22 && today.Hours <= 9)
            {
                Console.WriteLine(today);
                Console.WriteLine("Good night, guys");
            }
             Console.ReadKey();
        }
    }
}
