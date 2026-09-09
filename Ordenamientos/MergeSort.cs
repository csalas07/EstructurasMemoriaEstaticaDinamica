using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Ordenamientos
{
    class MergeSort
    {
        internal static void Msort(string archivo)
        {
            int[] datos = File.ReadAllLines(archivo)
                .Where(line => int.TryParse(line.Trim(), out _))
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine($"Total de elementos cargados: {datos.Length}");

            Console.WriteLine("\nPrimeros 10 elementos ANTES de ordenar:");
            FunctionsD.ImprimirArreglo(datos, 10);

            Stopwatch sw = Stopwatch.StartNew();

            // Algoritmo Merge Sort Iterativo (Bottom-Up)
            IterativeMergeSort(datos);

            sw.Stop();

            Console.WriteLine("\nPrimeros 10 elementos DESPUÉS de ordenar (Merge Sort):");
            FunctionsD.ImprimirArreglo(datos,10);

            Console.WriteLine($"\nTiempo Merge Sort: {sw.Elapsed.TotalSeconds:F6} segundos");
        }

        private static void IterativeMergeSort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];

            // currSize representa el tamaño de las sublistas a mezclar (1, 2, 4, 8, ...)
            for (int currSize = 1; currSize < n; currSize = 2 * currSize)
            {
                for (int leftStart = 0; leftStart < n - 1; leftStart += 2 * currSize)
                {
                    int mid = Math.Min(leftStart + currSize - 1, n - 1);
                    int rightEnd = Math.Min(leftStart + 2 * currSize - 1, n - 1);

                    Merge(arr, temp, leftStart, mid, rightEnd);
                }
            }
        }

       private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (i = left; i <= right; i++)
            {
                arr[i] = temp[i];
            }
        }
    }
}
