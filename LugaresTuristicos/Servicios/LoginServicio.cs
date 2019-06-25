using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.Models;
using LugaresTuristicos.Interfaces;
using LugaresTuristicos.DB;

namespace LugaresTuristicos.Servicios
{
    public class LoginServicio 
    {
        private IDBEntradasEntities2 db;

        public LoginServicio(IDBEntradasEntities2 db)
        {
            this.db = db;
        }

        //public Usuario Login(Usuario usuario)
        //{
        //    return db.Usuarios
        //    .Where(a => a.UsuarioName == (usuario.UsuarioName) &&  a.Password == (usuario.Password))
        //     .FirstOrDefault();
        //}

        //public void AddUsuario(Usuario usuario)
        //{
        //    db.Usuarios.Add(usuario);
        //    db.SaveChanges();
        //}
    }
}