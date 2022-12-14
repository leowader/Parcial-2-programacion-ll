using Entidades;
using System;
using System.Collections;
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
        Logica.ServicioProducto ServicioProducto = new Logica.ServicioProducto();
        public Consultar()
        {
            InitializeComponent();
            CargarGrilla();
        }
        void Llenar(List<Producto>lista)
        {
            foreach (var item in lista)
            {
                GrilaProductos.Rows.Add(item.Referencia, item.Nombre, item.categoria.nombreCategoria, item.FechaVencimiento.ToShortDateString(), item.Precio);
            }
        }
        void CargarGrilla()
        {
            if (ServicioProducto.Mostrar() == null)
            {
                MessageBox.Show("NO HAY PRODUCTOS  REGISTRADOS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GrilaProductos.Rows.Clear();
                //GrilaProductos.DataSource=ServicioProducto.Mostrar();
                Llenar(ServicioProducto.Mostrar());
            }
        }
        void BuscarByName()
        {
            GrilaProductos.Rows.Clear();
            var lista =ServicioProducto.BuscarByCategoriaYname(txtBuscar.Text);
            Llenar(lista);
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
            var lista = ServicioProducto.BuscarByCategoriaYname(txtBuscar.Text);
            Llenar(lista);
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
                Llenar(lista);
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
                Buscar();
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
