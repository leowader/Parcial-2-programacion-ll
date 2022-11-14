using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            CargarGrilla();
        }

        Logica.ServicioCategoria servicio = new Logica.ServicioCategoria();
        Logica.ServicioProducto ServicioProducto = new Logica.ServicioProducto();
        void CargarGrilla()
        {
            if (ServicioProducto.Mostrar() == null)
            {
                MessageBox.Show("NO HAY PRODUCTOS  REGISTRADOS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GrilaProductos.Rows.Clear();
                foreach (var item in ServicioProducto.Mostrar())
                {
                    int n = GrilaProductos.Rows.Add();
                    GrilaProductos.Rows[n].Cells[0].Value = item.Referencia;
                    GrilaProductos.Rows[n].Cells[1].Value = item.Nombre;
                    GrilaProductos.Rows[n].Cells[2].Value = item.Categorianame;
                    GrilaProductos.Rows[n].Cells[3].Value = item.FechaVencimiento.ToShortDateString();
                    GrilaProductos.Rows[n].Cells[4].Value = item.Precio;
                }
            }
        }
        void BuscarByName()
        {
            var resultadoBusqueda=VerificarBusqueda(txtBuscar.Text);
            if (resultadoBusqueda==false)
            {
                MessageBox.Show("NO SE ENCONTRARON COINCIDENCIAS", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VerificarBusqueda(txtBuscar.Text);
            }
        }
        bool estado;
        bool VerificarBusqueda(String nombre)
        {
            
            var lista = ServicioProducto.Mostrar();
            List<Producto> productos = new List<Producto>();
            foreach (var item in lista)
            {
                if (item.Nombre.Equals(nombre))
                {
                    GrilaProductos.Rows.Clear();
                    productos.Add(item);
                    GrilaProductos.Rows.Add(item.Referencia, item.Nombre, item.Categorianame, item.FechaVencimiento.ToShortDateString(), item.Precio);
                    estado = true;
                }
            }
            return estado;
        }
        private void Consultar_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        void Buscar()
        {
            if (RbCategoria.Checked)
            {
                btnBuscar.Enabled = true;
                BusarCategoria();
            }
            else if (RbName.Checked)
            {
                BuscarByName();
            }
            else
            {
                if (RbFecha.Checked)
                {
                    BuscarFecha();
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN METODO DE BUSQUEDA", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void BusarCategoria()
        {
            GrilaProductos.Rows.Clear();
            var lista = ServicioProducto.BuscarByCategoria(txtBuscar.Text);
            foreach (var item in lista)
            {
                GrilaProductos.Rows.Add(item.Referencia, item.Nombre, item.Categorianame, item.FechaVencimiento.ToShortDateString(), item.Precio);
            }
        }
        void BuscarFecha()
        {
            if (txtBuscar.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR UN DATO PARA BUSCAR","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                GrilaProductos.Rows.Clear();
                var lista = ServicioProducto.BuscarByMes(int.Parse(txtBuscar.Text));
                foreach (var item in lista)
                {
                    
                    GrilaProductos.Rows.Add(item.Referencia, item.Nombre, item.Categorianame, item.FechaVencimiento.ToShortDateString(), item.Precio);
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                CargarGrilla();
            }
            else
            {
                if (RbCategoria.Checked)
                {
                    GrilaProductos.Rows.Clear();
                    foreach (var item in ServicioProducto.BuscarByCategoria(txtBuscar.Text))
                    {
                        GrilaProductos.Rows.Add(item.Referencia, item.Nombre, item.Categorianame, item.FechaVencimiento.ToShortDateString(), item.Precio);
                    }
                }
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Parcial parcial = new Parcial();
            this.Visible = false;
            parcial.ShowDialog();
            
        }
    }
}
