using EPiServer.Core;

namespace AlloyEpiMeetup.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
