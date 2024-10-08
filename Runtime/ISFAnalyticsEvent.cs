﻿using System.Collections.Generic;

namespace SFramework.Analytics.Runtime
{
    public interface ISFAnalyticsEvent
    {
        public string Id { get; }
        public Dictionary<string, string> Params { get; }
    }
}