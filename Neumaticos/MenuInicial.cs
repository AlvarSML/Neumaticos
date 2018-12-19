using System;
using System.Windows.Forms;

namespace Neumaticos {
    public partial class frmMenuInicial : Form {
        public frmMenuInicial() {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e) {
            new FrmClientes().Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e) {
            new frmFacturas().Show();
        }

        private void btnCrearFactura_Click(object sender, EventArgs e) {
            new frmGestionFactura().Show();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e) {
            new FrmGestionCliente(0).Show();
        }

        private void btnProductos_Click(object sender, EventArgs e) {
            new frmProductos().Show();
        }

        private void btn_Click(object sender, EventArgs e) {
            new frmGestionProductos().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e) {
            Help.ShowHelpIndex( this, Application.StartupPath + @"\"+"Documentation.chm");
        }

        private void frmMenuInicial_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/65b8cd10-5471-4df4-bd98-161b31705475.htm");
        }
    }
}
