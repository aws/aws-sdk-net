using Microsoft.FxCop.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFxCopRules
{
    internal sealed class PreventHashAlgorithmCreateRule : SdkCustomRule
    {
        public PreventHashAlgorithmCreateRule()
            : base("PreventHashAlgorithmCreateRule")
        {
        }

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
                    if (HashAlgorithmCreateMethods.Contains(fullMethodName))
                    {
                        var resolution = GetResolution(method.Name.Name, method.DeclaringType.FullName, fullMethodName);
                        Problems.Add(new Problem(resolution));
                    }
                }
            }
        }

        public static HashSet<string> HashAlgorithmCreateMethods = new HashSet<string>(StringComparer.Ordinal)
        {
            "System.Security.Cryptography.HashAlgorithm.Create",
            "System.Security.Cryptography.HashAlgorithm.Create(System.String)"
        };
    }
}
