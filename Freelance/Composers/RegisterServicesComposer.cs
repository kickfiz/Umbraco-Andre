using Freelance.Services;

using Umbraco.Cms.Core.Composing;

namespace Freelance.Composers;

public class RegisterServicesComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddTransient<ISearchService, SearchService>();
    }
}