using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neumaticos {
    public partial class MenuInformes : Form {
        public MenuInformes() {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, EventArgs e) {
            Generador.CargarFactura( Convert.ToInt32(numFactura.Value));
        }

        private void btnCatalogo_Click(object sender, EventArgs e) {
            Generador.cargarCatalogo();
        }

        private void btnImpagadas_Click(object sender, EventArgs e) {
            Generador.cargarImpagadas();
        }
    }
}
