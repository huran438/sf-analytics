using System.Collections.Generic;

namespace SFramework.Analytics.Runtime
{
    public class SFAnalyticsService : ISFAnalyticsService
    {
        private List<ISFAnalyticsProvider> _analyticsServices = new List<ISFAnalyticsProvider>();

        public void RegisterProvider(ISFAnalyticsProvider analyticsProvider)
        {
            _analyticsServices.Add(analyticsProvider);
        }

        public void Connect(string userId = default)
        {
            foreach (var analyticsService in _analyticsServices)
            {
                analyticsService?.Connect(userId);
            }
        }

        public void SendCustomAnalyticsEvent<T>(T customAnalyticsEventModel) where T : SFCustomAnalyticsEvent
        {
            foreach (var analyticsService in _analyticsServices)
            {
                analyticsService?.SendCustomAnalyticsEvent(customAnalyticsEventModel);
            }
        }
    }
}