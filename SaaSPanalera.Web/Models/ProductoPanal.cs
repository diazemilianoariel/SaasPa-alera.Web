namespace SaaSPanalera.Web.Models
{
    public class ProductoPanal : IMustHaveTenant
    {
        public int Id { get; set; }

        // Variantes
        public string Talle { get; set; } = string.Empty; // Ej: M, G, XG, XXG
        public string Presentacion { get; set; } = string.Empty; // Ej: Hiper, Mega, Jumbo

        // Relación con Modelo
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }

        // Precios
        public decimal PrecioMinorista { get; set; }
        public decimal PrecioPromocionCantidad { get; set; } // Precio por bulto cerrado

        // Control de Inventario Cruzado
        public int StockUnidadesSueltas { get; set; }
        public int StockBultosCerrados { get; set; }
        public int UnidadesPorBulto { get; set; }

        // Regla Multi-Tenant
        public int ComercioID { get; set; }
    }
}