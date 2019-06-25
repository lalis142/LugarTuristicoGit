using LugaresTuristicos.Interfaces;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LugaresTuristicos.Servicios
{
    public class PromocionServicio: IPromocionServicio
    {
        private IDBEntradasEntities2 context;

        public PromocionServicio(IDBEntradasEntities2 context)
        {
            this.context = context;
        }

        public List<Promocion> ObtenerPromociones()
        {
            return context.Promociones
                .Include(o => o.GuiaTuristicos)
                .ToList();
        }

        public void AddPromocion(Promocion promocion)
        {
            context.Promociones.Add(promocion);
            context.SaveChanges();
        }

        public Promocion GetPromocionEditar(int id)
        {
            var model = context.Promociones
                .Where(o => o.IdPromocion == id)
                .FirstOrDefault();
            return model;
        }

        public void ActualizarPromocion(Promocion promocion)
        {
            Promocion promocionDB = context.Promociones
                .Where(o => o.IdPromocion == promocion.IdPromocion)
                .FirstOrDefault();
            promocionDB.Nombre = promocion.Nombre;
            promocionDB.Descripcion = promocion.Descripcion;
            promocionDB.FechaInicio = promocion.FechaInicio;
            promocionDB.FechaFin = promocion.FechaFin;
            promocionDB.IdGuiaTuristico = promocion.IdGuiaTuristico;
            context.SaveChanges();

            context.SaveChanges();
        }

        public Promocion GetLugarEliminar(int id)
        {
            var promocion = context.Promociones
                .Where(o => o.IdPromocion == id)
                .FirstOrDefault();
            context.Promociones.Remove(promocion);
            context.SaveChanges();
            return promocion;
        }
    }
}