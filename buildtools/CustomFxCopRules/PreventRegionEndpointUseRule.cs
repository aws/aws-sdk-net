using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FxCop.Sdk;
using System.Reflection;

namespace CustomFxCopRules
{
    internal sealed class PreventRegionEndpointUseRule : SdkCustomRule
    {
        private const string USEast1EndpointName = ".USEast1";
        private const string USEast1ResolutionMessage = " Evaluate whether this usage is safe and add a suppression if it is.";
        private const string RegionEndpointStaticConstructorName = "Amazon.RegionEndpoint..cctor";
        private const string RegionEndpointTypeName = "Amazon.RegionEndpoint";
        private const string RegionEndpointFieldNamePrefix = RegionEndpointTypeName + ".";

        public PreventRegionEndpointUseRule()
            : base("PreventRegionEndpointUseRule")
        { }

        public override ProblemCollection Check(Member member)
        {
            var method = member as Method;
            CheckMethod(method);

            return Problems;
        }

        private void CheckMethod(Method method)
        {
            if (method == null ||
                method.FullName.Equals(RegionEndpointStaticConstructorName) ||
                method.Instructions == null ||
                method.Instructions.Count == 0)
            {
                return;
            }

            foreach (var instruction in method.Instructions)
            {
                var field = instruction.Value as Field;
                if (field != null &&
                    field.FullName.StartsWith(RegionEndpointFieldNamePrefix) &&
                    field.Type.FullName.Equals(RegionEndpointTypeName))
                {
                    var suppressionTarget = method.DeclaringType.FullName + ".#" + method.Name.Name + "(" + string.Join(",", method.Parameters.Select(p => p.Type.FullName).ToArray()) + ")";
                    Resolution resolution;
                    if (field.FullName.EndsWith(USEast1EndpointName))
                        resolution = GetResolution(suppressionTarget, field.FullName,"shouldn't usually", USEast1ResolutionMessage);
                    else
                        resolution = GetResolution(suppressionTarget, field.FullName, "should never", "");
                    Problems.Add(new Problem(resolution));
                }
            }
        }
    }
}
