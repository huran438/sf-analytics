using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public class SFAnalyticsService : ISFAnalyticsService
    {
        public UniTask Init(CancellationToken cancellationToken)
        {
           return UniTask.CompletedTask;
        }

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