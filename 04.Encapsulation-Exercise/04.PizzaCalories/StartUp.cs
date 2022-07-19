using System;

namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaInfo[1]);

                string[] doughInfo = Console.ReadLine().Split();
                Dough dough = new Dough(doughInfo[1].ToLower(), doughInfo[2].ToLower(), double.Parse(doughInfo[3]));

                pizza.PizzaDough = dough;

                string toppingInfo;

                while ((toppingInfo = Console.ReadLine()) != "END")
                {

                    string[] toppingParams = toppingInfo.Split();

                    string toppingName = toppingParams[1].ToLower();
                    double toppingWeight = double.Parse(toppingParams[2]);
                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.Add(topping);

                }

                Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories():f2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

