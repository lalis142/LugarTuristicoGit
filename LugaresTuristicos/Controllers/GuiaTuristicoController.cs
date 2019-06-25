using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LugaresTuristicos.DB;
using LugaresTuristicos.Models;
using LugaresTuristicos.Interfaces.IServicios;

namespace LugaresTuristicos.Controllers
{
    public class GuiaTuristicoController : Controller 
    {
        DBEntradasEntities2 context = new DBEntradasEntities2();


        private IGuiaTuristicoServicio servicio;
        public GuiaTuristicoController(IGuiaTuristicoServicio servicio)
        {
            this.servicio = servicio;
        }
        public ViewResult Index()
        {
            var guias = servicio.ObtenerGuias();

            return View("Index", guias);
        }

        public ViewResult FormGuardar()
        {
            return View("FormGuardar", new GuiaTuristico());
        }

        public ActionResult Guardar(GuiaTuristico guia)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", guia);
            }
            servicio.AddGuiaTuristico(guia);
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = servicio.GetGuiaEditar(id);

            return View("FormEditar", model);
        }

        public ActionResult Actualizar(GuiaTuristico guia)
        {
            //GuiaTuristico guiaDB = context.GuiaTuristicos
                //.Find(guia.IdGuiaTuristico);
            //guiaDB.Nombre = guia.Nombre;
            //guiaDB.Apellido = guia.Apellido;
            //guiaDB.NumTelefono = guia.NumTelefono;
            //guiaDB.Descripcion = guia.Descripcion;
            //guiaDB.Horario = guia.Horario;

            //context.SaveChanges();
            servicio.ActualizarGuia(guia);
            return RedirectToAction("Index");
        }
        public RedirectToRouteResult Eliminar(int id)
        {
            //var guia = context.GuiaTuristicos
            //    .Where(o => o.IdGuiaTuristico == id)
            //    .FirstOrDefault();
            //context.GuiaTuristicos.Remove(guia);
            //context.SaveChanges();

            servicio.GetGuiaEliminar(id);

            return RedirectToAction("Index");
        }
    }
}