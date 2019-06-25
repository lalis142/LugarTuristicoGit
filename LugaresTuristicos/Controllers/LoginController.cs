using LugaresTuristicos.Interfaces.IManagers;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.Models;
using LugaresTuristicos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LugaresTuristicos.Controllers
{
   
    public class LoginController : Controller
    {
        private DBEntradasEntities2 bd = new DBEntradasEntities2();

        

       private ILoginServicio servicio;
       private ISessionManager sesion;
        public LoginController(ILoginServicio servicio, ISessionManager session)
        {
            this.servicio = servicio;
            this.sesion = session;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
          
            try
            {
              
                sesion.LoginAdministrador(usuario);
                return RedirectToAction("Index", "LugarTuristico");
            }
            catch (Exception)
            {
                try
                {
                    // 
                    sesion.LoginCliente(usuario);
                   
                    return View("Index","Principal");
                }
                catch (Exception)
                {
                   

                }
                
                return View("Index", "Principal");
            }
        }
       

        public ActionResult Registrar()
        {
            return View(new Usuario());
        }

        public ActionResult Guardar(Usuario usuario)
        {
            Validar(usuario);
            if (ModelState.IsValid)
            {
                DBEntradasEntities2 db = new DBEntradasEntities2();
                //db.Usuario.Add(usuario);
                //db.SaveChanges();
                servicio.AddUsuario(usuario);
                return View("Login", usuario);
            }
            return View("Registrar", usuario);
        }
        public ActionResult UserDashFC()
        {
            if (Session["IdUsuario"] != null)
            {
                return RedirectToAction("Index", "LugarTuristico");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        private void Validar(Usuario usuario)
        {
            if (usuario.UsuarioName == null)
                ModelState.AddModelError("UsuarioName", "Ingrese Nombre de Usaurio");

            if (usuario.Password == null)

                ModelState.AddModelError("Password", "Ingrese una contraseña");
            if (usuario.Nombre == null)

                ModelState.AddModelError("Nombre", "Ingrese Nombre");
            if (usuario.ApellidoPaterno == null)

                ModelState.AddModelError("Apellido", "Ingrese Apellido");
        }



    }

}