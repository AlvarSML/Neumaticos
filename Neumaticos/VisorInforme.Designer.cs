namespace Neumaticos
{
    partial class VisorInforme
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvVisor
            // 
            this.rpvVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetDetalles";
            reportDataSource1.Value = null;
            this.rpvVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVisor.LocalReport.ReportEmbeddedResource = "Neumaticos.Informes.rptFactura.rdlc";
            this.rpvVisor.Location = new System.Drawing.Point(1, -2);
            this.rpvVisor.Name = "rpvVisor";
            this.rpvVisor.ServerReport.BearerToken = null;
            this.rpvVisor.Size = new System.Drawing.Size(800, 914);
            this.rpvVisor.TabIndex = 0;
            // 
            // VisorInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 913);
            this.Controls.Add(this.rpvVisor);
            this.Name = "VisorInforme";
            this.Text = "Visor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer rpvVisor;
    }
}

