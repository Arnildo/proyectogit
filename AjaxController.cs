using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploMVCMio.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Segundo cambio pero ahora desde rama master
        public ActionResult ImportarPagina()
        {
            return View();
        }

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