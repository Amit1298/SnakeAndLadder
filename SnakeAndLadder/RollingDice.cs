using System;

namespace RollingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            Console.WriteLine(result);
        }
    }
}
