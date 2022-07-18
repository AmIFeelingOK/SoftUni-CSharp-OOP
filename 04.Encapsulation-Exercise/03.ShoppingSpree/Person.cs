using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    internal class Person
    {
        private string name;
        private decimal money;
        public Person(string name, decimal money)
        {
            this.Products = new List<string>();
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");

                this.money = value;
            }
        }

        public List<string> Products { get; set; }

        public void Add(string product)
        {
            this.Products.Add(product);
        }
    }
}
