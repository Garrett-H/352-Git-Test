using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _352_Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //random number guessing game
            Random rnd = new Random();
            Console.WriteLine("Starting guessing game.\nWhat is the range?: ");
            //alloting ranges
            Console.Write("Lowest bound: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Highest bound: ");
            int second = Convert.ToInt32(Console.ReadLine());
            //creating random number
            int ans = rnd.Next(first, second);
            Console.Write("Guess the number: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            //loops if incorrect

            while(guess != ans)
            {
                if(guess < ans)
                    Console.WriteLine("Too Low");
                else
                    Console.WriteLine("Too High");
                Console.Write("Guess again: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n You got the right number!");

            Console.WriteLine("\nPress Enter to exit");
            Console.Read();
        }
    }
}
