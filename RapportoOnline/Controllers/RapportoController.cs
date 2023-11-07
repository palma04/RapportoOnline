using Microsoft.AspNetCore.Mvc;
using RapportoOnline.Models;
using System.Reflection.Metadata.Ecma335;

namespace RapportoOnline.Controllers
{
    public class RapportoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            AnagraficaModel model = new AnagraficaModel();  
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(AnagraficaModel anagraficaModel)
        {
            return View(anagraficaModel);
        }

        public IActionResult SalvaRapporto(AnagraficaModel anagraficaModel)
        {
            AnagraficaModel anagrafica = anagraficaModel;
            try
            {
                if(anagrafica.Name != null && anagrafica.Surname != null && anagrafica.Servizio != null )
                {
                    if(anagrafica.Servizio == true)
                    {
                        if (anagrafica.Pioniere == true)
                        {
                            if(anagrafica.Ore == null)
                            {
                                anagrafica.success = false;
                                anagrafica.message = "Inserisci tutti i dati richiesti";
                                return View("index", anagrafica);

                            }
                        }
                        if(anagrafica.Servizio == true)
                        {
                            if (anagrafica.St == null)
                            {
                                anagrafica.success = false;
                                anagrafica.message = "Inserisci tutti i dati richiesti";
                                return View("index", anagrafica);

                            }
                        }
                    }

                }
                else
                {
                    anagrafica.success = false;
                    anagrafica.message = "Inserisci tutti i dati richiesti";
                    return View("index", anagrafica);
                }

            }catch (Exception ex)
            {
                anagrafica.success = false;
                anagrafica.message = ex.Message;
                return View("index",anagrafica);
            }
            return View("Successo");
        }
    }
}
