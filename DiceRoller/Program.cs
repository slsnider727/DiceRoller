using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine("I have so many dice! I can roll anything!");
            Console.WriteLine("Enter the number corresponding to the dice you want to roll. (e.g. 4 for D4, 20 for D20)");
            int dieToRoll = Convert.ToInt32(Console.ReadLine());
            int result = dice.GetDiceResult(dieToRoll);
            Console.WriteLine($"I rolled a D{dieToRoll} and the result is {result}.");
        }

        public class Dice
        {
            public int GetDiceResult(int numberOfSides)
            {
                Random random = new Random();
                int randomInt = random.Next(1, (numberOfSides + 1));
                return randomInt;
            }

        }
    }
}
