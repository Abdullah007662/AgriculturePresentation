using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceServices _serviceServices;

        public ServiceController(IServiceServices serviceServices)
        {
            _serviceServices = serviceServices;
        }

        public IActionResult Index()
        {
            var values = _serviceServices.GetListAll();
            return View(values);
        }
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel service)
        {
            if (ModelState.IsValid)
            {
                _serviceServices.Insert(new Service()
                {
                    Title = service.Title,
                    Image = service.Image,
                    Description = service.Description

                });
                return RedirectToAction("Index");

            }

            return View(service);

        }
        public IActionResult DeleteService(int id)
        {
            // İlkten Silinecek Degeri Buluyoruz İd İle Sonra Bu Degeri Siliyoruz.
            var value = _serviceServices.GetById(id);
            _serviceServices.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult EditService(int id)
        {
            var values = _serviceServices.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceServices.Update(service);
            return RedirectToAction("Index");
        }
        public IActionResult Deneme()
        {
            return View();
        }
        
    }
}
