#pragma checksum "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f7b6755cc4a40b74925712166f9d5095c9c2e2"
// <auto-generated/>
#pragma warning disable 1591
namespace SIIC.ProyectoBlazor.Carlos_Eduardo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using SIIC.ProyectoBlazor.Carlos_Eduardo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using SIIC.ProyectoBlazor.Carlos_Eduardo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\_Imports.razor"
using SIIC.ProyectoBlazor.Carlos_Eduardo.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empleados")]
    public partial class Empleados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.AddMarkupContent(1, "<h3>Empleados</h3>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "form");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label>RFC</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "RFC");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                             empleado.rfc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.rfc = __value, empleado.rfc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<label>Nombre</label>\r\n            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "placeholder", "Nombre");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                empleado.nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.nombre = __value, empleado.nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<label>Apellidos</label>\r\n            ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "placeholder", "Apellidos");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                   empleado.apellidos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.apellidos = __value, empleado.apellidos));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, "<label>Direccion</label>\r\n            ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "placeholder", "Direccion");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                   empleado.direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.direccion = __value, empleado.direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.AddMarkupContent(62, "<label>Telefono</label>\r\n            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "placeholder", "Telefono");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                  empleado.telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.telefono = __value, empleado.telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.AddMarkupContent(74, "<label>Correo</label>\r\n            ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "placeholder", "Correo");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                empleado.correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => empleado.correo = __value, empleado.correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    <br>\r\n    ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "type", "reset");
            __builder.AddAttribute(86, "class", "btn btn-primary");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                           GuardarEmpleado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Agregar Empleado");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "type", "reset");
            __builder.AddAttribute(92, "class", "btn btn-primary");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                           ActualizarEmpleado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Actualizar Empleado");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(97, "table");
            __builder.AddAttribute(98, "class", "table");
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.AddMarkupContent(100, @"<thead>
        <tr>
            <th>id</th>
            <th>rfc</th>
            <th>nombre</th>
            <th>apellidos</th>
            <th>direccion</th>
            <th>telefono</th>
            <th>correo</th>
            <th>activo</th>
            <th>idEmpresa</th>
            <th>Editar</th>
            <th>Eliminar</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(101, "tbody");
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 59 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
         foreach (var e in listaempleados)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "            ");
            __builder.OpenElement(104, "tr");
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 62 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 63 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.rfc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 64 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 65 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                ");
            __builder.OpenElement(118, "td");
            __builder.AddContent(119, 
#nullable restore
#line 66 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                ");
            __builder.OpenElement(121, "td");
            __builder.AddContent(122, 
#nullable restore
#line 67 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "td");
            __builder.AddContent(125, 
#nullable restore
#line 68 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 69 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.activo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.OpenElement(130, "td");
            __builder.AddContent(131, 
#nullable restore
#line 70 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                     e.idEmpresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.OpenElement(133, "td");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "type", "button");
            __builder.AddAttribute(136, "class", "btn btn-info");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                         (()=>EditarEmpleado(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(138, "Editar ");
            __builder.OpenComponent<Feather.Blazor.Icons.FeatherEdit>(139);
            __builder.AddAttribute(140, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 71 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                                                                                 20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "Color", "#ffffff");
            __builder.AddAttribute(142, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 71 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                                                                                                                  1.8f

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddContent(143, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.OpenElement(145, "td");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "type", "button");
            __builder.AddAttribute(148, "class", "btn btn-danger");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                           (()=>EliminarEmpleado(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(150, "Eliminar ");
            __builder.OpenComponent<Feather.Blazor.Icons.FeatherDelete>(151);
            __builder.AddAttribute(152, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 72 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                                                                                         20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(153, "Color", "#ffffff");
            __builder.AddAttribute(154, "StrokeWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 72 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
                                                                                                                                                                                          1.8f

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 74 "C:\Users\carlo\source\repos\SIIC.ProyectoBlazor.Carlos_Eduardo\SIIC.ProyectoBlazor.Carlos_Eduardo\Pages\Empleados.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
