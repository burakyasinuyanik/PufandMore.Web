using Microsoft.AspNetCore.Mvc;

namespace PufandMore.Web.ViewComponents.LayoutComponents
{
    public class _UILayoutFooterComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
