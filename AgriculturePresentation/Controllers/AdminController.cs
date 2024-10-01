using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}

		public IActionResult Index()
		{
			var value = _adminService.GetListAll();
			return View(value);
		}
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.Insert(admin);
            return RedirectToAction("Index");
        }
        public IActionResult AdminDelete(int id)
        {
            var values = _adminService.GetById(id);
            _adminService.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult AdminEdit(int id)
        {
            var value = _adminService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AdminEdit(Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }

    }
}
