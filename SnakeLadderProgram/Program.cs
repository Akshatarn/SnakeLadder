using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Simulation");
            int position = 0;
            Console.WriteLine("Initial(Start) position is:" + position); 
            Random random = new Random();
            int diceOutput = random.Next(1, 7);
            Console.WriteLine("Dice Output is :" + diceOutput);
            Console.ReadLine();
        }
    }
}
