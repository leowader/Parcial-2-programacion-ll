using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string nombreCategoria { get; set; }
        public override string ToString()
        {
            return $"{IdCategoria};{nombreCategoria}";
        }

    }
}
