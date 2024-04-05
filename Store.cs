using System;
namespace UML_2
{
	public class Store
	{
		MenuCatalog menuCatalog;

		public Store()
		{
			menuCatalog = new MenuCatalog();
		}
		public void Test()
		{
           
            Pizza p = new Pizza() { number = 1, Name = "Margherita", Price = 69 };
			menuCatalog.Create(p);

			p =new Pizza() { number = 2, Name = "Vesuvio", Price = 75 };
            menuCatalog.Create(p);

            p = new Pizza() { number = 3, Name = "Capricciosa", Price = 80 };
            menuCatalog.Create(p);

            p = new Pizza() { number = 4, Name = "Calzone", Price = 80 };
            menuCatalog.Create(p);

            menuCatalog.PrintMenu();

        }
		public void Run()
		{
			new UserDialog(menuCatalog).Run();
		}


    }
}

