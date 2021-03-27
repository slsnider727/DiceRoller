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
    }
}
