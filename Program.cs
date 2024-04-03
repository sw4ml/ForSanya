using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek;
            Console.WriteLine("Введите день недели");

            dayOfWeek = Console.ReadLine();
             
            switch (dayOfWeek) 
            {
                case "понедельник":
                    Console.WriteLine("идем в кино");
                    break;
                case "вторник":
                    Console.WriteLine("идем в бассей");
                    break;

            }
         

        }
    }
}
