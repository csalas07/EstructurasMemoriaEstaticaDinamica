using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosDinamicos
{
    class Grafodinamico
    {
        private string[] estaciones;
        private int[,] matrizTiempos;
        private int capacidadMaxima;
        private int totalEstaciones;
        private int i, j;
        public Grafodinamico(int capacidad)
        {
            capacidadMaxima = capacidad;
            estaciones = new string[capacidad];
            matrizTiempos = new int[capacidadMaxima, capacidadMaxima];
            totalEstaciones = 0;
        }

        //Añadir Nuevas estaciones
        public void AgregarEstacion(string nombre)
        {
            if(totalEstaciones < capacidadMaxima)
            {
                estaciones[totalEstaciones] = nombre;
                totalEstaciones++;
            }
            else
            {
                Console.WriteLine("La red alcanzo su limite");
            }
        }

        //Obtenemos el indice que se encuentra nuestro tren (la estación)
        private int ObtenerIndice(string nombre)
        {
            for(i=0; i< totalEstaciones; i++)
            {
                if (estaciones[i] == nombre)
                {
                    return i;
                }
            }

            return -1; //No encontramos nada
        }

        public void ConectarRuta(string origen, string destino, int tiempoViaje)
        {
            int idxOrigen = ObtenerIndice(origen);
            int idxdestino = ObtenerIndice(destino);

            if(idxOrigen !=-1 && idxdestino != -1)
            {
                //Se asignamos la ruta en doble sentido
                matrizTiempos[idxOrigen, idxdestino] = tiempoViaje;
                matrizTiempos[idxdestino, idxOrigen] = tiempoViaje;
            }
            else
            {
                Console.WriteLine("No es posible conectarlo, alguna estación no  existe");
            }
        }

        public void MostrarRed()
        {
            Console.WriteLine("\n--- Tabla de tiempos---");
            Console.Write(string.Format("{0,-12}", ""));

            for (i=0; i < totalEstaciones; i++)
            {
                Console.Write(string.Format("{0,-12}", estaciones[i]));
            }
            Console.WriteLine();
            for(i=0; i < totalEstaciones; i++)
            {
                Console.Write(string.Format("{0,-12}", ""));
                for (j=0; j<totalEstaciones; j++)
                {
                    Console.Write(string.Format("{0,-12}", matrizTiempos[i,j]));
                }
                Console.WriteLine();
            }
        }
    }
}