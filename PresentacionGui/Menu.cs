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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void registrarMenu_Click(object sender, EventArgs e)
        {
            Parcial parcial = new Parcial();
            this.Visible = false;
            parcial.Show();
        }
        private void consultarMenu_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            this.Visible = false;
            consultar.Show();   
        }

        private void salirMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
