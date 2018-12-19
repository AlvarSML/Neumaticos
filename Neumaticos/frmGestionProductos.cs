using System.Windows.Forms;

namespace Neumaticos {
    public partial class frmGestionProductos : Form {
        Producto _prod = null;

        public frmGestionProductos() {
            InitializeComponent();
        }

        public frmGestionProductos(Producto p) : this() {
            _prod = p;

            txtFabricante.Text = p.Fabricante;
            numAlto.Value = p.Alto;
            numAncho.Value = p.Ancho;
            numRadial.Value = p.Radial;
            numPrecio.Value = (decimal)p.Precio;
        }

        private void btnAyuda_Click(object sender, System.EventArgs e) {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e) {

            if (_prod == null) {
                _prod = new Producto() {
                    Alto = (int)numAlto.Value,
                    Ancho = (int)numAncho.Value,
                    Radial = (int)numRadial.Value,
                    Precio = (double)numPrecio.Value,
                    Fabricante = txtFabricante.Text
                };

                new Controlador().crearProducto(_prod);
            } else {
                _prod.Alto = (int)numAlto.Value;
                _prod.Ancho = (int)numAncho.Value;
                _prod.Radial = (int)numRadial.Value;
                _prod.Precio = (double)numPrecio.Value;
                _prod.Fabricante = txtFabricante.Text;

                new Controlador().modificarProducto(_prod);
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
