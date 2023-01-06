using System;
using UnityEngine;

namespace SFramework.Analytics.Runtime
{
    [Serializable]
    public struct SFAnalyticsParameter
    {
        public SFAnalyticsEventParameterTypes ParameterType => parameterType;
        public string ParameterName => parameterName;
        public object ParameterValue => parameterValue;

        [SerializeField]
        private SFAnalyticsEventParameterTypes parameterType;
        
        private string parameterName;

        private object parameterValue;

        public SFAnalyticsParameter(SFAnalyticsEventParameterTypes _parameterType, string _parameterName, object _parameterValue)
        {
            parameterType = _parameterType;
            parameterName = _parameterName;
            parameterValue = _parameterValue;
        }

        public void SetParameter(SFAnalyticsEventParameterTypes _parameterType, object _parameterValue)
        {
            parameterType = _parameterType;
            parameterValue = _parameterValue;
        }
    }
}