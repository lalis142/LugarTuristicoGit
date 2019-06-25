using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Models
{
    public class GuiaTuristico
    {
        public int IdGuiaTuristico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumTelefono { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }

        public List<Promocion> Promociones { get; set; }
    }
}