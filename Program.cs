using System;

namespace SQLite
{
    class Program
    {
        static DatabaseContext _context = new DatabaseContext();

        static void Main(string[] args)
        {
            Console.WriteLine("Topiaksen SQLite testi");
            Console.WriteLine("1. Näytä rivit");
            Console.WriteLine("2. Uusi rivi");
            int.TryParse(Console.ReadLine(), out int valinta);

            switch (valinta)
            {
                default:
                    Console.Clear();
                    Main(args);
                    break;
                case 1:
                    foreach (Testi item in _context.Testi)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("Tyhjennetään 10 sekunnin kuluttua..");
                    System.Threading.Thread.Sleep(10000);
                    Console.Clear();
                    Main(args);
                    break;
                case 2:
                    Console.Write("Riviteksti: ");
                    var teksti = Console.ReadLine();
                    Testi uus = new Testi();
                    uus.Name = teksti;
                    _context.Testi.Add(uus);
                    _context.SaveChanges();
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
    }
}
