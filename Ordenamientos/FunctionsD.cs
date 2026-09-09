using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamientos
{
    class FunctionsD
    {
        internal static void ImprimirArreglo(int [] datos, int limite)
        {
            int i = 0;
            for(i=0; i< limite; i++)
            {
                Console.Write($"{datos[i]},");
            }
            Console.WriteLine();
        }
    }
}
