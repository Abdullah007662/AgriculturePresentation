using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOwerviewPartial:ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.curretMonthmessage = 3;

            ViewBag.announcementTrue = c.AnnounCemets.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.AnnounCemets.Where(x => x.Status == false).Count();
            return View();
        }
    }
}
