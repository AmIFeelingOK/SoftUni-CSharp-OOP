using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("One");
            randomList.Add("Two");
            randomList.Add("Three");
            randomList.Add("Four");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomList.RandomString());
            }
        }
    }
}
