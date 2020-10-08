using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.APIWebClient;
using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIIC.ProyectoBlazor.Carlos_Eduardo.BL
{
    public class EmpresasBL
    {

        EmpresasAPI empresasBl;
        public EmpresasBL(EmpresasAPI _empresasBL)
        {
            this.empresasBl = _empresasBL;
        }
        /*Esta es la conexion entre APIClient y pages*/
        public async Task<List<EmpresasClase>> GetEmpresasAsync()
        {
            var empresas = await empresasBl.GetEmpresasAsync();
            return empresas;
        }
        public async Task<bool> AgregarEmpresasAsync(EmpresasClase empresas)
        {
            var resultado = await empresasBl.AgregarEmpresasAsync(empresas);
            return resultado;
        }
        public async Task<bool> ActualizarEmpresasAsync(EmpresasClase empresas)
        {
            var guardo = await empresasBl.ActualizarEmpresasAsync(empresas);
            return guardo;
        }
        public async Task<bool> BorrarEmpresasAsync(Guid id)
        {
            var empresas = await empresasBl.EliminarEmpresasAsync(id);
            return empresas;
        }
    }
}
