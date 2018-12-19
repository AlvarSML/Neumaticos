namespace Neumaticos {
    partial class frmMenuInicial {
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.gbFacturas = new System.Windows.Forms.GroupBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbFacturas.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Location = new System.Drawing.Point(6, 19);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(113, 23);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturas.Location = new System.Drawing.Point(6, 19);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(90, 23);
            this.btnFacturas.TabIndex = 1;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Location = new System.Drawing.Point(6, 19);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(88, 23);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCrearFactura.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearFactura.Location = new System.Drawing.Point(6, 48);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(90, 23);
            this.btnCrearFactura.TabIndex = 3;
            this.btnCrearFactura.Text = "Nueva factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Location = new System.Drawing.Point(6, 48);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(113, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Nuevo producto";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCliente.Location = new System.Drawing.Point(6, 48);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(88, 23);
            this.btnNuevoCliente.TabIndex = 5;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // gbFacturas
            // 
            this.gbFacturas.Controls.Add(this.btnFacturas);
            this.gbFacturas.Controls.Add(this.btnCrearFactura);
            this.gbFacturas.Location = new System.Drawing.Point(16, 89);
            this.gbFacturas.Name = "gbFacturas";
            this.gbFacturas.Size = new System.Drawing.Size(107, 81);
            this.gbFacturas.TabIndex = 6;
            this.gbFacturas.TabStop = false;
            this.gbFacturas.Text = "Factura";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnProductos);
            this.gbProductos.Controls.Add(this.btn);
            this.gbProductos.Location = new System.Drawing.Point(234, 89);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(126, 81);
            this.gbProductos.TabIndex = 7;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnClientes);
            this.gbClientes.Controls.Add(this.btnNuevoCliente);
            this.gbClientes.Location = new System.Drawing.Point(129, 89);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(99, 81);
            this.gbClientes.TabIndex = 8;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(18, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(181, 25);
            this.lbTitulo.TabIndex = 9;
            this.lbTitulo.Text = "Neumaticos Ataulfo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(247, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Khaki;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.Location = new System.Drawing.Point(285, 60);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 210);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbFacturas);
            this.Name = "frmMenuInicial";
            this.Text = "MenuInicial";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmMenuInicial_HelpRequested);
            this.gbFacturas.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox gbFacturas;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
    }
}