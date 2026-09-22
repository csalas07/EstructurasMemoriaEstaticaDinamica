using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Colas_Est
{
    class PilasEstaticas
    {
        private int[] arreglo;
        private int tope;
        private int capacidad;

        public PilasEstaticas(int capacidad)
        {
            this.capacidad = capacidad;
            arreglo = new int[capacidad];
            tope = -1;
        }

        //Insertar un elemento en la pila
        public void Push(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("La pilas esta llena [Peligro de desbordamiento]");
                return;
            }
            tope++;
            arreglo[tope] = valor;
            Console.WriteLine($"Apilado: {valor}");
        }

        //Remover elementos de la pila
        public int Pop()
        {
            int valorEliminado;

            if (IsEmpty())
            {
                Console.WriteLine("La pila esta vacia [Peligro de subdesbordamiento]");
                return -1;
            }
            valorEliminado = arreglo[tope];
            tope--;
            return valorEliminado;
        }

        //Mostrar el contenido actual de la pila
        public void Mostrar()
        {
            int i = 0;
            if (IsEmpty())
            {
                Console.WriteLine("Pila Vacia");
                return;
            }

            Console.WriteLine("\nEstado de la pila");
            for (i = tope; i >= 0; i--)
            {
                Console.WriteLine($"|{arreglo[i]}|");
            }
            Console.WriteLine("-------------------\n");
        }

        //Ver el elemento tope de la pila sin retirarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La pila esta vacia");
                return -1;
            }
            return arreglo[tope];
        }

        //Vericar si la pila esta vacia
        public bool IsEmpty()
        {
            return tope == -1;
        }

        //Verificar si la pila esta llena
        public bool IsFull()
        {
            return tope == capacidad - 1;
        }

    }
}
