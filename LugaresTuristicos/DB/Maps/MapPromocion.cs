using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using LugaresTuristicos.Models;

namespace LugaresTuristicos.DB.Maps
{
    public class MapPromocion : EntityTypeConfiguration<Promocion>
    {
        public MapPromocion()
        {
            ToTable("Promocion");
            HasKey(o => o.IdPromocion);

            HasRequired(o => o.GuiaTuristicos)
                .WithMany(o => o.Promociones)
                .HasForeignKey(o => o.IdGuiaTuristico);

            HasMany(o => o.LugarTuristicos)
                .WithRequired(o => o.Promociones)
                .HasForeignKey(o => o.IdPromocion);
        }
    }
}