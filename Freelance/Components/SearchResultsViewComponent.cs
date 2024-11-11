using Freelance.Models.Search;

using Microsoft.AspNetCore.Mvc;

namespace Freelance.Components;

[ViewComponent(Name = "SearchResults")]

public class SearchResultsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(SearchResponseModel model)
    {
        return View(model);
    }
}
