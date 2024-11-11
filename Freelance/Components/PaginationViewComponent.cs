using Freelance.Models.ViewModels;

using Freelance.Models.Search;

using Microsoft.AspNetCore.Mvc;

namespace Freelance.Components;

[ViewComponent(Name = "Pagination")]
public class PaginationViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(PaginationViewModel model)
    {
        model ??= new PaginationViewModel();

        return View(model);
    }
}