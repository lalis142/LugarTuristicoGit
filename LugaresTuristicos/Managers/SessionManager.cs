using LugaresTuristicos.Interfaces.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LugaresTuristicos.Models;
using System.Web.SessionState;
using LugaresTuristicos.DB;

namespace LugaresTuristicos.Managers
{
    public class SessionManager : ISessionManager
    {
        HttpSessionState session;
        DBEntradasEntities2 conexion = new DBEntradasEntities2();

        
        public void LoginAdministrador(Usuario usuario)
        {
            session = HttpContext.Current.Session;
            Administrador ValidarCuenta = conexion.Administradores.Where(o => o.UsuarioName == usuario.UsuarioName && o.Password == usuario.Password).First();//no puede quedarse con null
                                                                                                                                                              //var objeto = conexion.Administradores.Where(o => o.Correo == usuario.Correo && o.Dni == usuario.Dni).First();
                                                                                                                                                              // id = objeto.IdAdministrador;
            session["IdAdministrador"] = ValidarCuenta.IdAdministrador.ToString();
            session["Nombres"] = ValidarCuenta.Nombre.ToString();
        }

        public void LoginCliente(Usuario usuario)
        {
            Clientes validaRepre = conexion.Clientes.Where(o => o.UsuarioName == usuario.UsuarioName && o.Password == usuario.Password).First();
            
            session["Nombres"] = validaRepre.Nombre.ToString();
            session["IdCliente"] = validaRepre.IdCliente.ToString();
        }
    }
}