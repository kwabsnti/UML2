using System;

namespace UML_2
{
	public class Pizza
	{
        public Pizza()
        {
        }

        public Pizza(string v, List<string> list)
        {
        }

        public int number { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

        public override string ToString()
        {
            return $"Id: {number}, Name: {Name}, Price: {Price}";
        }
    }
	
}

