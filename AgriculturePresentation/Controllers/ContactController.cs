using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
        {
            var value = _contactService.GetListAll();
            return View(value);
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {

            return PartialView();
        }
        [HttpPost]
		public IActionResult SendMessage(Contact contact)
		{
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
			return RedirectToAction("Index","Default");
		}

        public PartialViewResult ScrpitPartial()
        {
            return PartialView();
        }
        public IActionResult mesajıGör(int id)
        {
            var value = _contactService.GetById(id);
            return View(value);
           
        }
        [HttpPost]
        public IActionResult mesajıGör(Contact contact )
        {
            _contactService.Update(contact);
            return RedirectToAction("Index");
        }


    }
}
