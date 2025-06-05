using System.Collections.Generic;
using SFramework.Core.Runtime;

namespace SFramework.Analytics.Runtime
{
    public abstract class SFAnalyticsEvent : ISFAnalyticsEvent, ISFInjectable
    {
        protected SFAnalyticsEvent()
        {
            this.Inject();
        }

        public abstract string Id { get; }
        public Dictionary<string, string> Params { get; } = new();
    }
}