using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases;
using Newtonsoft.Json;

namespace SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.APIWebClient
{
    public class EmpresasAPI : HttpClient
    {
        public EmpresasAPI(String urlServer)
        {
            /*Se contantena la ruta ya que el link tiene varias rutas*/
            urlServer += (urlServer.EndsWith('/')) ? "api/Empresas/" : "api/Empresas/";
            BaseAddress = new Uri(urlServer);
        }

        //SE CREAN LAS FUNCIONES-METODOS 
        //LOS CUALES PODRAN SER LLAMADOS DESDE BL(ES EL PUENTE A PAGES)

        /*funcion para obtener las empresas y guardarlas en una lista*/
        public async Task<List<EmpresasClase>> GetEmpresasAsync()
        {
            try
            {
                //List<Empleados> Lista = new List<Empleados>();
                                                                                  /*ruta*/
                var Lista = await this.GetFromJsonAsync<List<EmpresasClase>>("ObtenerEmpresas");
                return Lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<EmpresasClase>();
                throw;
            }
        }
        /*funcion para poder agregar una empresa*/
        public async Task<bool> AgregarEmpresasAsync(EmpresasClase empresas)
        {
            try
            {
                                                          /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("GuardarEmpresa", empresas);
                if (resultado.IsSuccessStatusCode)
                {
                    var s = resultado.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<bool>(s);
                    return response;

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }
        /*funcion para poder actualizar una empresa*/
        public async Task<bool> ActualizarEmpresasAsync(EmpresasClase empresas)
        {
            try
            {
                                                          /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("ActualizarEmpresa", empresas);
                if (resultado.IsSuccessStatusCode)
                {
                    var s = resultado.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<bool>(s);
                    return response;

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }
        /*funcion para eliminar una empresa */
        public async Task<bool> EliminarEmpresasAsync(Guid id)
        {
            try
            {
                                                  /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("EliminarEmpresa", id);
                if (resultado.IsSuccessStatusCode)
                {
                    var s = resultado.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<bool>(s);
                    return response;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }
    }
}
