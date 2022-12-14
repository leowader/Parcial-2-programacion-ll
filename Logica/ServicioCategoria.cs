using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logica
{
    public class ServicioCategoria
    {
        List<Categoria> ListaCategoria;
        Datos.RepositorioCategoria RepositorioCategoria = new Datos.RepositorioCategoria();
        public ServicioCategoria()
        {
            ListaCategoria = RepositorioCategoria.Leer();
        }
        public List<Categoria> Mostrar()
        {
            return ListaCategoria;
        }
        public Categoria buscar(string nombre)
        {
            var categoria = new Categoria();
            foreach (var item in RepositorioCategoria.Leer())
            {
                if (item.nombreCategoria.Equals(nombre))
                {
                    categoria = item;
                }
            }
            return categoria;
        }
    }
}
