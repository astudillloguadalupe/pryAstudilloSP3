namespace pryAstudilloSP3
{
    partial class frmGestionRepuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabDatos = new TabControl();
            tabInicio = new TabPage();
            tabPage2 = new TabPage();
            btnCancelar = new Button();
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            nudNumero = new NumericUpDown();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            mtbPrecio = new MaskedTextBox();
            lblPrecio = new Label();
            lstMarca = new ComboBox();
            lblDescripcion = new Label();
            lblNumeroRepuesto = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            dgvDatos = new DataGridView();
            tabDatos.SuspendLayout();
            tabInicio.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tabDatos
            // 
            tabDatos.Controls.Add(tabInicio);
            tabDatos.Controls.Add(tabPage2);
            tabDatos.Location = new Point(12, 12);
            tabDatos.Name = "tabDatos";
            tabDatos.SelectedIndex = 0;
            tabDatos.Size = new Size(469, 409);
            tabDatos.TabIndex = 16;
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(btnCancelar);
            tabInicio.Controls.Add(btnBuscar);
            tabInicio.Controls.Add(txtDescripcion);
            tabInicio.Controls.Add(nudNumero);
            tabInicio.Controls.Add(optImportado);
            tabInicio.Controls.Add(optNacional);
            tabInicio.Controls.Add(mtbPrecio);
            tabInicio.Controls.Add(lblPrecio);
            tabInicio.Controls.Add(lstMarca);
            tabInicio.Controls.Add(lblDescripcion);
            tabInicio.Controls.Add(lblNumeroRepuesto);
            tabInicio.Controls.Add(lblOrigen);
            tabInicio.Controls.Add(lblMarca);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(461, 381);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "tabPage1";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDatos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(461, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(338, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(238, 297);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(130, 197);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // nudNumero
            // 
            nudNumero.Enabled = false;
            nudNumero.Location = new Point(178, 156);
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(120, 23);
            nudNumero.TabIndex = 24;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(232, 112);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(81, 19);
            optImportado.TabIndex = 23;
            optImportado.TabStop = true;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Location = new Point(115, 112);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(72, 19);
            optNacional.TabIndex = 22;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Enabled = false;
            mtbPrecio.Location = new Point(130, 239);
            mtbPrecio.Mask = "99999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(168, 23);
            mtbPrecio.TabIndex = 21;
            mtbPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(47, 242);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio";
            // 
            // lstMarca
            // 
            lstMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca.FormattingEnabled = true;
            lstMarca.Location = new Point(115, 60);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(183, 23);
            lstMarca.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(47, 200);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Location = new Point(47, 158);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(119, 15);
            lblNumeroRepuesto.TabIndex = 17;
            lblNumeroRepuesto.Text = "Numero del repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(47, 114);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 16;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(47, 63);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "Marca";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(47, 55);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(366, 271);
            dgvDatos.TabIndex = 16;
            // 
            // frmGestionRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 602);
            Controls.Add(tabDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmGestionRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Repuestos";
            Load += frmGestionRepuestos_Load;
            tabDatos.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabInicio.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabDatos;
        private TabPage tabInicio;
        private TabPage tabPage2;
        private Button btnCancelar;
        private Button btnBuscar;
        private TextBox txtDescripcion;
        private NumericUpDown nudNumero;
        private RadioButton optImportado;
        private RadioButton optNacional;
        private MaskedTextBox mtbPrecio;
        private Label lblPrecio;
        private ComboBox lstMarca;
        private Label lblDescripcion;
        private Label lblNumeroRepuesto;
        private Label lblOrigen;
        private Label lblMarca;
        private DataGridView dgvDatos;
    }
}