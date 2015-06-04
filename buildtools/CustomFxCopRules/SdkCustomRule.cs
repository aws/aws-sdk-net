using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FxCop.Sdk;
using System.Reflection;

namespace CustomFxCopRules
{
    internal abstract class SdkCustomRule : BaseIntrospectionRule
    {
        protected SdkCustomRule(string ruleName)
            : base(ruleName, "CustomFxCopRules.CustomFxCopRulesMetadata", typeof(SdkCustomRule).Assembly)
        { }
    }
}
