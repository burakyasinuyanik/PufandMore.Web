using Microsoft.AspNetCore.Mvc;

namespace PufandMore.Web.ViewComponents.LayoutComponents
{
    public class _UILayoutHeadComponentPartial:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
