using System;

namespace SwordDamageFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                    "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                // if the key is NOT 0, 1, 2 or 3... then return to end program
                if (key != '0' && key != '1' && key != 2 && key != '3') return;
                // roll the dice 3 times and add the results together
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                // if user presses 1 or 3 then set the magic
                swordDamage.SetMagic(key == '1' || key == '3');
                // if the user pressed 2 or 3 then set flaming
                swordDamage.SetFlaming(key == '2' || key == '3');
                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.Damage + " HP\n");
            }
        }
    }
}
