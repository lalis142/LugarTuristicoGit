using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using LugaresTuristicos.Models;

namespace LugaresTuristicos.DB.Maps
{
    public class MapVentaEntra : EntityTypeConfiguration<VentaEntra>
    {
        public MapVentaEntra()
        {
            ToTable("VentaEntrada");
            HasKey(o => o.Id);

            HasRequired(o => o.LugarTuristicos)
                .WithMany(o => o.VentaEntras)
                .HasForeignKey(o => o.IdLugarTuristico);

            HasRequired(o => o.clientes)
                .WithMany(o => o.VentaEntras)
                .HasForeignKey(o => o.IdCliente);
        }
    }
}