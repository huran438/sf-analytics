using System.Collections.Generic;

namespace SFramework.Analytics.Runtime
{
    public class SFAnalyticsService : ISFAnalyticsService
    {
        private List<ISFAnalyticsProvider> _analyticsServices = new();

        public ISFAnalyticsService RegisterProvider(ISFAnalyticsProvider analyticsProvider)
        {
            _analyticsServices.Add(analyticsProvider);
            return this;
        }

        public void SendCustomAnalyticsEvent<T>(T analyticsEvent) where T : ISFAnalyticsEvent
        {
            foreach (var analyticsService in _analyticsServices)
            {
                analyticsService?.SendCustomAnalyticsEvent(analyticsEvent);
            }
        }

        public void Dispose()
        {
        }
    }
}