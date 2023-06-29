using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry_Luna_Verduleros
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.GrabarVentas(Conexion, "Ventas", Convert.ToInt32(cmbVendedor.SelectedValue), Convert.ToInt32(cmbProducto.SelectedValue), dtpFechas.Value, Convert.ToInt32(nudKilos.Value));
            clsBaseDeDatos.CargarTabla(Conexion, "Ventas", dgvVentas);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.CargarTabla(Conexion, "Ventas", dgvVentas);
            clsBaseDeDatos.CargarProductos(Conexion, "Productos", cmbProducto);
            clsBaseDeDatos.CargarVendedores(Conexion, "Vendedores", cmbVendedor);
        }
    }
}
