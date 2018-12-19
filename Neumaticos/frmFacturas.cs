using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Neumaticos {
    public partial class frmFacturas : Form {
        public frmFacturas() {
            InitializeComponent();
            cargarFacturas();
        }

        private void cargarFacturas() {
            using (Controlador c = new Controlador()) {
                ListViewItem i;
                ListViewSubItem cliente, fecha, pbase, total, iva, pagado;

                foreach (Factura f in c.leerFacturas()) {
                    i = new ListViewItem() {
                       Text = f.Numero.ToString(),
                       Tag = f
                    };

                    cliente = new ListViewSubItem() {
                        Text = f.ClienteId.ToString(),
                        Tag = f.ClienteId
                    };
                    i.SubItems.Add(cliente);

                    fecha = new ListViewSubItem() {
                        Text = f.Fecha.ToString(),
                        Tag = f.Fecha
                    };
                    i.SubItems.Add(fecha);

                    pbase = new ListViewSubItem() {
                        Text = f.ImporteBase.ToString(),
                        Tag = f.ImporteBase
                    };
                    i.SubItems.Add(pbase);

                    total = new ListViewSubItem() {
                        Text = f.ImporteTotal.ToString(),
                        Tag = f.ImporteTotal
                    };
                    i.SubItems.Add(total);

                    iva = new ListViewSubItem() {
                        Text = f.IVA.ToString(),
                        Tag = f.IVA
                    };
                    i.SubItems.Add(iva);

                    pagado = new ListViewSubItem() {
                        Text = f.Pagada.ToString(),
                        Tag = f.Pagada
                    };
                    i.SubItems.Add(pagado);

                    this.lvFacturas.Items.Add(i);
                }

            }
        }

        private void tsmVerAyuda_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm");

        }

        private void frmFacturas_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/ab4727f0-c2de-48d2-809e-3412425f761e.htm");
        }

        private void tsmNuevo_Click(object sender, EventArgs e) {
            new frmGestionFactura().ShowDialog();
        }

        private void tsmModificar_Click(object sender, EventArgs e) {
            new frmGestionFactura((Factura) lvFacturas.SelectedItems[0].Tag).ShowDialog();
        }

        private void tsmEliminar_Click(object sender, EventArgs e) {

        }
    }
}
