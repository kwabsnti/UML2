using System;
using System.Collections.Generic;
namespace UML_2
{
	public class MenuCatalog
	{
		List<Pizza> _Pizzas;
		public MenuCatalog()
		{
			_Pizzas = new List<Pizza>();
		}

		public object PizzaToDelete { get; private set; }

		public void Create(Pizza p)
		{
			_Pizzas.Add(p);
		}

        public void Update(Pizza pizza, Pizza pizza1, Pizza pizza11)
        {
            foreach (var p in _Pizzas)
            {
                if (p.number == pizza.number)
                {
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                    return;
                }
            } 
        }

        public void DeletePizza(int pizzaNumber, int PizzaNumber)
		{
			Pizza pizzaToDelete = _Pizzas.Find(p => p.number == PizzaNumber);
			if (PizzaToDelete != null)
			{
				_Pizzas.Remove((Pizza)PizzaToDelete);
				Console.WriteLine("Pizza with number {pizzaNumber} deleted succesfully");
			}
			else
			{
				Console.WriteLine("Pizza with number{pizzaNumber} not found");
			}
		}
		public void PrintMenu()
		{
			foreach (Pizza p in _Pizzas)
			{
				Console.WriteLine(p);
			}
		}
		public void DeletePizza( Pizza pizza)
		{
			if (pizza.number <=0)
			{
				throw new FormatException("No Number");
			}
			foreach (Pizza i in _Pizzas)
			{
				if (i.number == pizza.number)
				{
                    pizza = i;
                }
			}
			if ((pizza.Name == null) || (pizza.Name.Trim().Length <= 0)) { throw new FormatException("pizza number was not found"); }

			_Pizzas.Remove(pizza);

			
		}

        internal static object GetPizza()
        {
            throw new NotImplementedException();
        }
    }
}

