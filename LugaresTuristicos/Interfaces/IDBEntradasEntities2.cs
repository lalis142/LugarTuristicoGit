using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaresTuristicos.Interfaces
{
    public interface IDBEntradasEntities2
    {
        IDbSet<Promocion> Promociones { get; set; }
        IDbSet<LugarTuristico> LugarTuristicos { get; set; }
        IDbSet<GuiaTuristico> GuiaTuristicos { get; set; }
        IDbSet<Clientes> Clientes { get; set; }
        IDbSet<Administrador> Administradores { get; set; }
        IDbSet<VentaEntra> VentaEntras { get; set; }

        int SaveChanges();
    }
}
