using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploMVCMio.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult ImportarPagina()
        {
            return View();
        }
        // GET: Cambio desde rama testing
        public ActionResult ImportarSeccion()
        {
            return View();
        }

        public ActionResult AjaxSeccion()
        {
            return View();
        }

        public ActionResult PaginaContenido()
        {
            return View();
        }

        public JsonResult FechaHoraAjax(string id)
        {
            try
            {
                return Json(new 
                {
                    Fecha = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"),
                    Estado = "Ok",
                    Variable = id
                });
            }
            catch (Exception)
            {
                return Json(new { Estado = "Error" });
                throw;
            }
        }
    }
}