using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Ordenamientos
{
    class InsertionSort
    {
        internal static void Isort(string archivo)
        {
            int[] datos = File.ReadAllLines(archivo)
                .Where(line => int.TryParse(line.Trim(), out _))
                .Select(int.Parse)
                .ToArray();

            int n = datos.Length;
            int key;
            int i = 0, j = 0;

            Console.WriteLine($"Se han cargado {n} elementos");

            Console.WriteLine("\nPrimeros 10 elementos antes del cambio");
            FunctionsD.ImprimirArreglo(datos, 10);

            Stopwatch sw = Stopwatch.StartNew();

            for(i=1; i < n; i++)
            {
                key = datos[i];
                j = i - 1;

                while(j>=0 && datos[j] > key)
                {
                    datos[j + 1] = datos[j];
                    j = j - 1;
                }
                datos[j + 1] = key;
            }
            sw.Stop();

            Console.WriteLine("\nPrimeros 10 elementos despues del ordenamiento");
            FunctionsD.ImprimirArreglo(datos, 10);

            Console.WriteLine($"\nTiempo de ejecución {sw.Elapsed.TotalSeconds:F6} segundos");
        }
    }
}
