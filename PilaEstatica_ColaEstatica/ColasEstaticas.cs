using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Colas_Est
{
    class ColasEstaticas
    {
        private int[] arreglo;
        private int frente;
        private int fin;
        private int capacidad;
        private int longitud;

        public ColasEstaticas(int capacidad)
        {
            this.capacidad = capacidad;
            arreglo = new int[capacidad];
            frente = 0;
            fin = -1;
            longitud = 0;
        }

        //Insertar un elemento al final de la cola
        public void Enqueue(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("La cola esta llena [Peligro de desbordamiento]");
                return;
            }
            //Modulo para hacer la estructura circular
            fin = (fin + 1) % capacidad;
            arreglo[fin] = valor;
            longitud++;
            Console.WriteLine($"Encolado: {valor}");
        }
        //Elimna elementos del frente de la cola
        public int Dequeue()
        {
            int valorEliminado;
            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia [Peligro de subdesbordamiento]");
                return -1;
            }
            valorEliminado = arreglo[frente];
            frente = (frente + 1) % capacidad;
            longitud--;
            return valorEliminado;
        }
        //Mostramos el elemento al frente de la cola sin retirar
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola esta vacia");
                return -1;
            }
            return arreglo[frente];
        }

        //Mostramos el contenido actual de la cola en orden de salida
        public void Shows()
        {
            int i = 0;
            int indice;
            if (IsEmpty())
            {
                Console.WriteLine("Cola vacia :c");
                return;
            }
            for(i=0; i < longitud; i++)
            {
                indice = (frente + i) % capacidad;
                Console.WriteLine($"[{arreglo[indice]}]");
            }
            Console.WriteLine("\n");
        }

        //Verificamos si la cola esta vacia
        public bool IsEmpty()
        {
            return longitud == 0;
        }
        //Verificamos si la cola esta llena
        public bool IsFull()
        {
            return longitud == capacidad;
        }
    }
}
