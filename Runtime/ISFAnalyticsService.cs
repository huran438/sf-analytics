using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public interface ISFAnalyticsService : ISFService
    {
        void RegisterProvider(ISFAnalyticsProvider analyticsProvider);
        void Connect(string userId = default);
        void SendCustomAnalyticsEvent<T>(T customAnalyticsEventModel) where T : SFCustomAnalyticsEvent;
    }
}