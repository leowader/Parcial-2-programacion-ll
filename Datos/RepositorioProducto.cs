﻿using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProducto:Archivos
    {
        public RepositorioProducto()
        {
            ruta = "productos.txt";
        }
        public bool Guardar(Producto producto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(producto.ToString());
                sw.Close();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
        public List<Producto> Leer()
        {
            try
            {
                List<Producto> ListProducto = new List<Producto>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListProducto.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListProducto;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
        public Producto Mapear(string linea)
        {
            var producto = new Producto
            {
                Referencia = linea.Split(';')[0],
                Nombre = linea.Trim().Split(';')[1],
                Categorianame = linea.Split(';')[2],
                FechaVencimiento =DateTime.Parse(linea.Split(';')[3]),
                Precio=double.Parse(linea.Split(';')[4]),
            };
            return producto;
        }
    }
}
