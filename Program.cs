using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_1
{
    internal class Program
    {
        // Первая задачка. Не запускать и подумать Почему? wtf

        static void Main(string[] args)
        {
            int a = 10;
            int b = 38;
            int c = (31 - 5 * a) / b;
            // -19/38 = -0,5. Но тогда нужно вначале С присвоить float либо будет 0. 
            Console.WriteLine(c);
        }
    }
}