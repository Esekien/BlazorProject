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
    public class EmpleadosAPI : HttpClient
    {
        public EmpleadosAPI(String urlServer)
        {
            /*Se contantena la ruta ya que el link tiene varias rutas*/
            urlServer += (urlServer.EndsWith('/')) ? "api/empleados/" : "/api/empleados/";
            BaseAddress = new Uri(urlServer);
        }

        //SE CREAN LAS FUNCIONES-METODOS 
        //LOS CUALES PODRAN SER LLAMADOS DESDE BL(ES EL PUENTE A PAGES)


        /*funcion para obtener las empleados y guardarlas en una lista*/
        public async Task<List<EmpleadosClase>> GetempleadosAsync()
        {
            try
            {
                //List<Empleados> Lista = new List<Empleados>();
                                                                                   /*ruta*/
                var Lista = await this.GetFromJsonAsync<List<EmpleadosClase>>("ObtenerEmpleados");
                return Lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<EmpleadosClase>();
                throw;
            }
        }
        /*funcion para agregar un empleado*/
        public async Task<bool> AgregarEmpleadosAsync(EmpleadosClase empleados)
        {
            try
            {
                                                         /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("GuardarEmpleado", empleados);
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
        /*funcion para actualizar empleado*/
        public async Task<bool> ActualizarEmpleadosAsync(EmpleadosClase empleados)
        {
            try
            {
                                                            /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("ActualizarEmpleado", empleados);
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
        /*funcion para eliminar empleado*/
        public async Task<bool> EliminarEmpleadoAsync(Guid id)
        {
            try
            {
                                                      /*ruta y el parametro que recibe*/
                var resultado = await this.PostAsJsonAsync("EliminarEmpleado", id);
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
