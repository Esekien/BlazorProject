using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIIC.ProyectoBlazor.Carlos_Eduardo.ApiClient.Clases
{
    public class EmpleadosClase
    {
        /*son las propiedades que tiene la api empleados*/
        public Guid id { get; set; } = Guid.NewGuid();
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public Object activo { get; set; }
        public string idEmpresa { get; set; }
    }
}
