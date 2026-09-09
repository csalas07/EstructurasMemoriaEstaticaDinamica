using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mbusquedas
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    class CargadorPokemon
    {
        internal static List<Pokemon> CargarDesdeCsv(string rutaArchivo)
        {
            List<Pokemon> lista = new List<Pokemon>();

            // Leemos todas las líneas y saltamos la fila de encabezados
            string[] lineas = File.ReadAllLines(rutaArchivo).Skip(1).ToArray();

            foreach (string linea in lineas)
            {
                string[] columnas = linea.Split(',');
                if (columnas.Length >= 3)
                {
                    lista.Add(new Pokemon
                    {
                        Id = int.Parse(columnas[0]),
                        Name = columnas[1],
                        Type = columnas[2]
                    });
                }
            }

            return lista;
        }
    }
}
