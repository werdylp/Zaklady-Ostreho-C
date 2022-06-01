using System;
using System.Runtime.InteropServices;

namespace hvezdicky
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int cislo = 5;
            for (int i = 1; i <= cislo; i++)
            {
                
                for (int j = 1; j <= cislo-i; j++) //vypise se zbyvajici pocet mezer (od zadaneho cisla "cislo" se odecte pocet vypsanych hvezdicek)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*"); //vypise se pozadovany pocet hvezdicek; kazde kolo jedna pribude 
                }
                Console.WriteLine(); //po ukonceni kazdeho kola se zalomi radek, aby se hvezdicky nevypisovaly do rady
            }

            Console.ReadKey(); //podrzi konzoli
        }
    }
}
