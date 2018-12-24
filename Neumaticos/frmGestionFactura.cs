using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Neumaticos {
    public partial class frmGestionFactura : Form {
        //Factura _factura;

        public frmGestionFactura() {
            InitializeComponent();
            cargarProductos();
            cargarClientes();
        }

        public frmGestionFactura(Factura f) : this() {
            cargarLineas(f);
            txtTotal.Text = f.ImporteTotal.ToString();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }

        private void btnAyuda_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm");
        }

        private void frmGestionFactura_HelpRequested(object sender, HelpEventArgs hlpevent) {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "Documentation.chm", HelpNavigator.Topic, "/html/d2a01c14-014d-4a67-b72f-5b87a11d374c.htm");
        }

        /// <summary>
        /// Carga las lineas de la factura
        /// </summary>
        /// <param name="f">Factura de la que cargar lineas</param>
        private void cargarLineas(Factura f) {
            int j = 0;
            ListViewItem i;
            ListViewSubItem concepto, cantidad, precioud, total;

            foreach (DetalleFactura d in new Controlador().leerLineasFactura(f.FacturaId)) {
                j++;

                i = new ListViewItem() {
                    Text = j.ToString()
                };

                concepto = new ListViewSubItem() {
                    Text = d.Concepto,
                    Tag = d.Concepto
                };
                i.SubItems.Add(concepto);

                cantidad = new ListViewSubItem() {
                    Text = d.Cantidad.ToString(),
                    Tag = d.Cantidad.ToString()
                };
                i.SubItems.Add(cantidad);

                precioud = new ListViewSubItem() {
                    Text = d.PrecioUnidad.ToString(),
                    Tag = d.PrecioUnidad
                };
                i.SubItems.Add(precioud);

                total = new ListViewSubItem() {
                    Text = (d.PrecioUnidad * d.Cantidad).ToString(),
                    Tag = d.PrecioUnidad * d.Cantidad
                };
                i.SubItems.Add(total);

                lvLineas.Items.Add(i);
            }
        }

        private void cargarClientes() {
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
    }
}
