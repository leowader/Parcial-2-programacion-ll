using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCategoria:Archivos
    {
        public RepositorioCategoria()
        {
            ruta = "categorias.txt";
        }
        public List<Categoria> Leer()
        {
            try
            {
                List<Categoria> ListCategoria = new List<Categoria>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListCategoria.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListCategoria;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
        public Categoria Mapear(string linea)
        {
            var categoria = new Categoria
            {
                
                IdCategoria = int.Parse(linea.Split(';')[0]),
                nombreCategoria=linea.Split(';')[1],
            };
            return categoria;
        }
    }
}
