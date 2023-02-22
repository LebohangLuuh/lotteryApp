using System;
using static System.Console;

namespace lotteryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int num1, num2, num3, matched = 0;
            int match1 = 10, match2 = 100, match3 = 1000 , perfect = 10000;

            WriteLine("Enter 3 numbers : ");
            num1 = Convert.ToInt32(ReadLine());
            num2 = Convert.ToInt32(ReadLine());
            num3 = Convert.ToInt32(ReadLine());


            for (int x = 1; x < 4; x++)
            {
                int rNum = randNum.Next(1, 5);
                Write("{0,5}", rNum);

               
                if (num1 == rNum || num2 == rNum || num3 == rNum)
                {
                    matched++;
                }

            }
                if (matched == 0)
                {
                    WriteLine("\nYou lost no number matched");
                }

                if (matched == 1)
                {
                    WriteLine("\nYou won $" + match1 + " for getting " + matched + " number(s) correct");
                }
                if (matched == 2)
                {
                    WriteLine("\nYou won $" + match2 + " for getting " + matched + " number(s) correct");
                }
                if (matched == 3)
                {
                    WriteLine("\nYou won $" + match3 + " for getting " + matched + " number(s) correct");
                }
                /*else
                {
                    if (num1 == rNum[1] && num2 == rNum[2] && num3 == rNum[3])
                    {
                        WriteLine("Perfect match \nYou won " + perfect + " numbers matched in correct order");
                    }
                }*/

            
            ReadKey();
        }
    }
}
