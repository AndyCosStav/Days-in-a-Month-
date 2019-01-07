using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month; 

            Console.Write("\n\n");
            Console.Write("Wanna see how many days there are in a month? Enter a number between 1 and 12! \n");
            Console.Write("Enter Number: ");
            Console.Write("\n\n");


            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: 
                    Console.Write("This month has 31 days in it! \n");
                    break;
                case 2: 
                      Console.Write("This month has 28 days in it! \n ");
                      break;
                case 4:
                case 6:
                case 9:
                case 11:
                      Console.Write("This month has 30 days in them! \n");
                    break;
                default:
                    Console.Write("This is not a month, please try again. \n ");
                    break;
            }
        }
    }
}
