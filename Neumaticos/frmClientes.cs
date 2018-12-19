using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Neumaticos {
    public partial class FrmClientes : Form {
        public FrmClientes() {
            InitializeComponent();
            cargarClientes();
        }

        public void cargarClientes() {
            Controlador con = new Controlador();

            foreach (Cliente c in con.leerClientes()) {
                ListViewItem i;
                ListViewSubItem nombre, telef, direccion;

                i = new ListViewItem() {
                    Text = c.DNICIF,
                    Tag = c
                };

                nombre = new ListViewSubItem() {
                    Text = c.Nombre,
                    Tag = c.Nombre
                };
                i.SubItems.Add(nombre);

                telef = new ListViewSubItem() {
                    Text = c.Telefono,
                    Tag = c.Telefono
                };
                i.SubItems.Add(telef);

                direccion = new ListViewSubItem() {
                    Text = c.Direccion,
                    Tag = c.Direccion
                };
                i.SubItems.Add(direccion);

                lvClientes.Items.Add(i);
            }
        }

        private void tsmVeraAyuda_Click(object sender, System.EventArgs e) {
            Help.ShowHelp(this, Application.StartupPath +@"\"+"Documentation.chm");
        }

        private void FrmClientes_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/3b2059c6-7ef3-4985-9ad0-e68df813eb0c.htm");
        }

        private void tsmNuevo_Click(object sender, System.EventArgs e) {
            new FrmGestionCliente(0).ShowDialog();
        }

        private void tsmModificar_Click(object sender, System.EventArgs e) {            
            new FrmGestionCliente(1,(Cliente)lvClientes.SelectedItems[0].Tag).ShowDialog();
        }

        private void btnSalir_Click(object sender, System.EventArgs e) {
            this.Close();
        }
    }
}
