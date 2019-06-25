using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using LugaresTuristicos.Models;
using LugaresTuristicos.Servicios;

namespace LugaresTuristicos.DB.Maps
{
    public class MapCliente : EntityTypeConfiguration<Clientes>
    { 
        public MapCliente()
        {
            ToTable("Cliente");
            HasKey(o => o.IdCliente);
            HasMany(o => o.Lugares)
                .WithRequired(o => o.clientes)
                .HasForeignKey(o => o.IdClienteLugar);
        }
    }
}