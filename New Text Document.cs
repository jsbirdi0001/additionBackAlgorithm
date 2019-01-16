using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jatinder = new newClass();
            jatinder.newMethod();
        }
    }

    
    class newClass
    {
        public static int howManyObjects = 0;
        public newClass()
        {
            howManyObjects++;
            Console.WriteLine("Ahhaaa!!!!");
            Console.ReadLine();
        }

        public void newMethod()
        {
            int sum = 0;
            for (int a = 819; a > 205; a -= 17)
            {
                sum += a;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
    }
}
