using System;
using System.Windows.Forms;

namespace Neumaticos {
    public partial class VisorInforme : Form {
        public VisorInforme() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.rpvVisor.RefreshReport();
        }

        private void btnFactura_Click(object sender, EventArgs e) {
            Generador.CargarFactura(1000);
        }
    }
}
