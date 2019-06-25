using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LugaresTuristicos.Models;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.DB;

namespace LugaresTuristicos.Controllers
{
    public class PromocionController : Controller
    {
        DBEntradasEntities2 context = new DBEntradasEntities2();

        private IGuiaTuristicoServicio servicioGuiaTuristico;
        private IPromocionServicio servicioPromociones;
        public PromocionController(IPromocionServicio servicioPromociones, IGuiaTuristicoServicio servicioGuiaTuristico)
        {
            this.servicioGuiaTuristico = servicioGuiaTuristico;
            this.servicioPromociones = servicioPromociones;
        }
        public ViewResult Index()
        {
            var promociones = servicioPromociones.ObtenerPromociones();
            return View("Index", promociones);
        }

        public ViewResult FormGuardar()
        {
            ViewBag.GuiaTuristicos = servicioGuiaTuristico.ObtenerGuias(); //context.GuiaTuristicos.ToList();
            return View("FormGuardar", new Promocion());
        }

        public ActionResult Guardar(Promocion promocion)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", promocion);
            }
            servicioPromociones.AddPromocion(promocion);
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = servicioPromociones.GetPromocionEditar(id);
            ViewBag.GuiaTuristicos = servicioGuiaTuristico.ObtenerGuias();
            return View("FormEditar", model);
        }

        public RedirectToRouteResult Actualizar(Promocion promocion)
        {
            servicioPromociones.ActualizarPromocion(promocion);
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            servicioPromociones.GetLugarEliminar(id);

            return RedirectToAction("Index");
        }
    }
}