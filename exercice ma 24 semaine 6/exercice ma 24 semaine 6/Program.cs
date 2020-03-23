using System;

namespace exercice_ma_24_semaine_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const int nombreDeCase = 6;
            //int test = 2;
            int[] testTableau = {12, 56, 2, 4, 5, 99};
            for(int i = 0; i < nombreDeCase; i++)
            {
                Console.WriteLine(testTableau[i].ToString());
            }
        }
    }
}
