using System;
using System.IO;
using Mbusquedas;
using System.Linq;
using System.Collections.Generic;

namespace Mbusquedas
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "datos.txt";
            int ValoraEncontrar = 54321;
            int cantidadElementos = 10000;

            string rutaPoke = "Pokemon.csv";
            int IdaEncontrar = 25;
            string NombreaEncontrar = "Gengar";
            List<Pokemon> pokemons;

            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("Procedemos a leer");
            }
            else
            {
                generador.crearArchivo(rutaArchivo, cantidadElementos);
            }

            Console.WriteLine("Busqueda Lineal");
            BusquedaLineal.Blineal(rutaArchivo, ValoraEncontrar);

            Console.WriteLine("Busqueda Binaria");
            BusquedaBinaria.Bbinaria(rutaArchivo, ValoraEncontrar);

            Console.WriteLine("Busqueda Por saltos");
            JumpSearch.Jsearch(rutaArchivo, ValoraEncontrar);

            if (File.Exists(rutaPoke))
            {
                Console.WriteLine("Procedemos a leer");
                pokemons = CargadorPokemon.CargarDesdeCsv(rutaPoke);

                Console.WriteLine("Busqueda por interpolacion");
                BusquedaInterpolacion.Binterpolacion(pokemons, IdaEncontrar);

            }
            else
            {
                generador.crearArchivo(rutaArchivo, cantidadElementos);
            }


            Console.ReadKey();
        }
    }
}
