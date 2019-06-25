using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaresTuristicos.Interfaces.IServicios
{
    public interface ILugarTuristicoServicio
    {
        List<LugarTuristico> ObtenerLugarTuristicos();
        void AddLugarTuristico(LugarTuristico lugar);
        LugarTuristico GetLugarEditar(int id);
        void ActualizarLugar(LugarTuristico lugar);
        LugarTuristico GetLugarEliminar(int id);
    }
}
