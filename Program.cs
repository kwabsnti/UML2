namespace UML_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.Write("Hit any key to continue with user dialog");
            Console.ReadKey();
            store.Test();

            store.Run();

        }
    }
}