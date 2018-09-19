using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05._CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            
            long suma = 0;

            for (int i = 0; i <= 1000000; i++) { suma += i; }

            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("La sumatoria del primer millón de números naturales es de: {0} y el tiempo de ejecución del programa es de: {1} segundos",suma,stop.Subtract(start).TotalSeconds);

            Console.ReadKey();

        }
    }
}
