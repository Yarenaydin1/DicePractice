using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        private Dictionary<int, string> diceTypes = new Dictionary<int, string>
    {
        { 2, "Coin" },
        { 4, "Pyramid Dice" },
        { 6, "Backgammon Dice" },
        { 8, "D8 Dice" },
        { 10, "D10 Dice" },
        { 12, "D12 Dice" },
        { 20, "D20 Dice" }
    };

        public void RollDice()
        {
            Console.WriteLine("Available dice types:");
            foreach (var dice in diceTypes)
            {
                Console.WriteLine($"{dice.Key}-sided: {dice.Value}");
            }

            Console.Write("Choose a dice (Enter the number of sides): ");
            if (int.TryParse(Console.ReadLine(), out int sideCount) && diceTypes.ContainsKey(sideCount))
            {
                Console.WriteLine($"{diceTypes[sideCount]} selected.");
                Console.WriteLine("Rolling the dice...");

                Random random = new Random();
                int result = random.Next(1, sideCount + 1);
                Console.WriteLine($"Dice result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid choice! The program is terminating.");
            }
        }
    }
}