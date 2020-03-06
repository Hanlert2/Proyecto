using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consola.Models.ViewsModel
{
    public class Tabla
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Nombre")]
        public string nombre { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Apellido")]
        public string apellido { get; set; }
        [Required]
        [StringLength(13)]
        [Display(Name ="Cedula")]
        public string cedula { get; set; }
        [Required]
        [Display(Name ="Direccion")]
        public string direccion { get; set; }
        [Required]
        [Display(Name ="Correo Electronico")]
        [EmailAddress]
        public string correoElectronico { get; set; }
        [Compare("correoElectronico")]
        [Display(Name ="Confirmar Correo")]
        public string confirmarCorreo { get; set; }
        [EmailAddress]
        [Display(Name ="Correo Alternativo")]
        public string correoAlternativo { get; set; }
        [Required]
        public int rol { get; set; }
        [Required]
        [Display(Name = "Activo")]
        public int estado = 1;
        [Required]
        public string contraseña { get; set; }
    }
}