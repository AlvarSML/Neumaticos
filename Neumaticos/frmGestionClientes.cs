using System.Windows.Forms;

namespace Neumaticos {
    public partial class FrmGestionCliente : Form {
        private int _mod;
        private Cliente _cliente;

        public FrmGestionCliente(int mod) {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
            _mod = mod;
        }

        public FrmGestionCliente(int mod, Cliente c) : this(mod) {
            _cliente = c;
            txtDireccion.Text = c.Direccion;
            txtDNI.Text = c.DNICIF;
            txtNombre.Text = c.Nombre;
            txtTelefono.Text = c.Telefono;
        }

        private void btnAyuda_Click(object sender, System.EventArgs e) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm");
        }

        private void FrmGestionCliente_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/ad900937-20c5-4ccc-bf9a-0e49d2787e0f.htm");
        }

        private void btnGuardar_Click(object sender, System.EventArgs e) {


            if (_mod == 1) {
                _cliente.Nombre = txtNombre.Text;
                _cliente.DNICIF = txtDNI.Text;
                _cliente.Telefono = txtTelefono.Text;
                _cliente.Direccion = txtDireccion.Text;

                new Controlador().modificarCliente(_cliente);
            } else {
                Cliente c = new Cliente() {
                    Nombre = txtNombre.Text,
                    DNICIF = txtDNI.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text
                };
                new Controlador().crearCliente(c);
            }


            txtDireccion.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e) {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
