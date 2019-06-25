using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Models
{
    public class LugarTuristico
    {
        public int IdLugarTuristico { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioNino { get; set; }
        public decimal PrecioAdulto { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int IdPromocion { get; set; }
        public int IdClienteLugar { get; set; }
        public Clientes clientes { get; set; }
        public List<VentaEntra> VentaEntras { get; set; }
        public Promocion Promociones { get; set; }
    }
}