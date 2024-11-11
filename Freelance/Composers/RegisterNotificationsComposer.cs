using Freelance.Notifications;

using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace Freelance.Composers;

public class RegisterNotificationsComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddNotificationHandler<ContentSavingNotification, ContentSavingNotificationHandler>();
    }
}
