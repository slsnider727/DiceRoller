using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have these dice available: D4, D6, D8, D10, D12, D20, D100");
            Console.WriteLine("Enter the number corresponding to the dice you want to roll. (e.g. 4 for D4, 20 for D20)");
            int dieToRoll = Convert.ToInt32(Console.ReadLine());
        }

        public class Dice
        {
            public int GetD4Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 4);
                return randomInt;
            }

            public int GetD6Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 6);
                return randomInt;
            }

            public int GetD8Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 8);
                return randomInt;
            }

            public int GetD10Result()
            {
                Random random = new Random();
            }

            public int GetD12Result()
            {
                Random random = new Random();
            }

            public int GetD20Result()
            {
                Random random = new Random();
            }

            public int GetD100Result()
            {
                Random random = new Random();
            }
        }
    }
}
