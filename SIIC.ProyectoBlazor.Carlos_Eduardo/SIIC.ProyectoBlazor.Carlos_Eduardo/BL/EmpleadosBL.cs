using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.APIWebClient;
using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIIC.ProyectoBlazor.Carlos_Eduardo.BL
{
    public class EmpleadosBL
    {
        EmpleadosAPI empleadosBl;
        public EmpleadosBL(EmpleadosAPI _empleadosBL)
        {
            this.empleadosBl = _empleadosBL;
        }
        public async Task<List<EmpleadosClase>> GetempleadosAsync()
        {
            var empleados = await empleadosBl.GetempleadosAsync();
            return empleados;
        }
        public async Task<bool> AgregarEmpleadosAsync(EmpleadosClase empleados)
        {
            var resultado = await empleadosBl.AgregarEmpleadosAsync(empleados);
            return resultado;
        }
        public async Task<bool> ActualizarEmpleadosAsync(EmpleadosClase empleados)
        {
            var guardo = await empleadosBl.ActualizarEmpleadosAsync(empleados);
            return guardo;
        }
        public async Task<bool> BorrarEmpleadoAsync(Guid id)
        {
            var empleados = await empleadosBl.EliminarEmpleadoAsync(id);
            return empleados;
        }
    }
}
