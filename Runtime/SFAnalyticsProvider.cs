using SFramework.Core.Runtime;
using UnityEngine;

namespace SFramework.Analytics.Runtime
{
    public sealed class SFAnalyticsProvider : ISFAnalyticsProvider
    {
        public void SendCustomAnalyticsEvent(ISFAnalyticsEvent analyticsEvent)
        {
            SFDebug.Log("[ANALYTICS] - EVENT <color=yellow>{0}</color> SENT", analyticsEvent.Id);
        }

        public void Dispose()
        {
        }
    }
}