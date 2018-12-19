using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Neumaticos {
    public partial class frmProductos : Form {
        public frmProductos() {
            InitializeComponent();
            cargarProductos();
        }

        private void cargarProductos() {

            using (Controlador c = new Controlador()) {
                ListViewItem i;
                ListViewSubItem fabricante, alto, ancho, radial, precio;
                
                foreach (Producto p in c.leerProductos()) {
                    i = new ListViewItem() {
                        Text = p.ProductoId.ToString(),
                        Tag = p
                    };
                                      
                    fabricante = new ListViewSubItem() {
                        Text = p.Fabricante
                    };
                    i.SubItems.Add(fabricante);

                    alto = new ListViewSubItem() {
                        Text = p.Alto.ToString(),
                        Tag = p.Alto
                    };
                    i.SubItems.Add(alto);

                    ancho = new ListViewSubItem() {
                        Text = p.Ancho.ToString(),
                        Tag = p.Ancho
                    };
                    i.SubItems.Add(ancho);

                    radial = new ListViewSubItem() {
                        Text = p.Radial.ToString(),
                        Tag = p.Radial
                    };
                    i.SubItems.Add(radial);

                    precio = new ListViewSubItem() {
                        Text = p.Precio.ToString(),
                        Tag = p.Precio
                    };
                    i.SubItems.Add(precio);
                    this.lvProductos.Items.Add(i);
                }

            }
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e) {
            Help.ShowHelpIndex(this, Application.StartupPath + @"\" + "Documentation.chm");
        }

        private void frmProductos_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/fcc604c3-106d-4863-9268-8f0a4433300f.htm");
        }

        private void tsmModificar_Click(object sender, EventArgs e) {
            new frmGestionProductos((Producto)lvProductos.SelectedItems[0].Tag).ShowDialog();
        }

        private void tsmNuevo_Click(object sender, EventArgs e) {
            new frmGestionProductos().ShowDialog();
        }
    }
}
