using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Models
{
    public class Clientes:Usuario
    {
        public int IdCliente { get; set; }
        public List<LugarTuristico> Lugares { get; set; }
        public List<VentaEntra> VentaEntras { get; set; }
    }
}