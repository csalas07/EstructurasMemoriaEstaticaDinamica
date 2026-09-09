using System;
using System.Collections.Generic;
using System.Linq;

namespace listas_01
{
    class Program
    {
        // Definición de la clase que representará los elementos de una lista
        public class Producto
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
        }
        static void Main(string[] args)
        {
            //1 - Declaración e inicialización de la lista
            List<Producto> inventario = new List<Producto>()
            {
                new Producto {Nombre = "Laptop Gamer", Categoria="Electronica", Precio = 35000, Stock= 5 },
                new Producto {Nombre = "Mouse Inalambrico", Categoria="Electronica", Precio = 1200, Stock= 30 },
                new Producto {Nombre = "Silla Ergonomica", Categoria="Muebles", Precio = 3500, Stock= 10 },
                new Producto {Nombre = "Teclado Mecanico", Categoria="Electronica", Precio = 1900, Stock= 15 },
                new Producto {Nombre = "Escritorio Minimalista", Categoria="Muebles", Precio = 7500, Stock= 4 }
            };
            string productoBuscado;
            Producto productoEncontrado;

            Console.WriteLine("=== Inventario General ===");
            MostrarInventario(inventario);


            //2 - Filtrado Avanzado Utilizando la libreria LINQ Y funciones Lambda
            //Buscamos productos de alguna categoria (Electronica o Muebles u otros...)

            Console.WriteLine("\n=== Filtrado: Electronica con stock <20 ===");
            var electronicaEscasa = inventario
                .Where(p => p.Categoria == "Electronica" && p.Stock < 20).ToList();

            MostrarInventario(electronicaEscasa);
            //3 - Ordenamiento y Proyeccion
            // Ordenamos los productos de mayor a menor precio
            Console.WriteLine("\n=== Ordenamiento por Precio (Más Caro a más Barato) ===");

            var productosOrdenados = inventario
                .OrderByDescending(p => p.Precio)
                .Select(p => new { p.Nombre, PrecioFormateado = $"${p.Precio:F2}" }).ToList();
            
            MostrarPOrdenado(productosOrdenados);

            //4- Busqueda y Modificación de un elemento
            Console.WriteLine("\n=== Actualización de  Stock ===");
            productoBuscado = "Mouse Inalambrico";
            productoEncontrado = inventario.Find(p => p.Nombre == productoBuscado);

            if (productoEncontrado != null)
            {
                productoEncontrado.Stock += 15; //Incrementamos el stock
                Console.WriteLine($"¡Stock actualizado!, " +
                    $"ahora {productoEncontrado.Nombre} tiene {productoEncontrado.Stock} unidades");
            }
            else
            {
                Console.WriteLine($"No encontramos información sobre {productoBuscado} :C");
            }

            Console.ReadKey();
        }


        static void MostrarInventario(List<Producto> lista)
        {
            foreach(var p in lista)
            {
                Console.WriteLine($"[Categoria: {p.Categoria}] {p.Nombre} " +
                    $"| Precio: ${p.Precio} | Stock: {p.Stock}");
            }
        }

        static void MostrarPOrdenado(IEnumerable<dynamic> lista)
        {
            foreach(var p in lista)
            {
                Console.WriteLine($"{p.Nombre}: {p.PrecioFormateado}");
            }
        }

    }
}
