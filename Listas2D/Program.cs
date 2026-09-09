using System;
using System.Collections.Generic;
using System.Linq;
namespace listas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Iniciamos una lista 2D dinamica con strings
            //O = Disponible y X = Ocupado

            List<List<string>> salaCine = new List<List<string>>()
            {
                new List<string> {"O", "O", "X", "O", "O"},
                new List<string> {"O", "X", "X", "O", "O"},
                new List<string> {"O", "O", "O", "O", "X"},
                new List<string> {"X", "X", "O", "O", "O"},
            };
            int filaReserva = 0, asientoReserva = 0;

            Console.WriteLine("=== Estado del cine ===");
            MostarSala(salaCine);

            Console.WriteLine($"Vamos a reservar un asiento en la fila [{filaReserva + 1}, " +
                $"Asiento {asientoReserva + 1}]");

            //Función de validación
            if(ValidarCoordenadas(salaCine, filaReserva, asientoReserva))
            {
                if(salaCine[filaReserva][asientoReserva] == "O")
                {
                    salaCine[filaReserva][asientoReserva] = "X";
                    Console.WriteLine("¡Reserva Exitosa!");
                }
                else
                {
                    Console.WriteLine("El asiento esta reservado");
                }
            }
            else
            {
                Console.WriteLine("Coordenadas invalidas :c");
            }

            Console.WriteLine("=== Estado Actual de la sala ===");
            MostarSala(salaCine);
            int TotalLibres, TotalApartados;
            TotalLibres = salaCine.SelectMany(fila => fila).Count(asiento => asiento == "O");
            TotalApartados = salaCine.SelectMany(fila => fila).Count(asiento => asiento == "X");

            Console.WriteLine("=== Estadisticas de la sala ===");
            Console.WriteLine($"Total Asientos libres: {TotalLibres}");
            Console.WriteLine($"Total Asientos Apartados: {TotalApartados}");
            Console.ReadKey();
        }

        //Función para recorrer Listas

        static void MostarSala(List<List<string>> matriz)
        {
            int i = 0, j = 0;

            for(i=0; i<matriz.Count; i++)
            {
                Console.Write($"Fila {i + 1}:    \n");
                for (j = 0; j < matriz[i].Count; j++)
                {
                    Console.WriteLine($"[{matriz[i][j]}] ");
                }
                Console.WriteLine();
          
            }
        }

        //Validación de coordenadas
        static bool ValidarCoordenadas(List<List<string>> lista, int fila, int columna)
        {
            return fila >= 0 && fila < lista.Count && columna >= 0 && columna < lista[fila].Count;
        }
    }
}
