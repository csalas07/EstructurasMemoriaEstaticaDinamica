using System;
using System.IO;
using Ordenamientos;

namespace Ordenamientos
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaDatos = "datos.txt";

            if (File.Exists(rutaDatos))
            {
                Console.WriteLine("Procedemos a Leer");

                Console.WriteLine("Ordenamiento Burbuja");
                BubbleSort.Bsort(rutaDatos);

                Console.WriteLine("Ordenamiento Selection Sort");
                SelectionSort.Ssort(rutaDatos);

                Console.WriteLine("Insertion Sort");
                InsertionSort.Isort(rutaDatos);

                Console.WriteLine("Quick Sort");
                QuickSort.Qsort(rutaDatos);

                Console.WriteLine("Merge Sort");
                MergeSort.Msort(rutaDatos);
            }


            Console.ReadKey();
        }
    }
}
