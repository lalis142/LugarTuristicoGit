using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaresTuristicos.Interfaces.IManagers
{
    public interface ISessionManager
    {
        void LoginAdministrador(Usuario usuario);
        void LoginCliente(Usuario usuario);
       
    }
}
