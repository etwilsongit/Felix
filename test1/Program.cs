using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program //this is a class, just like Console is a class
    {
        static void Main(string[] args) //this is a method. it is what's called when the program starts.


        //bool = trueORfalse
        {
            //Introduce Felix, prompt user for input, have Felix greet the user
            Console.WriteLine("Hello, my name is Felix. What is your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello, " + name + ".");

            
            Console.WriteLine("\nWould you like to tell me something about yourself? (YES/NO)\n");
            string tellFelix = Console.ReadLine();
            switch (tellFelix)
            {
                //how the user choses to interact with Felix
                case "YES":
                    Console.WriteLine("\nExcellent, that makes me glad.");
                    Console.WriteLine("[Hit ENTER]");
                    Console.ReadLine();
                    break;
                case "NO":
                    Console.WriteLine("\nI wonder if we'll speak again...");
                    break;

                //default:
                //    Console.WriteLine("Sometimes, I also feel unsure...");
                //    break;
            }

            Console.WriteLine("\nWhere are you from?\n");
            string location = Console.ReadLine();

            Console.WriteLine("\nOh...I have never been to " + location + ".");

            Console.WriteLine("\nIs it nice? I hope so. [Hit ENTER]");

            Console.ReadKey();



        }
    }
}
