using System;

namespace D5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("zadej číslo, od kterého má řada začínat: ");
            int zacatek = int.Parse(Console.ReadLine());
            
            Console.Write("zadej číslo, kterým má řada končit: ");
            int konec = int.Parse(Console.ReadLine());

            for (int i = zacatek; i <= konec; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}