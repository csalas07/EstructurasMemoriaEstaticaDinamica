using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoEstatico
{
    class GrafosEstaticos
    {
        public class GrafoEstaticos{
            private readonly int _maxVertices;
            private readonly int[,] _adjacencyMatrix; //Memoria estatica

            public GrafoEstaticos(int maxVertices)
            {
                _maxVertices = maxVertices;
                _adjacencyMatrix = new int[maxVertices, maxVertices]; //Asignamos la memoria
            }

            //Metodo para conectar dos nodos
            public void AddEdge(int source, int destination)
            {
                if (IsValidVertex(source)){
                    _adjacencyMatrix[source, destination] = 1; //Indicamos que hay una arista
                }
                else
                {
                    Console.WriteLine("Error: Indice del vertice fuera de los limites");
                }
            }

            public void PrintGraph()
            {
                int i, j;

                Console.WriteLine($"Matriz de adyacencia {_maxVertices}x{_maxVertices}");
                
                for(i=0; i < _maxVertices; i++)
                {
                    Console.Write($"   [{i}] ");
                }
                Console.WriteLine();

                for (i = 0; i < _maxVertices; i++)
                {
                    Console.Write($"[{i}] ");
                    for(j=0; j < _maxVertices; j++)
                    {
                        Console.Write($"{_adjacencyMatrix[i, j]}      ");
                    }

                    Console.WriteLine();
                }
            }

            bool IsValidVertex(int v)
            {
                return v >= 0 && v < _maxVertices;
            }
        }
    }
}
