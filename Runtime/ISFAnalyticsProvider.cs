using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public interface ISFAnalyticsProvider
    {
        void Connect(string userId = default);
        void SendCustomAnalyticsEvent(SFCustomAnalyticsEvent sfCustomAnalyticsEvent);
    }
}