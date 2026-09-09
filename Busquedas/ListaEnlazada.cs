using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Mbusquedas
{
    class Nodo
    {
        public Pokemon Valor;
        public Nodo Siguiente;

        public Nodo(Pokemon Valor)
        {
            Valor = Valor;
            Siguiente = null;
        }
    }
    class ListaEnlazada
    {
        internal static void BlistaEnlazada(List<Pokemon> lista, string nombreBuscado)
        {
            Nodo cabeza = null;
            Nodo ultimo = null;
            
            foreach(var pokemon in lista)
            {
                Nodo nuevoNodo = new Nodo(pokemon);
                if(cabeza == null)
                {
                    cabeza = nuevoNodo;
                    ultimo = nuevoNodo;
                }
                else
                {
                    ultimo.Siguiente = nuevoNodo;
                    ultimo = nuevoNodo;
                }
            }

            Nodo Actual = cabeza;
            int posicion = 0;
            int indiceEncontrado = -1;
            Pokemon pokemonEncontrado = null;

            Console.WriteLine($"Buscando a {nombreBuscado}");
            Stopwatch cronometro = Stopwatch.StartNew();
            while(Actual != null)
            {
                if (Actual.Valor.Name.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    indiceEncontrado = posicion;
                    pokemonEncontrado = Actual.Valor;
                }
                Actual = Actual.Siguiente;
                posicion++;
            }

            cronometro.Stop();
            if (indiceEncontrado != 1)
            {
                Console.WriteLine($"Encontramos a {pokemonEncontrado.Name} " +
                    $"(Id: {pokemonEncontrado.Id}) " +
                    $"Tipo: {pokemonEncontrado.Type}"+
                    $"en el nodo {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("No encontramos nada :c");
            }

            Console.WriteLine($"Tiempo transcurrido: {cronometro.ElapsedMilliseconds} ms\n");
        }
    }
}
