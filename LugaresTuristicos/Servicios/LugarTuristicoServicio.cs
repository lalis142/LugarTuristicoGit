using LugaresTuristicos.Interfaces;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Servicios
{
    public class LugarTuristicoServicio : ILugarTuristicoServicio
    {
        private IDBEntradasEntities2 context;

        public LugarTuristicoServicio(IDBEntradasEntities2 context)
        {
            this.context = context;
        }


        public List<LugarTuristico> ObtenerLugarTuristicos()
        {
            return context.LugarTuristicos
                .ToList();
        }

        public void AddLugarTuristico( LugarTuristico lugar)
        {
            context.LugarTuristicos.Add(lugar);
            context.SaveChanges();
        }

        public LugarTuristico GetLugarEditar(int id)
        {
            var model = context.LugarTuristicos
                .Where(o => o.IdLugarTuristico == id)
                .FirstOrDefault();
            return model;
        }

        public void ActualizarLugar(LugarTuristico lugar)
        {
            LugarTuristico lugarDB = context.LugarTuristicos
                .Find(lugar.IdLugarTuristico);
            lugarDB.Nombre = lugar.Nombre;
            lugarDB.PrecioNino = lugar.PrecioNino;
            lugarDB.PrecioAdulto = lugar.PrecioAdulto;
            lugarDB.Ubicacion = lugar.Ubicacion;
            lugarDB.Descripcion = lugar.Descripcion;
            lugarDB.Imagen = lugar.Imagen;

            context.SaveChanges();
        }

        public LugarTuristico GetLugarEliminar(int id)
        {
            var lugar = context.LugarTuristicos
                .Where(o => o.IdLugarTuristico == id)
                .FirstOrDefault();
            context.LugarTuristicos.Remove(lugar);
            context.SaveChanges();
            return lugar;
        }

    }
}