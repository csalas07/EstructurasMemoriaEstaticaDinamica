using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph<string>();

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("B", "E");
            graph.AddEdge("C", "F");
            graph.AddEdge("C", "G");

            graph.DfsRecursivo("A");
            Console.ReadKey();

            //Adaptar el codigo a un archivo de texto con los nodos y
            //Buscar un nodo de la lista de relaciones, al encontrarlo 
            //lanzara un mensaje de "Nodo: " + Nodo + "Encontrado", 
            //sino un mensaje como "No encontramos el nodo seleccionado"
        }
    }
}
