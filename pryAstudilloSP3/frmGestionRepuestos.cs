using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloSP3
{
    public partial class frmGestionRepuestos : Form
    {
        public frmGestionRepuestos()
        {
            InitializeComponent();
        }

        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarca.Text != "")
            {
                nudNumero.Enabled = true;
            }
            else
            {
                nudNumero.Enabled = false;
            }
        }

        private void frmGestionRepuestos_Load(object sender, EventArgs e)
        {
            lstMarca.Items.Add("(P) Peugeot");
            lstMarca.Items.Add("(R) Renault");
            lstMarca.Items.Add("(F) Fiat");
        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumero.Value > 0)
            {
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void LimpiarControles()
        {
            lstMarca.SelectedIndex = -1;
            nudNumero.Value = 0;
            txtDescripcion.Text = "";
            mtbPrecio.Text = "";
            optImportado.Checked = false;
            optNacional.Checked = false;
            lstMarca.Focus();
            nudNumero.Enabled = false;
            txtDescripcion.Enabled = false;
            mtbPrecio.Enabled = false;
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                mtbPrecio.Enabled = true;
            }
            else
            {
                mtbPrecio.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea borrar los datos ingresados?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                LimpiarControles();
        
            }
        }

    }
}
