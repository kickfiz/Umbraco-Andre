﻿using Freelance.Models.Search;

namespace Freelance.Services;

public interface ISearchService
{
    public SearchResponseModel Search(SearchRequestModel searchRequest);
}
