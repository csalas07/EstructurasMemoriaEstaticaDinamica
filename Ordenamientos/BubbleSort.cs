using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ordenamientos
{
    class BubbleSort
    {
        internal static void Bsort(string archivo)
        {
            int[] datos = File.ReadAllLines(archivo)
                .Where(line => int.TryParse(line.Trim(), out _))
                .Select(int.Parse)
                .ToArray();
            int i = 0, j=0;
            int n = datos.Length;
            bool cambiado = false;
            int temp;

            Console.WriteLine($"Total de elementos {n}");
            Console.WriteLine("Primeros 10 elementos antes del ordenamiento");
            FunctionsD.ImprimirArreglo(datos, 10);

            Stopwatch sw = Stopwatch.StartNew();
            
            for(i=0; i<n-1; i++)
            {
                cambiado = false;
                for(j=0; j<n-i-1; j++)
                {
                    if(datos[j] > datos[j + 1])
                    {
                        temp = datos[j];
                        datos[j] = datos[j + 1];
                        datos[j + 1] = temp;
                        cambiado = true;
                    }
                }
                //Si ya no hay cambios el arreglo se ordeno
                if (!cambiado) break;
            }

            sw.Stop();
            Console.WriteLine("Primeros 10 elementos despues del cambio");
            FunctionsD.ImprimirArreglo(datos, 10);
            Console.WriteLine($"Tiempo de ejecución {sw.Elapsed.TotalSeconds:F6} segundos\n");





        }
    }
}
