using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = " ";
            Console.WriteLine("Would you like to play?");
            Console.WriteLine("Please enter Yes to play.");
            userResponse = Console.ReadLine().ToLower();

            while (userResponse.Equals("yes"))
            {


                int jackPot = 100000;
                int numMatch = 0;


                Console.WriteLine("Please enter a starting number.");
                int minNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter mas number.");
                int maxNum = int.Parse(Console.ReadLine());

                int[] userNum = new int[6];

                Console.WriteLine("please enter six numbers.");

                for (int i = 0; i < userNum.Length; i++)
                {
                    int inputTest = int.Parse(Console.ReadLine());

                    while (inputTest < minNum || inputTest >= maxNum)
                    {
                        Console.WriteLine("Please enter a value greater than {0} and less than the {1}", minNum, maxNum);
                        inputTest = int.Parse(Console.ReadLine());
                    }

                    userNum[i] = inputTest; //int.Parse(Console.ReadLine());
                                            //Console.WriteLine(userNum[i]);
                }

                int[] ranArray = new int[6];
                Random r = new Random();

                for (int j = 0; j < ranArray.Length; j++)
                {
                    ranArray[j] = r.Next(minNum, maxNum);
                    Console.WriteLine("Lucky Number: {0}", ranArray[j]);
                }

                Console.WriteLine("Jackpot amount is {0}", jackPot);

                for (int k = 0; k < userNum.Length; k++)
                {
                    for (int l = 0; l < ranArray.Length; l++)
                    {
                        if (userNum[k] == ranArray[l])
                        {
                            numMatch++;
                            break;
                        }
                    }
                }

                Console.WriteLine("You guessed {0} numbers correctly.", numMatch);
                Console.WriteLine("You won {0} dollars.", jackPot / numMatch);
                Console.WriteLine("Type yes to play again.");
                userResponse = Console.ReadLine().ToLower();
            }
        }
    }//Class End
}//NameSpaceEnd
