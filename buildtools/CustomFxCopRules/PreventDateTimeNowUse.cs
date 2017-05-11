using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FxCop.Sdk;
using System.Reflection;

namespace CustomFxCopRules
{
    internal sealed class PreventDateTimeNowUseRule : SdkCustomRule
    {
        public PreventDateTimeNowUseRule()
            : base("PreventDateTimeNowUseRule")
        { }

        public override TargetVisibilities TargetVisibility
        {
            get
            {
                return TargetVisibilities.All;
            }
        }

        public override ProblemCollection Check(Member member)
        {
            var method = member as Method;
            CheckMethod(method);

            return Problems;
        }

        private void CheckMethod(Method method)
        {
            if (method == null || method.Instructions == null || method.Instructions.Count == 0)
                return;

            foreach (var instruction in method.Instructions)
            {
                var invokedMethod = instruction.Value as Method;
                if (invokedMethod != null)
                {
                    var fullMethodName = invokedMethod.FullName;
                    string forbiddenProperty;
                    if (DateTimeNowMethodMapping.TryGetValue(fullMethodName, out forbiddenProperty))
                    {
                        var resolution = GetResolution(method.Name.Name, method.DeclaringType.FullName, forbiddenProperty);
                        Problems.Add(new Problem(resolution));
                    }
                }
            }
        }

        public static Dictionary<string, string> DateTimeNowMethodMapping = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "System.DateTime.get_Now", "System.DateTime.Now" },
            { "System.DateTime.get_UtcNow", "System.DateTime.UtcNow" },
            { "System.DateTime.get_Today", "System.DateTime.Today" },
        };
    }
}
