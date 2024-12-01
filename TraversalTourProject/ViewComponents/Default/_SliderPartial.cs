using Microsoft.AspNetCore.Mvc;

namespace TraversalTourProject.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
