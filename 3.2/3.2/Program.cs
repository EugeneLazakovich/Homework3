using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            Boolean answer;
            Console.WriteLine("Enter your number #1:");
            string stry1 = Console.ReadLine();
            int try1 = int.Parse(stry1);
            if (try1 == value)
            {
                answer = true;
                goto theend;
            }
            else
            {
                if (try1 < value)
                {
                    Console.WriteLine("My number is bigger!");
                }
                else
                {
                    Console.WriteLine("My number is smaller!");
                }
            }
            Console.WriteLine("Enter your number #2:");
            string stry2 = Console.ReadLine();
            int try2 = int.Parse(stry2);
            if (try2 == value)
            {
                answer = true;
                goto theend;
            }
            else
            {
                if (try2 < value)
                {
                    Console.WriteLine("My number is bigger!");
                }
                else
                {
                    Console.WriteLine("My number is smaller!");
                }
            }
            Console.WriteLine("Enter your number #3:");
            string stry3 = Console.ReadLine();
            int try3 = int.Parse(stry3);
            if (try3 == value)
            {
                answer = true;
                goto theend;
            }
            else
            {
                if (try3 < value)
                {
                    Console.WriteLine("My number is bigger!");
                }
                else
                {
                    Console.WriteLine("My number is smaller!");
                }
            }
            Console.WriteLine("Enter your number #4:");
            string stry4 = Console.ReadLine();
            int try4 = int.Parse(stry4);
            if (try4 == value)
            {
                answer = true;
                goto theend;
            }
            else
            {
                if (try4 < value)
                {
                    Console.WriteLine("My number is bigger!");
                }
                else
                {
                    Console.WriteLine("My number is smaller!");
                }
            }
            Console.WriteLine("Enter your number #5:");
            string stry5 = Console.ReadLine();
            int try5 = int.Parse(stry5);
            if (try5 == value)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            theend:
            if (answer)
            {
                Console.WriteLine("Congratulations! You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.WriteLine("Correct answer: "+value);

        }
    }
}
