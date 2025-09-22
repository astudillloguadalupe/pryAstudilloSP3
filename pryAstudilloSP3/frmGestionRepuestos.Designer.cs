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
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumeroRepuesto = new Label();
            lblDescripcion = new Label();
            lstMarca = new ComboBox();
            lblPrecio = new Label();
            maskedTextBox1 = new MaskedTextBox();
            optNacional = new RadioButton();
            optImportado = new RadioButton();
            lstResultado = new ListBox();
            nudNumero = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 32);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(12, 83);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Location = new Point(12, 127);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(119, 15);
            lblNumeroRepuesto.TabIndex = 2;
            lblNumeroRepuesto.Text = "Numero del repuesto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 169);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lstMarca
            // 
            lstMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca.FormattingEnabled = true;
            lstMarca.Location = new Point(80, 29);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(183, 23);
            lstMarca.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 211);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(95, 208);
            maskedTextBox1.Mask = "99999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // optNacional
            // 
            optNacional.AutoSize = true;
            optNacional.Location = new Point(80, 81);
            optNacional.Name = "optNacional";
            optNacional.Size = new Size(72, 19);
            optNacional.TabIndex = 8;
            optNacional.TabStop = true;
            optNacional.Text = "Nacional";
            optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            optImportado.AutoSize = true;
            optImportado.Location = new Point(197, 81);
            optImportado.Name = "optImportado";
            optImportado.Size = new Size(81, 19);
            optImportado.TabIndex = 9;
            optImportado.TabStop = true;
            optImportado.Text = "Importado";
            optImportado.UseVisualStyleBackColor = true;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(11, 278);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(393, 94);
            lstResultado.TabIndex = 10;
            // 
            // nudNumero
            // 
            nudNumero.Location = new Point(143, 119);
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(120, 23);
            nudNumero.TabIndex = 11;
            // 
            // frmGestionRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 435);
            Controls.Add(nudNumero);
            Controls.Add(lstResultado);
            Controls.Add(optImportado);
            Controls.Add(optNacional);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblPrecio);
            Controls.Add(lstMarca);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumeroRepuesto);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmGestionRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Repuestos";
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumeroRepuesto;
        private Label lblDescripcion;
        private ComboBox lstMarca;
        private Label lblPrecio;
        private MaskedTextBox maskedTextBox1;
        private RadioButton optNacional;
        private RadioButton optImportado;
        private ListBox lstResultado;
        private NumericUpDown nudNumero;
    }
}