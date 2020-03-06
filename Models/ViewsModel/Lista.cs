using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consola.Models.ViewsModel
{
    public class Lista
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string direccion { get; set; }
        public string correoElectronico { get; set; }
        public int usuarioEstado = 1;
        public int rol { get; set; }
        public string correAlternativo { get; set; }
        [Display(Name ="Activo")]
        public int estado = 1;
    }
}