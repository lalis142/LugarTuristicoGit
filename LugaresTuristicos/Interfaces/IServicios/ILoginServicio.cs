using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaresTuristicos.Interfaces.IServicios
{
    public interface ILoginServicio
    {
        Usuario Login(Usuario usuario);
        void AddUsuario(Usuario usuario);
    }
}
