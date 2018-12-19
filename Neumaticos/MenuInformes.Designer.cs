namespace Neumaticos {
    partial class MenuInformes {
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
            this.btnFactura = new System.Windows.Forms.Button();
            this.numFactura = new System.Windows.Forms.NumericUpDown();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnImpagadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(12, 12);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // numFactura
            // 
            this.numFactura.Location = new System.Drawing.Point(93, 12);
            this.numFactura.Name = "numFactura";
            this.numFactura.Size = new System.Drawing.Size(120, 20);
            this.numFactura.TabIndex = 3;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Location = new System.Drawing.Point(12, 41);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(75, 23);
            this.btnCatalogo.TabIndex = 4;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnImpagadas
            // 
            this.btnImpagadas.Location = new System.Drawing.Point(12, 70);
            this.btnImpagadas.Name = "btnImpagadas";
            this.btnImpagadas.Size = new System.Drawing.Size(75, 23);
            this.btnImpagadas.TabIndex = 5;
            this.btnImpagadas.Text = "Impagadas";
            this.btnImpagadas.UseVisualStyleBackColor = true;
            this.btnImpagadas.Click += new System.EventHandler(this.btnImpagadas_Click);
            // 
            // MenuInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 233);
            this.Controls.Add(this.btnImpagadas);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.numFactura);
            this.Controls.Add(this.btnFactura);
            this.Name = "MenuInformes";
            this.Text = "Menu infores";
            ((System.ComponentModel.ISupportInitialize)(this.numFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.NumericUpDown numFactura;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnImpagadas;
    }
}