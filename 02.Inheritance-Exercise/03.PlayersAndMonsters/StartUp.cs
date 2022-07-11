using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BladeKnight bKnight = new BladeKnight("Knighty", 99);
            Console.WriteLine(bKnight);
        }
    }
}
