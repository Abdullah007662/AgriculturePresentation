using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AnnounCementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnounCementController(IAnnouncementService announcementService)
        {
            this._announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values=_announcementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnounCement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnounCement(AnnounCemet announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            _announcementService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnounCement(int id)
        {
            // İlkten Silinecek Degeri Buluyoruz İd İle Sonra Bu Degeri Siliyoruz.
            var value = _announcementService.GetById(id);
            _announcementService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult EditAnnounCement(int id)
        {
            var values = _announcementService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnounCement(AnnounCemet p)
        {
            _announcementService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }


    }
}
