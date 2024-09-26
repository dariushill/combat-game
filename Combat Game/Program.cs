using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;
            int healAmount = 5;

            int playerAttack = 5;
            int enemyAttack = 7;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                //player turn
                Console.WriteLine("--Player Turn --");
                Console.WriteLine("Player HP is: " + playerHp + ". Enemy HP is: " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal ");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                }
                else if (choice == "h")
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }

                //Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP is: " + playerHp + ". Enemy HP is: " + enemyHp);
                    int enemyChoice = random.Next(0, 2);
                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy resores " + healAmount + " heal points!");
                    }
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congrats!! You won the battle!");
            }
            else if (enemyHp > 0)
            {
                Console.WriteLine("I'm sorry, you lost the battle");
            }
        }
    }
}
