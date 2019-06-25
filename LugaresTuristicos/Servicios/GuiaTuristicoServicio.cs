using LugaresTuristicos.Interfaces;
using LugaresTuristicos.Interfaces.IServicios;
using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.Servicios
{
    public class GuiaTuristicoServicio: IGuiaTuristicoServicio
    {
        private IDBEntradasEntities2 context;
        public GuiaTuristicoServicio(IDBEntradasEntities2 context)
        {
            this.context = context;
        }

        public List<GuiaTuristico> ObtenerGuias()
        {
            return context.GuiaTuristicos
                .ToList();
        }

        public void AddGuiaTuristico(GuiaTuristico guia)
        {
            context.GuiaTuristicos.Add(guia);
            context.SaveChanges();
        }

        public GuiaTuristico GetGuiaEditar(int id)
        {
            var model = context.GuiaTuristicos
                .Where(o => o.IdGuiaTuristico == id)
                .FirstOrDefault();
            return model;
        }

        public void ActualizarGuia(GuiaTuristico guia)
        {
            GuiaTuristico guiaDB = context.GuiaTuristicos
                .Find(guia.IdGuiaTuristico);
            guiaDB.Nombre = guia.Nombre;
            guiaDB.Apellido = guia.Apellido;
            guiaDB.NumTelefono = guia.NumTelefono;
            guiaDB.Descripcion = guia.Descripcion;
            guiaDB.Horario = guia.Horario;

            context.SaveChanges();
        }

        public GuiaTuristico GetGuiaEliminar(int id)
        {
            var guia = context.GuiaTuristicos
                .Where(o => o.IdGuiaTuristico == id)
                .FirstOrDefault();
            context.GuiaTuristicos.Remove(guia);
            context.SaveChanges();
            return guia;
        }
    }
}