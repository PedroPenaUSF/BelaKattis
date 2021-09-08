using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().ToUpper().Split(" ");

            int hands = Convert.ToInt32(input[0]);
            char dominant = input[1][0];

            int totalPoints = 0;

            for(int i = 0; i < hands * 4; i++)
            {
                char[] card = Console.ReadLine().ToUpper().ToCharArray();

                char description = card[0];
                char suit = card[1];

                if (description == 'A')
                {
                    totalPoints += 11;
                }
                if (description == 'K')
                {
                    totalPoints += 4;
                }
                if (description == 'Q')
                {
                    totalPoints += 3;
                }
                if (description == 'J')
                {
                    if(suit == dominant)
                    {
                        totalPoints += 20;
                    }
                    else
                    {
                        totalPoints += 2;
                    }
                }
                if (description == 'T')
                {
                    totalPoints += 10;
                }
                if (description == '9')
                {
                    if (suit == dominant)
                        totalPoints += 14;
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(totalPoints);
        }
    }
}
