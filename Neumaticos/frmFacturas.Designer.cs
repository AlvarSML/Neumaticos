namespace Neumaticos {
    partial class frmFacturas {
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
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.clhNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhIVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPagado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtClieten = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirSalir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVerAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlFactura.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFactura
            // 
            this.pnlFactura.Controls.Add(this.lvFacturas);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFactura.Location = new System.Drawing.Point(0, 55);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(800, 360);
            this.pnlFactura.TabIndex = 11;
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNumero,
            this.clhCliente,
            this.clhFecha,
            this.clhBase,
            this.clhTotal,
            this.clhIVA,
            this.clhPagado});
            this.lvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFacturas.Location = new System.Drawing.Point(0, 0);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(800, 360);
            this.lvFacturas.TabIndex = 1;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            // 
            // clhNumero
            // 
            this.clhNumero.Text = "Numero";
            this.clhNumero.Width = 91;
            // 
            // clhCliente
            // 
            this.clhCliente.Text = "Cliente";
            this.clhCliente.Width = 130;
            // 
            // clhFecha
            // 
            this.clhFecha.Text = "Fecha";
            this.clhFecha.Width = 128;
            // 
            // clhBase
            // 
            this.clhBase.Text = "Base";
            this.clhBase.Width = 124;
            // 
            // clhTotal
            // 
            this.clhTotal.Text = "Total";
            this.clhTotal.Width = 89;
            // 
            // clhIVA
            // 
            this.clhIVA.Text = "IVA";
            this.clhIVA.Width = 113;
            // 
            // clhPagado
            // 
            this.clhPagado.Text = "Pagado";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(741, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(47, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(355, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(116, 20);
            this.txtBase.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(227, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // txtClieten
            // 
            this.txtClieten.Location = new System.Drawing.Point(96, 4);
            this.txtClieten.Name = "txtClieten";
            this.txtClieten.Size = new System.Drawing.Size(125, 20);
            this.txtClieten.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(87, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtPagado);
            this.pnlDatos.Controls.Add(this.txtIVA);
            this.pnlDatos.Controls.Add(this.txtTotal);
            this.pnlDatos.Controls.Add(this.btnFiltrar);
            this.pnlDatos.Controls.Add(this.txtBase);
            this.pnlDatos.Controls.Add(this.txtFecha);
            this.pnlDatos.Controls.Add(this.txtClieten);
            this.pnlDatos.Controls.Add(this.txtNumero);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 24);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(800, 31);
            this.pnlDatos.TabIndex = 9;
            // 
            // txtPagado
            // 
            this.txtPagado.Location = new System.Drawing.Point(673, 4);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(62, 20);
            this.txtPagado.TabIndex = 7;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(564, 4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(103, 20);
            this.txtIVA.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(477, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(554, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(10);
            this.btnImprimir.MaximumSize = new System.Drawing.Size(200, 200);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 35);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnImprimirSalir
            // 
            this.btnImprimirSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimirSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimirSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirSalir.Location = new System.Drawing.Point(625, 0);
            this.btnImprimirSalir.Name = "btnImprimirSalir";
            this.btnImprimirSalir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimirSalir.TabIndex = 3;
            this.btnImprimirSalir.Text = "Imprimir y salir";
            this.btnImprimirSalir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(725, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnImprimirSalir);
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 415);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(800, 35);
            this.pnlBotones.TabIndex = 10;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVerAyuda});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tsmVerAyuda
            // 
            this.tsmVerAyuda.Name = "tsmVerAyuda";
            this.tsmVerAyuda.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.tsmVerAyuda.Size = new System.Drawing.Size(150, 22);
            this.tsmVerAyuda.Text = "Ver ayuda";
            this.tsmVerAyuda.Click += new System.EventHandler(this.tsmVerAyuda_Click);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(180, 22);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsmNuevo.Text = "Nuevo";
            this.tsmNuevo.Click += new System.EventHandler(this.tsmNuevo_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.tsmModificar,
            this.tsmEliminar});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFactura);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmFacturas_HelpRequested);
            this.pnlFactura.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtClieten;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader clhNumero;
        private System.Windows.Forms.ColumnHeader clhCliente;
        private System.Windows.Forms.ColumnHeader clhFecha;
        private System.Windows.Forms.ColumnHeader clhBase;
        private System.Windows.Forms.ColumnHeader clhTotal;
        private System.Windows.Forms.ColumnHeader clhIVA;
        private System.Windows.Forms.ColumnHeader clhPagado;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolStripMenuItem tsmVerAyuda;
    }
}