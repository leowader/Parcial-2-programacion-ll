using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioProducto
    {
        List<Producto> ListaProductos;
        Datos.RepositorioProducto RepositorioProducto = new Datos.RepositorioProducto();
        public ServicioProducto()
        {
            ListaProductos = RepositorioProducto.Leer();
        }
        public void ActualizarLit()
        {
            ListaProductos = RepositorioProducto.Leer();
        }
        public string Guardar(Producto producto)
        {
            try
            {
                var estado = RepositorioProducto.Guardar(producto);
                return estado ? $"INFORMACION  GUARDADA" :
                $"ERROR AL GUARDAR LA INFORMACION ";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
        public List<Producto> Mostrar()
        {
            return ListaProductos;
        }
        public List<Producto> BuscarByCategoria(string nombre)
        {
            ActualizarLit();
            var lista = new List<Producto>();
            foreach (var item in ListaProductos)
            {
                if (item.Categorianame.StartsWith(nombre))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
        public List<Producto> BuscarByMes(int mes)
        {
            ActualizarLit();
            var lista = new List<Producto>();
            foreach (var item in ListaProductos)
            {
                int mess=item.FechaVencimiento.Month;
                if (item.FechaVencimiento.Month.Equals(mes))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
    }
}
