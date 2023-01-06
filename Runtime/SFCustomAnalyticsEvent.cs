using System;
using System.Collections.Generic;

namespace SFramework.Analytics.Runtime
{
    [Serializable]
    public abstract class SFCustomAnalyticsEvent
    {
        public abstract string Name { get; }
        public abstract List<SFAnalyticsParameter> AnalyticsParameters { get; }
    }
}