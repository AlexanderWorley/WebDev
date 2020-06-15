using ISM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.InventoryProcessor;

// This is the actions that the controller in the MVC will use to go from front end to back end. 
namespace ISM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Support()
        {            
            return View();
        
        }

        public ActionResult Deskpro()
        {
            return Redirect("https://support.ccfi.com/agent/login?return=/agent/");

        }

        public ActionResult ViewAssets()
        {
            ViewBag.Message = "Asset List";

            var data = LoadInventory();
            List<InventoryModel> Inventory = new List<InventoryModel>();
            foreach (var row in data)
            {
                Inventory.Add(new InventoryModel
                {
                    Manufacturer = row.Manufacturer,
                    SerialNumber = row.SerialNumber,
                    MacAddress = row.MacAddress,
                    AssignedUser = row.AssignedUser,
                    EnteredAgent = row.EnteredAgent,
                    AgentCheckOut = row.AgentCheckOut
                });
            }
            return View(Inventory);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Inventory()
        {
            ViewBag.Message = "ISM Asset form";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Inventory(InventoryModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateAsset(
                    model.Manufacturer,
                    model.SerialNumber, 
                    model.MacAddress, 
                    model.AssignedUser, 
                    model.EnteredAgent, 
                    model.AgentCheckOut);

                return RedirectToAction("Inventory");
            }

            return View();
        }
    }
}