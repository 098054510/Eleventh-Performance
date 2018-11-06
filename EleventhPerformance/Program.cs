using System;
using System.Globalization;

namespace EleventhPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            double batT, jogT, tempoT;
            int vezes;

            tempoT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vezes = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            batT = tempoT;
            for(int i=0; i<vezes; i++)
            {
                jogT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                batT = batT - jogT;
                if(batT < 0.0)
                {
                    Console.WriteLine("RELOAD!");
                }
                else
                {
                    Console.WriteLine(batT);
                }
            }
            Console.ReadLine();
        }
    }
}
