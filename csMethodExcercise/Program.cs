using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csMethodExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            */
            //testing
            Console.WriteLine(Add(20, 3, 4));
            Console.WriteLine(Subtract(20, 3, 4));
            Console.WriteLine(Multiply(20, 3, 4));
            Console.WriteLine(Divide(20, 3, 4));
            Console.WriteLine(Modulus(20, 3, 4));

            string name = getInput("What is your name?");
            string color = getInput("What is your favorite color?");
            string animal= getInput("What is your favorite animal?");
            string band = getInput("What is your favorite band?");
            string s;
            Console.WriteLine($"Once you were walking down the street and someone called out, {name}.  You looked up and it was a {color} {animal}.  Then you went to listen to {band}.");
            do
            {
                Console.WriteLine("Press enter to close...");
                s = Console.ReadLine();
            } while (!s.Equals(""));
        }
        public static string getInput(string output)
        {
            Console.WriteLine(output);
            string s=Console.ReadLine();
            return s;
        }
        /*
         * Declare 5 methods:
             Add method 
             Subtract method
             Multiply method
             Divide method
             Modulus method
        */
        public static int Add(params int[] list)
        {
            int solution = 0;
            for (int i = 0; i < list.Length; i++)
            {
                solution += list[i];
            }


            return solution;
        }
        public static int Subtract(params int[] list)
        {
            int solution = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                solution -= list[i];
            }


            return solution;

        }
        public static int Multiply(params int[] list)
        {

            int solution = 1;
            for (int i = 0; i < list.Length; i++)
            {
                solution *= list[i];
            }


            return solution;
        }
        public static int Divide(params int[] list)
        {

            int solution = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] == 0)
                    return 0;
                solution /= list[i];
            }


            return solution;
        }
        public static int Modulus(params int[] list)
        {

            int solution = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                solution %= list[i];
            }


            return solution;
        }
    }
}
