using System;
using static System.Formats.Asn1.AsnWriter;

namespace UML_2
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Creating Pizza      |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            pizzaItem.Name = Console.ReadLine();

            string input = "";
            Console.Write("Enter price: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter pizza number: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.number = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return pizzaItem;
        }
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("-----------------");
            Console.WriteLine("| Zenji MENU |");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }

        Pizza UpdatePizza()
        {
            Pizza pizzaitem1 = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Updating pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine("enter new pizza name: ");
            pizzaitem1.Name = Console.ReadLine();

            string input = "";
            Console.Write("enter new price: ");
            try
            {
                input = Console.ReadLine();
                pizzaitem1.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"unable to parse {input} - message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("enter new pizza number: ");
            try
            {
                input = Console.ReadLine();
                pizzaitem1.number = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"unable to parse {input} - message {e.Message}");
                throw;
            }
            return pizzaitem1;
        }

        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Create new pizza",
                "2. Print menu",
                "3. Update Pizza",
                "4. Delete Pizza"
               
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:

                        _menuCatalog.PrintMenu();

                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"you selected: {mainMenulist[MenuChoice]}");
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        try
                        {
                            Pizza pizza1 = UpdatePizza2();
                            _menuCatalog.Update(pizza1, pizza1, pizza1);
                            Console.WriteLine($"you have updated: {pizza1}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("no pizza to update");
                        }
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                       
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            Pizza pizza = DeletePizza();
                            _menuCatalog.DeletePizza(pizza);
                            Console.WriteLine($"you have deleted: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("no pizza to delete");
                        }
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                
                }
            }
        }

        private Pizza UpdatePizza2()
        {
            throw new NotImplementedException();
        }

        private Pizza DeletePizza()
        {
            throw new NotImplementedException();
        }
    } }   