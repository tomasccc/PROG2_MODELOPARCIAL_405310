using ModeloParcial405310.FABRICA;
using ModeloParcial405310.PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcial405310
{
    public partial class FormPrincipal : Form
    {
        FactoryGestorOrden fabrica;
        public FormPrincipal()
        {
            InitializeComponent();
            fabrica = new FactoryGestorOrdenImp();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevaOrden formNuevaOrden = new FormNuevaOrden(fabrica.CrearServicio());
            formNuevaOrden.ShowDialog();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.ShowDialog();
        }
    }
}
