using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Models
{
    public class Usuario
    {
       
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string UsuarioName { get; set; }
        public string Password { get; set; }

    }
}