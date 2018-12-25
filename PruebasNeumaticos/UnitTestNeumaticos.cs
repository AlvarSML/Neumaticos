using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Neumaticos;

namespace PruebasNeumaticos {
    [TestClass]
    public class UnitTestNeumaticos {
        Mock<NeumaticosDB> _moqCtx;
        Controlador _controlador;

        [TestMethod]
        public void BuscarProducto() {
            /**
             * TODO: 
             * - varias querys
             * - comprobaciones personalizadas
             */

            List<Producto> prods = _controlador.LeerProductos(2,1,4);

            Assert.IsNotNull(prods);
            Assert.AreEqual("Pirelli",prods[0].Fabricante );
            Assert.AreEqual(20,prods[0].Precio);
        }

        [TestMethod]
        public void CrearCliente() {
            Cliente c = new Cliente() {
                Nombre = null,
                Direccion = "Direccion1",
                DNICIF = "123456A",
                Telefono = "123456"
            };

            try {
                int? n = _controlador.crearCliente(c);
                Assert.IsNotNull(n);
                Assert.Equals(n, 1);

                Assert.Fail();
            } catch (Exception e) {
                
            }          
            
        }

        [ClassInitialize]
        public static void ClassInit(TestContext tc) {

        }

        [TestInitialize]
        public void Initialize() {
            _moqCtx = new Mock<NeumaticosDB>();            

            var productos = new List<Producto>{
                new Producto {Fabricante = "Pirelli", Precio = 20, Alto=2, Ancho=1, Radial=4 },
                new Producto {Fabricante = "Firestone", Precio = 5, Alto=3, Ancho=2, Radial=3 },
                new Producto {Fabricante = "Firestone", Precio = 1, Alto=4, Ancho=3, Radial=4 },
                new Producto {Fabricante = "Pirelli", Precio = 2, Alto=5, Ancho=1, Radial=5 },
                new Producto {Fabricante = "Michelin", Precio = 23, Alto=1, Ancho=3, Radial=2 },
                new Producto {Fabricante = "Michelin", Precio = 41, Alto=2, Ancho=2, Radial=1 },
                new Producto {Fabricante = "Michelin", Precio = 100, Alto=4, Ancho=1, Radial=3 },
                new Producto {Fabricante = "Pirelli", Precio = 220, Alto=2, Ancho=2, Radial=4 }
            }.AsQueryable();

            var mockTablaProductos = new Mock<DbSet<Producto>>();
            mockTablaProductos.As<IQueryable<Producto>>().Setup(x => x.Provider).Returns(productos.Provider);
            mockTablaProductos.As<IQueryable<Producto>>().Setup(x => x.Expression).Returns(productos.Expression);
            mockTablaProductos.As<IQueryable<Producto>>().Setup(x => x.ElementType).Returns(productos.ElementType);
            mockTablaProductos.As<IQueryable<Producto>>().Setup(x => x.GetEnumerator()).Returns(productos.GetEnumerator());

            _moqCtx.Setup(x => x.Productos).Returns(mockTablaProductos.Object);

            _controlador = new Controlador(_moqCtx.Object);
            Debug.WriteLine("Test iniciado");
        }

        [TestCleanup]
        public void Cleanup() {
            
        }
    }
}
