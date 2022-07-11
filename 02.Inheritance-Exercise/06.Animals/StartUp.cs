using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] animalData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string name = animalData[0];
                    int age = int.Parse(animalData[1]);
                    string gender = animalData[2];

                    Animal animal = null;

                    if (animalType == "Dog")
                    {
                        animal = new Dog(name, age, gender);
                    }
                    else if (animalType == "Frog")
                    {
                        animal = new Frog(name, age, gender);
                    }
                    else if (animalType == "Cat")
                    {
                        animal = new Cat(name, age, gender);
                    }
                    else if (animalType == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (animalType == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }
                    else
                    {
                        throw new InvalidCastException("Invalid input!");
                    }

                    animals.Add(animal);
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }                
            }

            foreach (var a in animals)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
