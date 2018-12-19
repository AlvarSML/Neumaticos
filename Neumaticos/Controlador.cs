using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Neumaticos {
    class Controlador : IDisposable {
        private NeumaticosDB _ctx;
        private bool disposed;

        /// <summary>
        /// Contrloador con el contexto de la BDD
        /// </summary>
        public Controlador() {
            _ctx = new NeumaticosDB();
        }

        /// <summary>
        /// Constructor de controlador
        /// </summary>
        /// <param name="bd">Base de datos a cargar</param>
        internal Controlador(NeumaticosDB bd) {
            _ctx = bd;
        }

        /// <summary>
        /// Lee los productos de la BDD
        /// </summary>
        /// <returns></returns>
        public List<Producto> leerProductos() {
            return _ctx.Productos.ToList();
        }

        /// <summary>
        /// Lee todos los clientes en una lisata
        /// </summary>
        /// <returns> Lista de clientes </returns>
        public List<Cliente> leerClientes() {
            return _ctx.Clientes.ToList();
        }

        /// <summary>
        /// Lee todas las facturas
        /// </summary>
        /// <returns> Lista de facturas </returns>
        public List<Factura> leerFacturas() {
            return _ctx.Facturas.ToList();
        }
        
        /// <summary>
        /// Crea un cliente el la BDD
        /// </summary>
        /// <param name="c">Cliente a crear</param>
        public void crearCliente(Cliente c) {
            _ctx.Clientes.Add(c);
            _ctx.SaveChanges();
        }

        
        /// <summary>
        /// Modificar cliente
        /// </summary>
        /// <param name="c">Datos a modificar</param>
        public void modificarCliente(Cliente c) {
            Cliente mod = _ctx.Clientes.FirstOrDefault(cl => cl.ClienteId == c.ClienteId);

            mod.Direccion = c.Direccion;
            mod.DNICIF = c.DNICIF;
            mod.Telefono = c.Telefono;
            mod.Nombre = c.Nombre;

            _ctx.SaveChanges();
        }

        /// <summary>
        /// Añade un nuevo producto
        /// </summary>
        /// <param name="p">Producto a crear</param>
        public void crearProducto(Producto p) {
            _ctx.Productos.Add(p);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Modificar un producto
        /// </summary>
        /// <param name="p">Producto a modificar</param>
        public void  modificarProducto(Producto p) {
            Producto mod = _ctx.Productos.Find(p.ProductoId);

            mod.Ancho = p.Ancho;
            mod.Alto = p.Alto;
            mod.Radial = p.Radial;
            mod.Precio = p.Precio;
            mod.Fabricante = p.Fabricante;
            
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Añade ua 
        /// </summary>
        /// <param name="f"></param>
        public void crearFactura(Factura f) {
            _ctx.Facturas.Add(f);
            _ctx.SaveChanges();
        }

        public void crearLineaFactura(DetalleFactura d) {
            _ctx.DetalleFacturas.Add(d);
            _ctx.SaveChanges();
        }

        public List<DetalleFactura> leerLienas(Factura f) {
            return _ctx.DetalleFacturas.Where(d => d.FacturaId == f.FacturaId).ToList();
        }

        // Intento de eliminar 
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    _ctx.Dispose();
                }

                disposed = true;
            }
        }

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);
    }
}
