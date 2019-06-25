using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LugaresTuristicos.Models;

namespace LugaresTuristicos.Interfaces.IServicios
{
    public interface IGuiaTuristicoServicio
    {
        List<GuiaTuristico> ObtenerGuias();
        void AddGuiaTuristico(GuiaTuristico guia);
        GuiaTuristico GetGuiaEditar(int id);
        void ActualizarGuia(GuiaTuristico guia);
        GuiaTuristico GetGuiaEliminar(int id);
    }
}
