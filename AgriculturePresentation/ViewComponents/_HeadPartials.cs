using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _HeadPartials : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
