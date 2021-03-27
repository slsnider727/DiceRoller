using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine("I have these dice available: D4, D6, D8, D10, D12, D20, D100");
            Console.WriteLine("Enter the number corresponding to the dice you want to roll. (e.g. 4 for D4, 20 for D20)");
            int dieToRoll = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (dieToRoll)
            {
                case 4:
                    result =  dice.GetD4Result();
                    break;
                case 6:
                    result = dice.GetD6Result();
                    break;
                case 8:
                    result = dice.GetD8Result();
                    break;
                case 10:
                    result = dice.GetD10Result();
                    break;
                case 12:
                    result = dice.GetD12Result();
                    break;
                case 20:
                    result = dice.GetD20Result();
                    break;
                case 100:
                    result = dice.GetD20Result();
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't have any dice like that.");
                    break;
            }
            Console.WriteLine($"I rolled a D{dieToRoll} and the result is {result}.");
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
                int randomInt = random.Next(1, 10);
                return randomInt;
            }

            public int GetD12Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 12);
                return randomInt;
            }

            public int GetD20Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 20);
                return randomInt;
            }

            public int GetD100Result()
            {
                Random random = new Random();
                int randomInt = random.Next(1, 100);
                return randomInt;
            }
        }
    }
}
