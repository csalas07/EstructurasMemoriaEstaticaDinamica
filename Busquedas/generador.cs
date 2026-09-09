using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Mbusquedas
{
    class generador
    {
        internal static void crearArchivo(string rutaArchivo, int cantidad)
        {
            int i = 0;
            Console.WriteLine($"Generando {rutaArchivo} con {cantidad} de elementos");
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                for(i=0; i < cantidad; i++)
                {
                    if(i == 5425)
                    {
                        sw.WriteLine(54321);
                    }
                    else
                    {
                        sw.WriteLine(rnd.Next(1, cantidad));
                    }
                }
            }
            Console.WriteLine("Acabamos de genera nuestro dataset");
        }
    }
}
