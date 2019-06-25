using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using LugaresTuristicos.Models;

namespace LugaresTuristicos.DB.Maps
{
    public class MapGuiaTuristico : EntityTypeConfiguration<GuiaTuristico>
    {
        public MapGuiaTuristico()
        {
            ToTable("GuiaTuristico");
            HasKey(o => o.IdGuiaTuristico);

            HasMany(o => o.Promociones)
                .WithRequired(o => o.GuiaTuristicos)
                .HasForeignKey(o => o.IdGuiaTuristico);
        }
    }
}