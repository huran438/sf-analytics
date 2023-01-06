using SFramework.Core.Runtime;
using UnityEngine;

namespace SFramework.Analytics.Runtime
{
    public class SFAnalyticsProvider : ISFAnalyticsProvider
    {
        public void Connect(string userId)
        {
            Debug.Log($"[ANALYTICS] - EVENT <color=yellow>CONNECTED</color>");
        }

        public void SendCustomAnalyticsEvent(SFCustomAnalyticsEvent sfCustomAnalyticsEvent)
        {
            Debug.Log($"[ANALYTICS] - EVENT <color=yellow>{sfCustomAnalyticsEvent.Name}</color> SENT");
        }
    }
}