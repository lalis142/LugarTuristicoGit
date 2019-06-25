using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaresTuristicos.Interfaces.IServicios
{
    public interface IPromocionServicio
    {
        List<Promocion> ObtenerPromociones();
        void AddPromocion(Promocion promocion);
        Promocion GetPromocionEditar(int id);
        void ActualizarPromocion(Promocion promocion);
        Promocion GetLugarEliminar(int id);
    }
}
