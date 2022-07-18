using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                List<Person> people = new List<Person>();

                for (int i = 0; i < peopleInfo.Length; i++)
                {
                    string[] personInfo = peopleInfo[i].Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);

                    Person person = new Person(name, money);
                    people.Add(person);
                }

                string[] productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                List<Product> products = new List<Product>();

                for (int i = 0; i < productInfo.Length; i++)
                {
                    string[] productLine = productInfo[i].Split('=');
                    string name = productLine[0];
                    decimal cost = decimal.Parse(productLine[1]);

                    Product product = new Product(name, cost);
                    products.Add(product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] purchaseInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personsName = purchaseInfo[0];
                    string productsName = purchaseInfo[1];

                    Person requiredPerson = people.FirstOrDefault(x => x.Name == personsName);
                    Product requiredProduct = products.FirstOrDefault(x => x.Name == productsName);

                    if (requiredPerson.Money >= requiredProduct.Cost)
                    {
                        requiredPerson.Money -= requiredProduct.Cost;
                        requiredPerson.Add(requiredProduct.Name);
                        Console.WriteLine($"{requiredPerson.Name} bought {requiredProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{requiredPerson.Name} can't afford {requiredProduct.Name}");
                    }


                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    if (person.Products.Count > 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
