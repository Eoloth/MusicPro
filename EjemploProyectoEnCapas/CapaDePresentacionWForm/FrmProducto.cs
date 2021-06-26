using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacionWForm
{
    public partial class FrmProducto : Form
    {
        Producto p;


        public FrmProducto()
        {
            InitializeComponent();
            p = new Producto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoBarra.Text = "";
            txtDescripcion.Clear();
            txtPrecioCosto.Text =
                txtPrecioVenta.Text =
                txtStock.Text = "";
            txtCodigoBarra.Focus();
            p = new Producto(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigoBarra.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Producto p = new Producto(); se cambio de linea 22 y 38
            int numero;
            if (Int32.TryParse(txtCodigoBarra.Text, out numero))
                p.CodigoBarra = numero;
            else
            {
                MessageBox.Show("El valor no es númerico, vuelva a intentar");
                txtCodigoBarra.Focus();
                return;
            }

            if (txtDescripcion.Text.Trim().Length < 1)
            {
                MessageBox.Show("La descripcioón no es válida, vuelva a intentar");
                txtDescripcion.Focus();
                return;
            }
            else
                p.Descripcion = txtDescripcion.Text.ToUpper().Trim();


            if (Int32.TryParse(txtPrecioCosto.Text, out numero))
                p.PrecioCosto = numero;
            else
            {
                MessageBox.Show("El valor no es númerico, vuelva a intentar");
                txtPrecioCosto.Focus();
                return;
            }

            if (Int32.TryParse(txtPrecioVenta.Text, out numero))
                p.PrecioVenta = numero;
            else
            {
                MessageBox.Show("El valor no es númerico, vuelva a intentar");
                txtPrecioVenta.Focus();
                return;
            }

            if (Int32.TryParse(txtStock.Text, out numero))
                p.Stock = numero;
            else
            {
                MessageBox.Show("El valor no es númerico, vuelva a intentar");
                txtStock.Focus();
                return;
            }

            int resultado = 0;
            if (p.Id == 0)
                resultado = p.Create();
            else
                resultado = p.Update();

            if (resultado == 1)
            {
                MessageBox.Show("Los datos fueron guardados");
                btnLimpiar_Click(null, null);
                btnListar_Click(null, null);
            }
            else
                MessageBox.Show("Los datos NO fueron guardados");

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            VentasColecciones vc = new VentasColecciones();
            dgvListado.DataSource = null;
            dgvListado.DataSource = vc.ReadAll();
            dgvListado.Refresh();
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvListado.SelectedRows.Count == 0)
            //    return;
            //Producto  p = (Producto)dgvListado.SelectedRows[0].DataBoundItem;

            //txtCodigoBarra.Text = p.CodigoBarra.ToString();
            //txtDescripcion.Text = p.Descripcion;
            //txtPrecioCosto.Text = p.PrecioCosto.ToString();
            //txtPrecioVenta.Text = p.PrecioVenta.ToString();
            //txtStock.Text = p.Stock.ToString();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            p = (Producto)dgvListado.Rows[e.RowIndex].DataBoundItem;

            txtCodigoBarra.Text = p.CodigoBarra.ToString();
            txtDescripcion.Text = p.Descripcion;
            txtPrecioCosto.Text = p.PrecioCosto.ToString();
            txtPrecioVenta.Text = p.PrecioVenta.ToString();
            txtStock.Text = p.Stock.ToString();

        }
    }
}
