using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LugaresTuristicos.DB.Maps
{
    public class MapAdministrador : EntityTypeConfiguration<Administrador>
    {
        public MapAdministrador()
        {
            ToTable("Administrador");
            HasKey(o => o.IdAdministrador);
            
        }
    }
}