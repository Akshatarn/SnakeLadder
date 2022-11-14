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
            int player1 = 0, player2 = 0,selectPlayer = 1;
            
            Console.WriteLine("Initial(Start) position1 is:" + player1);
            int count1 = 0, count = 0;
            
                while (player2 < 100 && player1 < 100)
                {
                    Random random = new Random();
                    
                    //count++;
                    
                    if (selectPlayer == 1)
                        {
                            int diceOutput = random.Next(1, 7);
                            // position = position + diceOutput;
                            //Console.WriteLine("Position :" + position);
                            if(player1 < 100 && player1 >= 0)
                            {
                                Console.WriteLine("Player1 DiceValue  is :" + diceOutput);
                                Random random2 = new Random();
                                Console.WriteLine("Checking for Options");
                                int option = random2.Next(1, 4);
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Ladder");
                                        player1 += diceOutput;
                                        selectPlayer = 1;
                                        if (player1 > 100)
                                        {
                                            player1 -= diceOutput;
                                        }
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                    case 2:
                                        Console.WriteLine("Snake");
                                        player1 -= diceOutput;
                                        selectPlayer = 2;
                                        if (player1 < 0)
                                        {
                                            player1 = 0;
                                        }
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                    default:
                                        Console.WriteLine("No Play");
                                        //position = position;
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                }
                                Console.WriteLine("Player1 Current position = " + player1);
                                if(player1 < 0)
                                {
                                    player1 = 0;
                                }                        
                            }
                            count++;
                        }
                        else
                        {
                            int diceOutput = random.Next(1, 7);
                            if (player2 < 100 && player2 >= 0)
                            {
                                Console.WriteLine("Player2 DiceValue  is :" + diceOutput);
                                Random random2 = new Random();
                                Console.WriteLine("Checking for Options");
                                int option = random2.Next(1, 4);
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Ladder");
                                        player2 += diceOutput;
                                        selectPlayer = 2;
                                        if (player2 > 100)
                                        {
                                            player2 -= diceOutput;
                                        }
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                    case 2:
                                        Console.WriteLine("Snake");
                                        player2 -= diceOutput;
                                        selectPlayer = 1;
                                        if (player2 < 0)
                                        {
                                            player2 = 0;
                                        }
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                    default:
                                        Console.WriteLine("No Play");
                                        //position = position;
                                        //Console.WriteLine("Position :" + position);
                                        break;
                                }
                                Console.WriteLine("Player2 current postion = "+ player2);
                            }
                                if (player2 < 0)
                                {
                                    player2 = 0;
                                }
                            count1++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Player1 dice rolled count =" + count);
            Console.WriteLine("Player2 dice rolled count =" + count1);
            Console.WriteLine("Total dice count =" + (count+count1));
            if(player1 == 100)
            {
                Console.WriteLine("Player1 wins");
            }
            else
            {
                Console.WriteLine("Player2 Wins");
            }

        }
    }
}
