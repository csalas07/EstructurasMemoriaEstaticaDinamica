using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Mbusquedas
{
    class BusquedaBinaria
    {
        internal static void Bbinaria(string rutaArchivo, int valorBuscado)
        {
            
            int[] datos = Array.ConvertAll(File.ReadAllLines(rutaArchivo), int.Parse);
            int inicio = 0;
            int fin = datos.Length-1;
            int indiceEncontrado = -1;

            Array.Sort(datos);
            Console.WriteLine($"Vamos a buscar el numero: {valorBuscado}");

            Stopwatch cronometro = Stopwatch.StartNew();

            while(inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if(datos[medio] == valorBuscado)
                {
                    indiceEncontrado = medio;
                    break;
                }

                if(datos[medio] < valorBuscado)
                {
                    inicio = medio + 1; //Descarte la mitad izquierda
                }
                else
                {
                    fin = medio - 1; //Descarte la mitad derecha
                }
            }

            cronometro.Stop();

            if(indiceEncontrado != -1)
            {
                Console.WriteLine($"Encontramos a {valorBuscado} en la posición {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("No encontramos nada :c");
            }

            Console.WriteLine($"Tiempo trasncurrido: {cronometro.ElapsedMilliseconds} ms \n");



        }
    }
}
