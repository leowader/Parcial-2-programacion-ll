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
        bool estado1;
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
                var resultado = verificarReferencia(producto.Referencia);
                if (resultado==false)
                {
                    var estado = RepositorioProducto.Guardar(producto);
                    return estado ? $"INFORMACION  GUARDADA {producto.Nombre.ToUpper()}" : 
                        $"ERROR AL GUARDAR LA INFORMACION {producto.Nombre.ToUpper()} ";
                }
                else
                {
                    return $"EL PRODUCTO CON :{producto.Referencia} YA ESTA REGISTRADO";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public bool verificarReferencia(string referencia)
        {
            
            foreach (var item in Mostrar())
            {
                if (item.Referencia.Equals(referencia))
                {
                   estado1=true;
                }
                else
                {
                    estado1=false;
                }
            }
            return estado1;

        }
        public List<Producto> Mostrar()
        {
            return ListaProductos;
        }
        public List<Producto> BuscarByCategoriaYname(string nombre)
        {
            
            ActualizarLit();
            var lista = new List<Producto>();
            foreach (var item in ListaProductos)
            {
                var cate = item.categoria.nombreCategoria;
                if (cate.StartsWith(nombre) || item.Nombre.StartsWith(nombre))
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
