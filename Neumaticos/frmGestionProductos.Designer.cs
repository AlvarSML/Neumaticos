namespace Neumaticos {
    partial class frmGestionProductos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.lbRadial = new System.Windows.Forms.Label();
            this.lbAlto = new System.Windows.Forms.Label();
            this.lbAncho = new System.Windows.Forms.Label();
            this.numRadial = new System.Windows.Forms.NumericUpDown();
            this.numAlto = new System.Windows.Forms.NumericUpDown();
            this.numAncho = new System.Windows.Forms.NumericUpDown();
            this.lbMedidas = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.lbFabricante = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.gbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel1.Size = new System.Drawing.Size(342, 29);
            this.panel1.TabIndex = 12;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Khaki;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.Location = new System.Drawing.Point(10, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 24);
            this.btnAyuda.TabIndex = 13;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(182, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(257, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 24);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gbDatosProducto);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(342, 135);
            this.pnlDatos.TabIndex = 11;
            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.numPrecio);
            this.gbDatosProducto.Controls.Add(this.lbPrecio);
            this.gbDatosProducto.Controls.Add(this.lbRadial);
            this.gbDatosProducto.Controls.Add(this.lbAlto);
            this.gbDatosProducto.Controls.Add(this.lbAncho);
            this.gbDatosProducto.Controls.Add(this.numRadial);
            this.gbDatosProducto.Controls.Add(this.numAlto);
            this.gbDatosProducto.Controls.Add(this.numAncho);
            this.gbDatosProducto.Controls.Add(this.lbMedidas);
            this.gbDatosProducto.Controls.Add(this.txtFabricante);
            this.gbDatosProducto.Controls.Add(this.lbFabricante);
            this.gbDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosProducto.Location = new System.Drawing.Point(0, 0);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(342, 135);
            this.gbDatosProducto.TabIndex = 8;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "Datos del producto";
            // 
            // lbRadial
            // 
            this.lbRadial.AutoSize = true;
            this.lbRadial.Location = new System.Drawing.Point(248, 51);
            this.lbRadial.Name = "lbRadial";
            this.lbRadial.Size = new System.Drawing.Size(37, 13);
            this.lbRadial.TabIndex = 8;
            this.lbRadial.Text = "Radial";
            // 
            // lbAlto
            // 
            this.lbAlto.AutoSize = true;
            this.lbAlto.Location = new System.Drawing.Point(168, 51);
            this.lbAlto.Name = "lbAlto";
            this.lbAlto.Size = new System.Drawing.Size(25, 13);
            this.lbAlto.TabIndex = 7;
            this.lbAlto.Text = "Alto";
            // 
            // lbAncho
            // 
            this.lbAncho.AutoSize = true;
            this.lbAncho.Location = new System.Drawing.Point(88, 51);
            this.lbAncho.Name = "lbAncho";
            this.lbAncho.Size = new System.Drawing.Size(38, 13);
            this.lbAncho.TabIndex = 6;
            this.lbAncho.Text = "Ancho";
            // 
            // numRadial
            // 
            this.numRadial.Location = new System.Drawing.Point(247, 70);
            this.numRadial.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRadial.Name = "numRadial";
            this.numRadial.Size = new System.Drawing.Size(78, 20);
            this.numRadial.TabIndex = 5;
            // 
            // numAlto
            // 
            this.numAlto.Location = new System.Drawing.Point(168, 70);
            this.numAlto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAlto.Name = "numAlto";
            this.numAlto.Size = new System.Drawing.Size(73, 20);
            this.numAlto.TabIndex = 4;
            // 
            // numAncho
            // 
            this.numAncho.Location = new System.Drawing.Point(88, 70);
            this.numAncho.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAncho.Name = "numAncho";
            this.numAncho.Size = new System.Drawing.Size(74, 20);
            this.numAncho.TabIndex = 3;
            // 
            // lbMedidas
            // 
            this.lbMedidas.AutoSize = true;
            this.lbMedidas.Location = new System.Drawing.Point(13, 75);
            this.lbMedidas.Name = "lbMedidas";
            this.lbMedidas.Size = new System.Drawing.Size(47, 13);
            this.lbMedidas.TabIndex = 2;
            this.lbMedidas.Text = "Medidas";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(88, 19);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(237, 20);
            this.txtFabricante.TabIndex = 1;
            // 
            // lbFabricante
            // 
            this.lbFabricante.AutoSize = true;
            this.lbFabricante.Location = new System.Drawing.Point(13, 22);
            this.lbFabricante.Name = "lbFabricante";
            this.lbFabricante.Size = new System.Drawing.Size(57, 13);
            this.lbFabricante.TabIndex = 0;
            this.lbFabricante.Text = "Fabricante";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(13, 98);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrecio.Location = new System.Drawing.Point(88, 96);
            this.numPrecio.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(74, 20);
            this.numPrecio.TabIndex = 11;
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 175);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frmGestionProductos";
            this.Text = "Producto";
            this.panel1.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label lbFabricante;
        private System.Windows.Forms.NumericUpDown numRadial;
        private System.Windows.Forms.NumericUpDown numAlto;
        private System.Windows.Forms.NumericUpDown numAncho;
        private System.Windows.Forms.Label lbMedidas;
        private System.Windows.Forms.Label lbRadial;
        private System.Windows.Forms.Label lbAlto;
        private System.Windows.Forms.Label lbAncho;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
    }
}