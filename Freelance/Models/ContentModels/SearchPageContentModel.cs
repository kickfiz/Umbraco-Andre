
using Freelance.Models.Search;
using Freelance.Models.ViewModels;

namespace Freelance.Models.ContentModels;

public class SearchPageContentModel(IPublishedContent? content) : ContentModel(content)
{
    public SearchRequestModel? SearchRequest { get; set; }
	public SearchResponseModel? SearchResponse { get; set; }
	public PaginationViewModel? Pagination { get; set; }
}
