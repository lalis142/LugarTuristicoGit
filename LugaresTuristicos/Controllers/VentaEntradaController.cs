using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LugaresTuristicos.Models;
using LugaresTuristicos.DB;

namespace CompraEntradas.Controllers
{
    public class VentaEntradaController : Controller
    {
        private DBEntradasEntities2 context = new DBEntradasEntities2();

        public ViewResult Index()
        {
            var entradas = context.VentaEntras
                .Include(o => o.LugarTuristicos)
                .Include(o => o.Usuarios)
                .ToList();

            return View("Index", entradas);
        }

        public ViewResult FormGuardar()
        {
            ViewBag.LugarTuristicos = context.LugarTuristicos
                .ToList();
            ViewBag.Usuarios = context.Usuarios
                .ToList();
            return View("FormGuardar", new VentaEntra());
        }

        public ActionResult Guardar(VentaEntra entrada)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", entrada);
            }
            context.VentaEntras.Add(entrada);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = context.VentaEntras
                .Where(o => o.Id == id)
                .FirstOrDefault();
            ViewBag.LugarTuristicos = context.LugarTuristicos
                .ToList();
            ViewBag.Usuarios = context.Usuarios
                .ToList();
            return View("FormEditar", model);
        }

        public RedirectToRouteResult Actualizar(VentaEntra entrada)
        {
            VentaEntra entradaDB = context.VentaEntras
                .Where(o => o.Id == entrada.Id)
                .FirstOrDefault();
            entradaDB.CantidadEntraNino = entrada.CantidadEntraNino;
            entradaDB.CantidadEntraAdulto= entrada.CantidadEntraAdulto;
            entradaDB.FechaVisita = entrada.FechaVisita;
            entradaDB.IdUsuario = entrada.IdUsuario;
            entradaDB.IdLugarTuristico = entrada.IdLugarTuristico;
            entradaDB.PrecioTotal = entrada.PrecioTotal;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var entrada = context.VentaEntras
                .Where(o => o.Id == id)
                .FirstOrDefault();
            context.VentaEntras.Remove(entrada);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}