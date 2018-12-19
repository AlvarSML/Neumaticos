using Microsoft.Reporting.WinForms;
using Neumaticos.Informes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Neumaticos {
    public class Generador {
        /// <summary>
        /// Metodo de carga de factura
        /// </summary>
        /// <param name="numFactura"></param>
        public static void CargarFactura(int numFactura) {

            VisorInforme visor = new VisorInforme();
            //Seleccion de Informe para ver
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "Neumaticos.Informes.rptFactura.rdlc";

            //Generacion de query
            string query = "select f.ClienteId, f.Numero, f.Fecha, f.Pagada, f.ImporteBase, f.ImporteTotal, f.IVA, d.Concepto, d.Cantidad, d.PrecioUnidad from dbo.DetalleFacturas d left join dbo.Facturas f on f.FacturaId = d.FacturaId where f.FacturaId = " + numFactura + ";";

            //Contexto
            NeumaticosDB ctx = new NeumaticosDB();
            List<FacturaInforme> FacturaLista = ctx.Database.SqlQuery<FacturaInforme>(query, new object[0]).ToList();

            //Origen de datos
            ReportDataSource FuenteDatos = new ReportDataSource("DataSetDetallesFactura", FacturaLista);
            visor.rpvVisor.LocalReport.DataSources.Add(FuenteDatos);

            //Parameters
            ReportParameter Num = new ReportParameter("Numero", numFactura.ToString());
            visor.rpvVisor.LocalReport.SetParameters(Num);

            //Obtener cliente 
            int cliId = FacturaLista[0].ClienteId;
            var cliente = ctx.Clientes.SingleOrDefault(x => x.ClienteId == cliId);

            ReportParameter Cli = new ReportParameter("Cliente", cliente.Nombre);
            visor.rpvVisor.LocalReport.SetParameters(Cli);

            ReportParameter DNI = new ReportParameter("DNI", cliente.DNICIF);
            visor.rpvVisor.LocalReport.SetParameters(DNI);

            ReportParameter Telef = new ReportParameter("Telefono", cliente.Telefono);
            visor.rpvVisor.LocalReport.SetParameters(Telef);

            ReportParameter Dir = new ReportParameter("Direccion", cliente.Direccion);
            visor.rpvVisor.LocalReport.SetParameters(Dir);


            //Display del visor
            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();

            visor.Show();
        }

        public static void cargarCatalogo() {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "Neumaticos.Informes.rptCatalogo.rdlc";

            string query = "select p.Alto, p.Ancho, p.Radial, p.Fabricante, p.Precio from dbo.Productos p;";

            NeumaticosDB ctx = new NeumaticosDB();
            List<CatalogoInforme> Catalogo = ctx.Database.SqlQuery<CatalogoInforme>(query, new object[0]).ToList();
            ReportDataSource FuenteDatos = new ReportDataSource("DataSetDetallesCatalogo", Catalogo);
            visor.rpvVisor.LocalReport.DataSources.Add(FuenteDatos);


            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();

            visor.Show();
        }

        public static void cargarImpagadas() {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisor.LocalReport.ReportEmbeddedResource = "Neumaticos.Informes.rptImpagadas.rdlc";
            string query = "select c.Nombre, c.DNICIF, c.Telefono ,f.Numero, f.Fecha, f.ImporteTotal from Facturas f left join Clientes c on f.ClienteId = c.ClienteId where Pagada = 0 order by f.ClienteId; ";

            NeumaticosDB ctx = new NeumaticosDB();
            List<ImpagadasInforme> Impagadas = ctx.Database.SqlQuery<ImpagadasInforme>(query, new object[0]).ToList();
            ReportDataSource FuenteDatos = new ReportDataSource("DataSetImpagadas", Impagadas);
            visor.rpvVisor.LocalReport.DataSources.Add(FuenteDatos);

            ReportParameter Dir = new ReportParameter("FechaHoy", DateTime.Now.ToString());
            visor.rpvVisor.LocalReport.SetParameters(Dir);

            visor.rpvVisor.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisor.RefreshReport();

            visor.Show();
        }


    }
}

