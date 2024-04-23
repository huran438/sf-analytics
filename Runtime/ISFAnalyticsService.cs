using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public interface ISFAnalyticsService : ISFService
    {
        ISFAnalyticsService RegisterProvider(ISFAnalyticsProvider analyticsProvider);
        void SendCustomAnalyticsEvent<T>(T analyticsEvent) where T : ISFAnalyticsEvent;
    }
}