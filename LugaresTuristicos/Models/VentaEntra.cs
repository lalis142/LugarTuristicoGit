using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Models
{
    public class VentaEntra
    {
        public int Id { get; set; }
        public int CantidadEntraNino { get; set; }
        public int CantidadEntraAdulto { get; set; }
        public DateTime FechaVisita { get; set; }
        public float PrecioTotal { get; set; }
        public int IdCliente { get; set; }
        public int IdLugarTuristico { get; set; }

        public Clientes clientes { get; set; }
        public LugarTuristico LugarTuristicos { get; set; }
        
    }
}