using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarkWebPrintShop.Models;
using MarkWebPrintShop.Data;
using System.Data.Common;
namespace MarkWebPrintShop.Conrollers
{
    public class ServiceController :Controller
    {
        private readonly  ApplicationDBContext _db;
        public ServiceController (ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Service> objServiceList = _db.Services.ToList();
            return View(objServiceList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Service obj)
        {
            if(obj.ServiceName.ToLower() == obj.Description.ToLower())
            {
               ModelState.AddModelError("description","Description must no be the same as service name");
            }
            if(ModelState.IsValid)
            {
                _db.Services.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "New Service Has Beend Added!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        public IActionResult Edit(int? serviceId)
        {
            if(serviceId==null || serviceId==0)
            {
                return NotFound();
            }
            
            Service? serviceObj = _db.Services.Find(serviceId);
            if(serviceObj == null)
            {
                return NotFound();
            }
            return View(serviceObj);
        }

        [HttpPost]
        public IActionResult Edit(Service obj)
        {
            if(ModelState.IsValid)
            {
                _db.Services.Update(obj);
                _db.SaveChanges();

                TempData["success"] = $"{obj.ServiceName }Successfuly Updated!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? serviceId)
        {
            if(serviceId==null || serviceId==0)
            {
                return NotFound();
            }
            
            Service? serviceObj = _db.Services.Find(serviceId);
            if(serviceObj == null)
            {
                return NotFound();
            }
            return View(serviceObj);
        }


        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? serviceId)
        {
            Service obj = _db.Services.Find(serviceId);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Services.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Service Successfuly Removed!";
            return RedirectToAction("Index");
        }
        
    }
}