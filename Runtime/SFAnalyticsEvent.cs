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
        public abstract Dictionary<string, object> Params { get; }
    }
}