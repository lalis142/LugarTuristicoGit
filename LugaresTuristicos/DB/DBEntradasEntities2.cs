using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LugaresTuristicos.Models;
using LugaresTuristicos.DB.Maps;
using LugaresTuristicos.Interfaces;

namespace LugaresTuristicos.DB
{
    public class DBEntradasEntities2 : DbContext, IDBEntradasEntities2
    {
        public IDbSet<LugarTuristico> LugarTuristicos { get; set; }
        public IDbSet<VentaEntra> VentaEntras { get; set; }
        public IDbSet<Clientes> Clientes { get; set; }
        public IDbSet<Administrador> Administradores { get; set; }

        public IDbSet<Promocion> Promociones { get; set; }
        public IDbSet<GuiaTuristico> GuiaTuristicos { get; set; }

        public DBEntradasEntities2()
        {
            Database.SetInitializer<DBEntradasEntities2>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MapGuiaTuristico());
            modelBuilder.Configurations.Add(new MapLugarTuristico());
            modelBuilder.Configurations.Add(new MapVentaEntra());
            modelBuilder.Configurations.Add(new MapCliente());
            modelBuilder.Configurations.Add(new MapAdministrador());
            modelBuilder.Configurations.Add(new MapPromocion());
        }
    }
}