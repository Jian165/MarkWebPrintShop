using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarkWebPrintShop.Models;
using MarkWebPrintShop.Data;
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
    }
}