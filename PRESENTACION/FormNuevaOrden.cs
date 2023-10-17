using ModeloParcial405310.DOMINIO;
using ModeloParcial405310.FABRICA;
using ModeloParcial405310.SERVICIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcial405310.PRESENTACION
{
    public partial class FormNuevaOrden : Form
    {
        GestorOrden gestor=null;
        OrdenRetiro orden=null;
        int detallenro;
        public FormNuevaOrden(GestorOrden gestor)
        {
            InitializeComponent();
            this.gestor = gestor; 
        }

        private void FormNuevaOrden_Load(object sender, EventArgs e)
        {
            lblOrdenNro.Text += gestor.TraerNroOrden().ToString(); 
            dtpFechaOrden.Value=DateTime.Now.AddDays(-200);
            CargarCombo();
            orden= new OrdenRetiro();
            detallenro=0;
        }

        private void CargarCombo()
        {
            List<Material> materiales = gestor.TraerListaMateriales();
            cboMateriales.DataSource = materiales;
            cboMateriales.DisplayMember = "nombre";
            cboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar la orden?", "Cancelar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Material oMaterial = (Material)cboMateriales.SelectedItem;
            if (ValidarDetalle(oMaterial))
            {
                DetalleOrden detalleOrden = new DetalleOrden();
                detalleOrden.material = oMaterial;
                detalleOrden.cantidad=Convert.ToInt32(txtCantidad.Text);
                detalleOrden.ID = detallenro+1;
                dgvDetalles.Rows.Add(new object[]
                {
                    detalleOrden.ID,
                    detalleOrden.material.nombre,
                    detalleOrden.material.stock,
                    txtCantidad.Text.ToString(),
                    "Quitar"
                });
                orden.Plistadetalles.Add(detalleOrden);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaOrden.Value > DateTime.Now)
            {
                MessageBox.Show("Debe ingresar una fecha valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dgvDetalles.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar una carga para confirmar la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                orden.Presponsable = txtResponsable.Text;
                orden.Pfecha = dtpFechaOrden.Value;
                if (gestor.ConfirmarOrden(orden))
                {
                    MessageBox.Show("Orden confirmada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("no pudo confirmarse la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDetalle(Material oMaterial)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (DataGridViewRow r in dgvDetalles.Rows)
            {
                if (r.Cells["ColumnaMaterial"].Value.ToString() == oMaterial.nombre)
                {
                    MessageBox.Show("Ese Material ya esta utilizado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (oMaterial.stock < int.Parse(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad ingresada es mayor al stock disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                int.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar una cantidad valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                orden.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                detallenro--;
            }
        }
    }
}
