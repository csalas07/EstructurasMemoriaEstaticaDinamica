using System;

namespace GrafoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            GrafosEstaticos.GrafoEstaticos grafo = new GrafosEstaticos.GrafoEstaticos(4);

            grafo.AddEdge(0, 1);
            grafo.AddEdge(0, 2);
            grafo.AddEdge(1, 3);
            grafo.AddEdge(2, 3);

            grafo.PrintGraph();

            Console.ReadKey();
        }
    }
}
