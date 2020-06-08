using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRoslynAnalyzers
{
    public static class DiagnosticIds
    {
        // Category: AwsSdkRules
        public const string PreventMD5UseRuleId = "CR1000";
        public const string PreventHashAlgorithmCreateRuleId = "CR1001";
        public const string PreventStaticLoggersRuleId = "CR1002";
        public const string PreventDateTimeNowUseRuleId = "CR1003";
        public const string PreventRegionEndpointUseRuleId = "CR1004";
    }
}
