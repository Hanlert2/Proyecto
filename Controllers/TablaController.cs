using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consola.Models;
using Consola.Models.ViewsModel;

namespace Consola.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<Lista> lst;
            using (SISTEMA_ANTECEDENTEEntities db = new SISTEMA_ANTECEDENTEEntities())
            {
                 lst = (from d in db.USUARIO
                           select new Lista()
                           {
                               Id = d.id,
                               nombre = d.Nombre,
                               apellido = d.Apellido,
                               cedula = d.Cedula,
                               direccion = d.Direccion,
                               correoElectronico = d.Email,
                               rol = d.Rolid,
                               usuarioEstado=d.Usuario_estado,
                               correAlternativo=d.Email_alternativo,

                               

                           }).ToList();
                                                          
            }



                return View(lst);
        }
        [HttpGet]
        public ActionResult Nuevo() 
        {

            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(Tabla model) 
        {
            try {
                if (ModelState.IsValid)
                {

                    using (SISTEMA_ANTECEDENTEEntities db = new SISTEMA_ANTECEDENTEEntities())
                    {

                        var lst = new USUARIO();
                        lst.id = model.Id;
                        lst.Nombre = model.nombre;
                        lst.Apellido = model.apellido;
                        lst.Cedula = model.cedula;
                        lst.Direccion = model.direccion;
                        lst.Email = model.correoElectronico;
                        lst.Email_alternativo = model.correoAlternativo;
                        lst.Rolid = model.rol;
                        lst.Contraseña = model.contraseña;
                        lst.Usuario_estado = 1;
                        lst.Usuario_create = DateTime.Now.ToString();

                        db.USUARIO.Add(lst);
                        db.SaveChanges();
                    }
                    return Redirect("~/Tabla/Index/");
                }

                return View();
            }
           

            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            
            }
            
        }
        [HttpGet]
        public ActionResult Editar(int Id)
        {
            Tabla per = new Tabla();
            using (SISTEMA_ANTECEDENTEEntities db = new SISTEMA_ANTECEDENTEEntities())
            {
                var lst = db.USUARIO.Find(Id);
                    per.nombre = lst.Nombre;
                per.apellido = lst.Apellido;
                per.cedula = lst.Cedula;
                per.direccion = lst.Direccion;
                per.correoElectronico = lst.Email;
                per.correoAlternativo = lst.Email_alternativo;
                per.contraseña = lst.Contraseña;
                per.rol = lst.Rolid;




            }

                return View(per);
        }
        [HttpPost]
        public ActionResult Editar(Tabla model) 
        {
            try 
            {
                if (ModelState.IsValid) 
                {
                    using (SISTEMA_ANTECEDENTEEntities db = new SISTEMA_ANTECEDENTEEntities()) 
                    {
                        var per = db.USUARIO.Find(model.Id);
                        per.id = model.Id;
                        per.Nombre = model.nombre;
                        per.Apellido = model.apellido;
                        per.Cedula = model.cedula;
                        per.Direccion = model.direccion;
                        per.Email = model.correoElectronico;
                        per.Email_alternativo = model.correoAlternativo;
                        per.Contraseña = model.contraseña;
                        per.Rolid = model.rol;

                        db.Entry(per).State= System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }
                    return Redirect("~/Tabla/Index");
                
                }
                return View();
            
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        
        } 
        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            
            using (SISTEMA_ANTECEDENTEEntities db = new SISTEMA_ANTECEDENTEEntities())
            {
                var per = db.USUARIO.Find(Id);
                per.Usuario_estado = 0;
                db.Entry(per).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


            }

            return Redirect("~/Tabla/Index/");
        }
       
    }
}