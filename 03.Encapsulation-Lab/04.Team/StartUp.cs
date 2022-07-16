using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0]
                    , cmdArgs[1]
                    , int.Parse(cmdArgs[2])
                    , decimal.Parse(cmdArgs[3]));

                people.Add(person);
            }
            Team team = new Team("DreamTeam");

            people.ForEach(x => team.AddPlayer(x));
            Console.WriteLine($"First Team: {team.FirstTeam.Count}");
            Console.WriteLine($"Reserve Team: {team.ReserveTeam.Count}");
        }
    }
}
