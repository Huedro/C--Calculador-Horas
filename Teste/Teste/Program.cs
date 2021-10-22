using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {           

            string[] vet = Console.ReadLine().Split(' ');
            int initialHour = int.Parse(vet[0]);
            int finalHour = int.Parse(vet[1]);

            int duration;

            if (initialHour < finalHour)
            {
                duration = finalHour - initialHour;
            }
            else
            {
                duration = 24 - initialHour + finalHour;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duration);

        }
    }
}
