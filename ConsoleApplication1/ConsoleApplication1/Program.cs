using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("ingrese primer numero");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("los numeros ingresados en orden ascendente sera:");
            if (x > y)
                Console.WriteLine(y + "," + x);
            else
                Console.WriteLine(x + "," + y);

            Console.ReadKey();
        }
    }
}
