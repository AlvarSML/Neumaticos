using System;

namespace Neumaticos.Informes {
    public class FacturaInforme {
        //Cabecera
        public int Numero { get; set; }
        public Boolean Pagada { get; set; }
        public DateTime Fecha { get; set; }
        public string Vendedor = "Alvar San Martin";
        public int ClienteId { get; set; }
        public string DNICIF { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        //Detalles de la factura
        public string Concepto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }

        //Resumen
        public double ImporteBase { get; set; }
        public int IVA { get; set; }
        public double ImporteTotal { get; set; }
    }
}
