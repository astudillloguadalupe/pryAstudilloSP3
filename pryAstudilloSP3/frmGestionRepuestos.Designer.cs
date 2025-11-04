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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionRepuestos));
            tabDatos = new TabControl();
            tabInicio = new TabPage();
            mtbNumeroRepuesto = new MaskedTextBox();
            lstOrigen = new ComboBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtDescripcion = new TextBox();
            mtbPrecio = new MaskedTextBox();
            lblPrecio = new Label();
            lstMarca = new ComboBox();
            lblDescripcion = new Label();
            lblNumeroRepuesto = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            tabPage2 = new TabPage();
            lstMarca2 = new ComboBox();
            cmbResultado = new ListBox();
            optImportado = new RadioButton();
            optNacional = new RadioButton();
            btnConsultar = new Button();
            lblOrigen2 = new Label();
            lblMarca2 = new Label();
            lblTitulo = new Label();
            tabDatos.SuspendLayout();
            tabInicio.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabInicio.Controls.Add(mtbNumeroRepuesto);
            tabInicio.Controls.Add(lstOrigen);
            tabInicio.Controls.Add(btnCancelar);
            tabInicio.Controls.Add(btnRegistrar);
            tabInicio.Controls.Add(txtDescripcion);
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
            tabInicio.Text = "Registrar";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // mtbNumeroRepuesto
            // 
            mtbNumeroRepuesto.Location = new Point(172, 155);
            mtbNumeroRepuesto.Mask = "99999";
            mtbNumeroRepuesto.Name = "mtbNumeroRepuesto";
            mtbNumeroRepuesto.Size = new Size(126, 23);
            mtbNumeroRepuesto.TabIndex = 29;
            mtbNumeroRepuesto.ValidatingType = typeof(int);
            mtbNumeroRepuesto.TextChanged += mtbNumeroRepuesto_TextChanged;
            // 
            // lstOrigen
            // 
            lstOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            lstOrigen.FormattingEnabled = true;
            lstOrigen.Location = new Point(115, 106);
            lstOrigen.Name = "lstOrigen";
            lstOrigen.Size = new Size(183, 23);
            lstOrigen.TabIndex = 28;
            lstOrigen.SelectedIndexChanged += lstOrigen_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(338, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(238, 297);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(130, 197);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 23);
            txtDescripcion.TabIndex = 25;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
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
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
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
            lstMarca.SelectedIndexChanged += lstMarca_SelectedIndexChanged;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(lstMarca2);
            tabPage2.Controls.Add(cmbResultado);
            tabPage2.Controls.Add(optImportado);
            tabPage2.Controls.Add(optNacional);
            tabPage2.Controls.Add(btnConsultar);
            tabPage2.Controls.Add(lblOrigen2);
            tabPage2.Controls.Add(lblMarca2);
            tabPage2.Controls.Add(lblTitulo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(461, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstMarca2
            // 
            lstMarca2.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca2.FormattingEnabled = true;
            lstMarca2.Location = new Point(79, 68);
            lstMarca2.Name = "lstMarca2";
            lstMarca2.Size = new Size(132, 23);
            lstMarca2.TabIndex = 25;
            // 
            // cmbResultado
            // 
            cmbResultado.FormattingEnabled = true;
            cmbResultado.ItemHeight = 15;
            cmbResultado.Location = new Point(20, 244);
            cmbResultado.Name = "cmbResultado";
            cmbResultado.Size = new Size(410, 94);
            cmbResultado.TabIndex = 24;
            cmbResultado.SelectedIndexChanged += cmbResultado_SelectedIndexChanged;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(331, 94);
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
            optNacional.Location = new Point(331, 49);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(72, 19);
            optNacional.TabIndex = 22;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(328, 184);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.Location = new Point(258, 71);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(43, 15);
            lblOrigen2.TabIndex = 2;
            lblOrigen2.Text = "Origen";
            // 
            // lblMarca2
            // 
            lblMarca2.AutoSize = true;
            lblMarca2.Location = new Point(20, 71);
            lblMarca2.Name = "lblMarca2";
            lblMarca2.Size = new Size(40, 15);
            lblMarca2.TabIndex = 1;
            lblMarca2.Text = "Marca";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de repuestos";
            // 
            // frmGestionRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 432);
            Controls.Add(tabDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGestionRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Repuestos";
            Load += frmGestionRepuestos_Load;
            tabDatos.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabInicio.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabDatos;
        private TabPage tabInicio;
        private TabPage tabPage2;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtDescripcion;
        private RadioButton optImportado;
        private RadioButton optNacional;
        private MaskedTextBox mtbPrecio;
        private Label lblPrecio;
        private ComboBox lstMarca;
        private Label lblDescripcion;
        private Label lblNumeroRepuesto;
        private Label lblOrigen;
        private Label lblMarca;
        private ComboBox lstOrigen;
        private MaskedTextBox mtbNumeroRepuesto;
        private ListBox cmbResultado;
        private Button btnConsultar;
        private Label lblOrigen2;
        private Label lblMarca2;
        private Label lblTitulo;
        private ComboBox lstMarca2;
    }
}