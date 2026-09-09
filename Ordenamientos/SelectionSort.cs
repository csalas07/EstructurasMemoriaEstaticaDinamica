using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Ordenamientos
{
    class SelectionSort
    {
        internal static void Ssort(string archivo)
        {
            int[] datos = File.ReadAllLines(archivo)
                .Where(line => int.TryParse(line.Trim(), out _))
                .Select(int.Parse)
                .ToArray();
            int n = datos.Length;
            int minIndex;
            int temp;
            int i = 0, j = 0;

            Console.WriteLine($"Se han cargado {n} elementos");


            Console.WriteLine("\nPrimeros 10 elementos antes del cambio");
            FunctionsD.ImprimirArreglo(datos,10);

            Stopwatch sw = Stopwatch.StartNew();

            for(i=0; i < n - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                {
                    if (datos[j] < datos[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if(minIndex != i)
                {
                    temp = datos[minIndex];
                    datos[minIndex] = datos[i];
                    datos[i] = temp;
                }
            }

            sw.Stop();

            Console.WriteLine("\nPrimeros 10 elementos despues del ordenamiento");
            FunctionsD.ImprimirArreglo(datos, 10);

            Console.WriteLine($"\nTiempo de ejecución {sw.Elapsed.TotalSeconds:F6} segundos");
        }
    }
}
