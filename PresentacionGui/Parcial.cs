﻿using Logica;
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
    public partial class Parcial : Form
    {
        public Parcial()
        {
            InitializeComponent();
            categoria();
            cargarGrilla();
        }
        Logica.ServicioProducto ServicioProducto=new Logica.ServicioProducto();
        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            if (comboBoxCategoria.Text==""||txtReferencia.Text==""||txtnombre.Text==""||txtPrecio.Text==""||dateFecha.Text=="")
            {
                MessageBox.Show("FALTAN DATOS POR LLENAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idcategoria = int.Parse(comboBoxCategoria.SelectedItem.ToString());
                Entidades.Producto producto = new Entidades.Producto();
                producto.Referencia = (txtReferencia.Text);
                producto.Nombre = txtnombre.Text;
                var categoria1 = servicioCategoria.buscar(idcategoria);
                producto.Categorianame = categoria1.nombreCategoria;
                producto.FechaVencimiento = DateTime.Parse(dateFecha.Value.ToString());
                producto.Precio = double.Parse(txtPrecio.Text);
                var mensage = ServicioProducto.Guardar(producto);
                MessageBox.Show(mensage);
            }
        }
        void cargarGrilla()
        {
            GrillaCategorias.DataSource = servicioCategoria.Mostrar();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            this.Visible = false;
            consultar.Show();
        }
        ServicioCategoria servicioCategoria = new ServicioCategoria();
        public void categoria()
        {
            var EscuelaNombre = servicioCategoria.Mostrar();
            if (EscuelaNombre != null)
            {
                foreach (var item in EscuelaNombre)
                {
                    comboBoxCategoria.Items.Add(item.IdCategoria);
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            txtnombre.Clear();
            txtPrecio.Clear();
            txtReferencia.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            dateFecha.Text = DateTime.UtcNow.ToString();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            this.Visible=false;
            mainMenu.ShowDialog();
        }
    }
}