using Microsoft.AspNetCore.Components;
using SIIC.ProyectoBlazor.Carlos_Eduardo.BL;
using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIIC.ProyectoBlazor.Carlos_Eduardo.Pages
{
    public partial class Empleados
    {
        //el overide es para que pueda mostrar la tabla y cuando se actualice , elimine o edite lo reescriba
        protected override async Task OnInitializedAsync()
        {
            await CargarEmpleados();
        }
        [Parameter]
        public List<EmpleadosClase> listaempleados { get; set; } = new List<EmpleadosClase>();
        [Parameter]
        public EmpleadosClase empleado { get; set; } = new EmpleadosClase();
        //inyeccion de empleadosBL 
        [Inject]
        private EmpleadosBL EmpleadosBL { get; set; }
        public async Task CargarEmpleados()
        {
            listaempleados = await EmpleadosBL.GetempleadosAsync();
        }
        //Se guarda el empleado cuando se le da guardar
        private async Task GuardarEmpleado()
        {
            bool resultado = await EmpleadosBL.AgregarEmpleadosAsync(empleado);
            await CargarEmpleados();

        }
        //Obtenemos el empleado que se va a editar cuando se le de clickl al boton
        private void EditarEmpleado(EmpleadosClase emp)
        {
            empleado = emp;
        }
        //Se actualiza el empleado cuando ya se le dio click
        private async Task ActualizarEmpleado()
        {
            bool resultado = await EmpleadosBL.ActualizarEmpleadosAsync(empleado);
            await CargarEmpleados();
        }

        //Se elimina el empleado cuando se le da click al boton
        private async Task EliminarEmpleado(EmpleadosClase emp)
        {
            bool resultado = await EmpleadosBL.BorrarEmpleadoAsync(emp.id);
            await CargarEmpleados();
        }
    }
}
