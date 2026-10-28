using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Graph<T> where T : notnull
    {
        private readonly Dictionary<T, List<T>> adjacencyList = new();
        //Añadimos las ariastas al grafo
        public void AddEdge(T u, T v)
        {
            if (!adjacencyList.ContainsKey(u))
            {
                adjacencyList[u] = new List<T>();
            }
            adjacencyList[u].Add(v);
        }

        public void DfsRecursivo(T startNode)
        {
            var visited = new HashSet<T>();
            Console.WriteLine($"-------Recursivo :b--- iniciamos en {startNode}");
            DfsRecursiveInternal(startNode, visited);
            Console.WriteLine();
        }

        private void DfsRecursiveInternal(T currentNode, HashSet<T> visited)
        {
            visited.Add(currentNode);
            Console.WriteLine($"{currentNode}");
            if (adjacencyList.ContainsKey(currentNode))
            {
                foreach(var veci in adjacencyList[currentNode])
                {
                    if (!visited.Contains(veci))
                    {
                        DfsRecursiveInternal(veci, visited);
                    }
                }
            }
        }
    }

    /*class DfsG
    {
        //Aqui iria algo :b
    }*/
}
