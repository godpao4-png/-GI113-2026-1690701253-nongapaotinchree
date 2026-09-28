/*
 *Student ID: 1690701253
 * Name       :ungpao
 * Section    :129B
 * No.        :N / A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Healing");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);
            
            int health = command switch
            {
                5=> 10,
                _ => 0
            };
            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0

            };
            int heal = Math.Max(0, health - MonsterHp);
            Console.WriteLine($"Health: {health}");
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");
            
            string rating1 = health switch
            {
                >= 10 => "Refactor HP!",
                _ => "Low health."
            };

            string rating2 = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                >=0 => "Scratch.",
                _ => "No damage."
            };

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
              

            }

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero uses a healing potion.");
                    break;



            }
        }
    }
}
