using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LugaresTuristicos.Models;
using LugaresTuristicos.DB;
using LugaresTuristicos.Interfaces.IServicios;

namespace LugaresTuristicos.Controllers
{
    public class LugarTuristicoController : Controller
    {
        private DBEntradasEntities2 context = new DBEntradasEntities2();
        private ILugarTuristicoServicio servicio;

        public LugarTuristicoController(ILugarTuristicoServicio servicio)
        {
            this.servicio = servicio;
        }

        public ActionResult Index()
        {
            var lugares = servicio.ObtenerLugarTuristicos();
            return View(lugares);
        }

        public ViewResult FormGuardar()
        {
            return View("FormGuardar", new LugarTuristico());
        }

        public ActionResult Guardar(LugarTuristico lugar)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", lugar);
            }
            servicio.AddLugarTuristico(lugar);
            return RedirectToAction("Index");
        }
        public ActionResult FormEditar(int id)
        {

            var lugar = servicio.GetLugarEditar(id);
            return View(lugar);
        }
        public ActionResult Actualizar( LugarTuristico lugar)
        {
            //var lugarDB = context.LugarTuristicos
            //    .Find(lugar.IdLugarTuristico);
            //lugarDB.Nombre = lugar.Nombre;
            //lugarDB.PrecioNino = lugar.PrecioNino;
            //lugarDB.PrecioAdulto = lugar.PrecioAdulto;
            //lugarDB.Ubicacion = lugar.Ubicacion;
            //lugarDB.Descripcion = lugar.Descripcion;
            //lugarDB.Imagen = lugar.Imagen;

            //context.SaveChanges();
            servicio.ActualizarLugar(lugar);
            return RedirectToAction("Index");
        }
        public RedirectToRouteResult Eliminar(int id)
        {
            //var lugar = context.LugarTuristicos
            //    .Where(o => o.IdLugarTuristico == id)
            //    .FirstOrDefault();
            //context.LugarTuristicos.Remove(lugar);
            //context.SaveChanges();

            servicio.GetLugarEliminar(id);

            return RedirectToAction("Index");
        }
    }
}