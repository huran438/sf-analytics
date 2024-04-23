using System;
using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public interface ISFAnalyticsProvider : IDisposable
    {
        void SendCustomAnalyticsEvent(ISFAnalyticsEvent analyticsEvent);
    }
}