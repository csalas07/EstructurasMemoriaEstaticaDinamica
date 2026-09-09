using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Mbusquedas
{
    class JumpSearch
    {
        internal static void Jsearch(string rutaArchivo, int valorBuscado)
        {
            int[] datos = Array.ConvertAll(File.ReadAllLines(rutaArchivo), int.Parse);
            int n = datos.Length;
            int saltoslen = (int)Math.Floor(Math.Sqrt(n));
            int inicio = 0;
            int sig = saltoslen;
            int indiceEncontrado = -1;
            int i = 0;
            Array.Sort(datos);
            Stopwatch cronometro = Stopwatch.StartNew();
            while(sig < n && datos[Math.Min(sig, n) - 1] < valorBuscado)
            {
                inicio = sig;
                sig += saltoslen;
                if (inicio >= n)
                {
                    //Console.WriteLine("No encontramos nada :c");
                    break;
                }
            }

            for (i = inicio; i < Math.Min(sig, n); i++)
            {
                if (datos[i] == valorBuscado)
                {
                    indiceEncontrado = i; // ¡Guardamos el índice correcto!
                    break; 
                }
            }
            cronometro.Stop();
            if (indiceEncontrado != -1)
            {
                Console.WriteLine($"Encontramos a {valorBuscado} en la posición {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("No encontramos nada :c");
            }

            Console.WriteLine($"Tiempo transcurrido: {cronometro.ElapsedMilliseconds} ms \n");
        }
    }
}
