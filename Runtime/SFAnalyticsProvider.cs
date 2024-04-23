using SFramework.Core.Runtime;
using UnityEngine;

namespace SFramework.Analytics.Runtime
{
    public sealed class SFAnalyticsProvider : ISFAnalyticsProvider
    {
        public void SendCustomAnalyticsEvent(ISFAnalyticsEvent analyticsEvent)
        {
            Debug.Log($"[ANALYTICS] - EVENT <color=yellow>{analyticsEvent.Id}</color> SENT");
        }

        public void Dispose()
        {
        }
    }
}