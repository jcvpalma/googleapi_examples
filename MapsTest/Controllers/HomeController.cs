using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GoogleMapsAPI;
using System.Configuration;

namespace MapsTest.Controllers
{
    public class HomeController : Controller
    {

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult ApiDistance()
        {
            var _conf = ConfigurationManager.AppSettings;
            GoogleDirectionApi _api = new GoogleDirectionApi(_conf["googleApiKey"].ToString());

            Coordenadas origem = new Coordenadas(-23.83, -46.8128);//Escola
            Coordenadas destino = new Coordenadas(-23.93065130660045, -46.908960719604465);//Aluno

            var res = _api.getDirectionsService(origem, destino);

            return View();
        }


        public JsonResult getDistance(string origem, string destino)
        {
 
            var retorno = String.Empty;
            

            return Json(retorno);
        }

        public ActionResult ModalTest()
        {
            return View();
        }

    }
}
