using System;

namespace D6
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            Console.Write("cislo ktere budu umocnovat: ");
            int cislo = Convert.ToInt32(Console.ReadLine());
            int cislo = puvodniCislo;
            
            Console.Write("kolikrat ho mam umocnit");
            int mocnina = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < mocnina; i++)
            { //promenna "cislo" se prepise na nasobek promennych "cislo" a "puvodniCislo". Duvod, proc umocnuji cislo * puvodniCislo je ten, ze by se nenasobila mocnina puvodnim cislem, ale tou samou mocninou, takze 5 na treti by nebylo 5*5*5 ale 5*5*25
                cislo = cislo * puvodniCislo;
            }
            Console.WriteLine(cislo);
            Console.ReadKey();
        }
    }
}
