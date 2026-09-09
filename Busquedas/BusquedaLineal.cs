using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Mbusquedas
{
    class BusquedaLineal
    {
        internal static void Blineal(string rutaArchivo, int ValorBuscado)
        {
            ///string[] lineas = File.ReadAllLines(rutaArchivo);
            //int[] datos = Array.ConvertAll(lineas, int.Parse);
            int indiceEncontrado = -1, i=0;
            int[] datos = Array.ConvertAll(File.ReadAllLines(rutaArchivo), int.Parse);
            Console.WriteLine($"Vamos a buscar el numero: {ValorBuscado}");

            Stopwatch cronometro = Stopwatch.StartNew();

            for(i=0; i < datos.Length; i++)
            {
                if(datos[i] == ValorBuscado)
                {
                    indiceEncontrado = i;
                    break;
                }
            }
            cronometro.Stop();

            if(indiceEncontrado != -1)
            {
                Console.WriteLine($"Encontramos el valor {ValorBuscado}, " +
                    $"se encuentra en el indice {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("No encontramos el elemento");
            }

            Console.WriteLine($"Tiempor transcurrido: {cronometro.ElapsedMilliseconds} ms\n");
        }
    }
}
