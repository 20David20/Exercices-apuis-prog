using System;

namespace enumération
{
    class Program
    {
        static void Main(string[] args)
        {
            mains monDoigt;
            monDoigt = mains.index;
            int valeurDeMonDoigt = (int)monDoigt;
            mains autreDoigt = (mains)3;


            Console.WriteLine(autreDoigt);
        }
    }
}
