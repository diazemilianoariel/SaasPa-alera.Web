using System.Collections.Generic;
using System.Reflection;

namespace SaaSPanalera.Web.Models
{
    public class Marca : IMustHaveTenant
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Regla Multi-Tenant
        public int ComercioID { get; set; }

        // Relación: Una marca tiene muchos modelos
        public ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
    }
}