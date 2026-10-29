using System.Collections.Generic;

namespace SaaSPanalera.Web.Models
{
    public class Modelo : IMustHaveTenant
    {


        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Ej: Premium Care, Confort Sec

        // Relación con Marca
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        // Regla Multi-Tenant
        public int ComercioID { get; set; }

        // Relación: Un modelo tiene muchas variantes de pañales
        public ICollection<ProductoPanal> Productos { get; set; } = new List<ProductoPanal>();
    }
}
