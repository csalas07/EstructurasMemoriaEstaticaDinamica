using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Ordenamientos
{
    class QuickSort
    {
        internal static void Qsort(string archivo)
        {
            int[] datos = File.ReadAllLines(archivo)
                .Where(line => int.TryParse(line.Trim(), out _))
                .Select(int.Parse)
                .ToArray();        

            Console.WriteLine($"Se han cargado {datos.Length} elementos");

            Console.WriteLine("\nPrimeros 10 elementos antes del cambio");
            FunctionsD.ImprimirArreglo(datos, 10);

            Stopwatch sw = Stopwatch.StartNew();

            IterativeQuicksort(datos);

            sw.Stop();

            Console.WriteLine("\nPrimeros 10 elementos despues del ordenamiento");
            FunctionsD.ImprimirArreglo(datos, 10);

            Console.WriteLine($"\nTiempo de ejecución {sw.Elapsed.TotalSeconds:F6} segundos");

        }

        private static void IterativeQuicksort(int[] arr)
        {
            Stack<(int Low, int High)> stack = new Stack<(int, int)>();
            int pi;
            if (arr.Length <= 1) return;
            stack.Push((0, arr.Length - 1));

            while (stack.Count > 0)
            {
                var (low, high) = stack.Pop();

                if (low < high)
                {
                    pi = Partition(arr, low, high);
                    stack.Push((low, pi - 1));
                    stack.Push((pi + 1, high));
                }
            }
        }

        private static int Partition(int []arr, int low, int high)
        {
            int pivot=arr[high];
            int i = low - 1, j = 0;
            int temp, temp1;

            for(j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }



    }
}
