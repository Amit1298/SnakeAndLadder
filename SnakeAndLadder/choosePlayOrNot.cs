using System;

namespace choosePlayOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int choose = 1;
            Random random = new Random();
            //Computation
            int plays = random.Next(0, 2);
            if (plays == choose)
            {
                Console.WriteLine("Play the Snake And Ladder");
            }
            else
            {
                Console.WriteLine("Don not Play the Snake And Ladder");
            }
        }
    }
}
