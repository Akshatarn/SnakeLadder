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
           
            while (position >=0 && position < 100)
            {
                Random random = new Random();
                int diceOutput = random.Next(1, 7);
                Console.WriteLine("Dice Output is :" + diceOutput);
                position = position + diceOutput;
                Console.WriteLine("Position :" + position);
                Random random2 = new Random();
                Console.WriteLine("Checking for Options");
                int option = random2.Next(1, 4);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("No Play");
                        position = position;
                        Console.WriteLine("Position :" + position);
                        break;
                    case 2:
                        Console.WriteLine("Ladder");
                        position += diceOutput;
                        Console.WriteLine("Position :" + position);
                        break;
                    case 3:
                        Console.WriteLine("Snake");
                        position -= diceOutput;
                        Console.WriteLine("Position :" + position);
                        break;
                }
            } 
           Console.ReadLine(); 
        }
    }
}
