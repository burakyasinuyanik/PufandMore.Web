using Microsoft.AspNetCore.Mvc;

namespace PufandMore.Web.ViewComponents.LayoutComponents
{
    public class _UILayoutScriptComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
