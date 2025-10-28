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

        string[,] Repuestos = new string[100, 5];
        int C = 0;

        private void frmGestionRepuestos_Load(object sender, EventArgs e)
        {
            lstMarca.Items.Add("(P)Peugeot");
            lstMarca.Items.Add("(F)Fiat");
            lstMarca.Items.Add("(R)Renault");
            lstOrigen.Items.Add("Nacional");
            lstOrigen.Items.Add("Importado");

            lstMarca2.Items.Add("(P)Peugeot");
            lstMarca2.Items.Add("(F)Fiat");
            lstMarca2.Items.Add("(R)Renault");

            lstOrigen.Enabled = false;
            mtbNumeroRepuesto.Enabled = false;
            txtDescripcion.Enabled = false;
            mtbPrecio.Enabled = false;

        }

        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarca.SelectedIndex != -1)
            {

                lstOrigen.Enabled = true;
            }
            else
            {
                lstOrigen.Enabled = false;
            }
        }

        private void lstOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrigen.SelectedIndex != -1)
            {

                mtbNumeroRepuesto.Enabled = true;
            }
            else
            {


                mtbNumeroRepuesto.Enabled = false;
            }
        }

        private void mtbNumeroRepuesto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumeroRepuesto.Text.Length > 0)
            {

                txtDescripcion.Enabled = true;
            }
            else
            {

                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length > 0)
            {

                mtbPrecio.Enabled = true;
            }
            else
            {

                mtbPrecio.Enabled = false;


            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtDescripcion.Text.Length > 0)
            {

                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (C >= 100)
            {
                MessageBox.Show("Ya se ingresaron los 100 repuestos permitidos.");
                return;
            }


            if (lstMarca.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }
            if (mtbNumeroRepuesto.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de repuesto.");
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }
            if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio.");
                return;
            }
            if (lstOrigen.Text == "")
            {
                MessageBox.Show("Debe seleccionar un origen.");
                return;
            }
            string Numero = mtbNumeroRepuesto.Text;
            int Num;
            try
            {
                Num = int.Parse(Numero);
                if (Numero.Length > 6)
                {
                    MessageBox.Show("El número de repuesto no puede tener más de 6 dígitos.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número de repuesto válido (solo números).");
                return;
            }


            for (int i = 0; i < C; i++)
            {
                if (Repuestos[i, 2] == Numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }
            string Precio = mtbPrecio.Text;
            float Prec;
            try
            {
                Prec = float.Parse(Precio);
                if (Prec <= 0)
                {
                    MessageBox.Show("Ingrese un precio mayor a 0.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            // Carga en la matriz

            Repuestos[C, 0] = lstMarca.Text;
            Repuestos[C, 1] = lstOrigen.Text;
            Repuestos[C, 2] = Numero;
            Repuestos[C, 3] = txtDescripcion.Text;
            Repuestos[C, 4] = Precio;
            C++;

            MessageBox.Show("Repuesto cargado correctamente.");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Desea borrar los datos ingresados?",
               "Confirmar Cancelación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                lstMarca.SelectedIndex = -1;
                mtbNumeroRepuesto.Text = "";
                txtDescripcion.Text = "";
                mtbPrecio.Text = "";
                lstOrigen.SelectedIndex = -1;

                MessageBox.Show("Los campos han sido limpiados.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (C == 0)
            {
                MessageBox.Show("No hay repuestos cargados para consultar.");
                return;
            }

            // Validar campo de búsqueda
            if (lstMarca2.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca para la consulta.");
                return;
            }
            char marca = lstMarca2.Text[0];


            char origen = optNacional.Checked ? 'N' : 'I';
            bool encontrado = false;

            cmbResultado.Items.Clear();
            for (int i = 0; i < C; i++)
            {

                if (Repuestos[i, 0][0] == marca && Repuestos[i, 1][0] == origen)
                {
                    encontrado = true;
                    cmbResultado.Items.Add(
                        "Número: " + Repuestos[i, 2] +
                       " | Descripción: " + Repuestos[i, 3] +
                        " | Precio: $" + Repuestos[i, 4]);
                }
            }
            //Mostrar mensaje si no se encuentran resultados
            if (!encontrado)
            {
                cmbResultado.Items.Add("No se encontraron repuestos con esos criterios.");
            }
        }

        private void cmbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

