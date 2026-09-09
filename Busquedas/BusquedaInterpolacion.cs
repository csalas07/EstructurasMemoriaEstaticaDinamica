using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Mbusquedas
{
    class BusquedaInterpolacion
    {
        internal static void Binterpolacion(List<Pokemon> lista, int idBuscado)
        {
            //Ordenamos la lista
            Pokemon[] datos = lista.OrderBy(p => p.Id).ToArray();
            int inicio = 0;
            int fin = datos.Length - 1;
            int indiceEncontrado = -1;
            int pos;
            Console.WriteLine($"Vamos a buscar el ID {idBuscado}");

            Stopwatch cronometro = Stopwatch.StartNew();

            while(inicio <= fin && idBuscado >= datos[inicio].Id && idBuscado<= datos[fin].Id)
            {
                //Formula de la posición estimada
                pos = inicio + (int)(((double)(fin - inicio) / (datos[fin].Id - datos[inicio].Id)) *
                    (idBuscado - datos[inicio].Id));

                if (datos[pos].Id == idBuscado)
                {
                    indiceEncontrado = pos;
                    break;
                }

                if(datos[pos].Id < idBuscado)
                {
                    inicio = pos + 1;
                }
                else
                {
                    fin = pos - 1;
                }
            }
            cronometro.Stop();

            if(indiceEncontrado != 1)
            {
                Pokemon p = datos[indiceEncontrado];
                Console.WriteLine($"Encontramos a {p.Name} (Tipo: {p.Type})" +
                    $"en la posición {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("No encontramos nada :c");
            }

            Console.WriteLine($"Tiempo transcurrido: {cronometro.ElapsedMilliseconds} ms\n");
        }
    }
}
