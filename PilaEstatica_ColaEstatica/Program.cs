using System;

namespace Pilas_Colas_Est
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pilas();
            Colas();
            Console.ReadKey();
        }

        static void Pilas()
        {
            Console.WriteLine("Pilas Estaticas");
            PilasEstaticas miPila = new PilasEstaticas(5);

            miPila.Push(10);
            miPila.Push(20);
            miPila.Push(30);
            miPila.Push(40);
            miPila.Push(50);

            miPila.Mostrar();

            Console.WriteLine($"Elemento Tope (Peek): {miPila.Peek()}");

            Console.WriteLine($"Despilando elementos {miPila.Pop()}");
            Console.WriteLine($"Despilando elementos {miPila.Pop()}");
            Console.WriteLine($"Despilando elementos {miPila.Pop()}");

            miPila.Mostrar();

            Console.WriteLine($"Despilando elementos {miPila.Pop()}");
            Console.WriteLine($"Despilando elementos {miPila.Pop()}");

            miPila.Mostrar();

            Console.WriteLine($"Despilando elementos {miPila.Pop()}");
        }

        static void Colas()
        {
            ColasEstaticas miCola = new ColasEstaticas(4);

            miCola.Enqueue(100);
            miCola.Enqueue(200);
            miCola.Enqueue(300);

            miCola.Shows();

            Console.WriteLine($"Atendiendo al elemento del frente {miCola.Dequeue()}");

            miCola.Shows();

            miCola.Enqueue(400);
            miCola.Enqueue(500);

            miCola.Shows();

            Console.WriteLine($"Elemento del frente de la cola: {miCola.Peek()}");

        }
    }
}
