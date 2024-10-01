using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _ServicePartial: ViewComponent
	{
		private readonly IServiceServices _serviceServices;

		public _ServicePartial(IServiceServices serviceServices)
		{
			_serviceServices = serviceServices;
		}

		public IViewComponentResult Invoke()
		{
			var value = _serviceServices.GetListAll();
			return View(value);
		}
	}
}
