using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SIIC.ProyectoBlazor.Carlos_Eduardo.BL;
using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases;
using Microsoft.AspNetCore.Components.Web;


namespace SIIC.ProyectoBlazor.Carlos_Eduardo.Pages
{
    public partial class Empresas
    {
        //el overide es para que pueda mostrar la tabla y cuando se actualice , elimine o edite lo reescriba
        protected override async Task OnInitializedAsync()
        {
            await CargarEmpresas();
        }
        [Parameter]
        public List<EmpresasClase> listaempresa { get; set; } = new List<EmpresasClase>();
        [Parameter]
        public EmpresasClase empresas { get; set; } = new EmpresasClase();
        //inyeccion de empleadosBL
        [Inject]
        private EmpresasBL EmpresasBL { get; set; }
        public async Task CargarEmpresas()
        {
            listaempresa = await EmpresasBL.GetEmpresasAsync();
        }

        //Se guarda el empresa cuando se le da guardar
        private async Task GuardarEmpresas()
        {
            bool resultado = await EmpresasBL.AgregarEmpresasAsync(empresas);
            await CargarEmpresas();

        }

        //Obtenemos el empresa que se va a editar cuando se le de clickl al boton
        private void EditarEmpresas(EmpresasClase emp)
        {
            empresas = emp;
        }
        //Se actualiza el empresa cuando ya se le dio click
        private async Task ActualizarEmpresas()
        {
            bool resultado = await EmpresasBL.ActualizarEmpresasAsync(empresas);
            await CargarEmpresas();
        }

        //Se elimina el empresa cuando se le da click al boton
        private async Task EliminarEmpresas(EmpresasClase emp)
        {
            bool resultado = await EmpresasBL.BorrarEmpresasAsync(emp.id);
            await CargarEmpresas();
        }


    }
}
