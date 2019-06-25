using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using LugaresTuristicos.Models;

namespace LugaresTuristicos.DB.Maps
{
    public class MapLugarTuristico : EntityTypeConfiguration<LugarTuristico>
    {
        public MapLugarTuristico()
        {
            ToTable("LugarTuristico");
            HasKey(o => o.IdLugarTuristico);

            HasMany(o => o.VentaEntras)
                .WithRequired(o => o.LugarTuristicos)
                .HasForeignKey(o => o.IdLugarTuristico);

            HasRequired(o => o.Promociones)
                .WithMany(o => o.LugarTuristicos)
                .HasForeignKey(o => o.IdPromocion);
        }
    }
}