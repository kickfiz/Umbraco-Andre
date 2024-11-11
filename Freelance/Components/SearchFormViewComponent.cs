﻿using Freelance.Models.Search;

using Microsoft.AspNetCore.Mvc;

namespace Freelance.Components;

[ViewComponent(Name = "SearchForm")]

public class SearchFormViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(SearchRequestModel model)
    {
        return View(model);
    }
}
