using System.Text;
using System.Linq;
using ServiceClientGenerator.Endpoints;
using System;
using System.Collections.Generic;

namespace ServiceClientGenerator.Generators.Endpoints
{
    public partial class EndpointResolver
    {
        private HashSet<string> dontInjectHostPrefixForServices = new HashSet<string>() { "S3 Control" };

        private string GetValueSource(Parameter parameter)
        {
            switch (parameter.builtIn)
            {
                case "AWS::Region": return "requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;";
                case "AWS::UseFIPS": return "config.UseFIPSEndpoint";
                case "AWS::UseDualStack": return "config.UseDualstackEndpoint";
                case "SDK::Endpoint": return "config.ServiceURL";
                case "AWS::S3::ForcePathStyle": return "config.ForcePathStyle";
                case "AWS::S3::Accelerate": return "config.UseAccelerateEndpoint";
                case "AWS::S3::UseArnRegion": return "config.UseArnRegion";
                case "AWS::S3Control::UseArnRegion": return "config.UseArnRegion";
                case "AWS::S3::DisableMultiRegionAccessPoints": return "config.DisableMultiregionAccessPoints";
                case "AWS::S3::UseGlobalEndpoint": return "config.USEast1RegionalEndpointValue == S3UsEast1RegionalEndpointValue.Legacy";
                case "AWS::STS::UseGlobalEndpoint": return "false";
                case "AWS::Auth::AccountId": return "requestContext.Identity is AWSCredentials credentials ? credentials.GetCredentials()?.AccountId : null";
                case "AWS::Auth::AccountIdEndpointMode": return "config.AccountIdEndpointMode.ToString().ToLower()";
                default: throw new Exception("Unknown builtIn");
            }
        }

        private const string indent = "            "; // 12 spaces
        private const string innerIndent = "                "; // 16 spaces

        private string AssignBuiltins()
        {
            var parameters = Config.EndpointsRuleSet.parameters;
            var code = new StringBuilder();
            foreach (var param in parameters.Where(c => c.Value.builtIn != null))
            {
                code.AppendLine($@"{indent}result.{param.Key} = {GetValueSource(param.Value)};");
            }
            return code.ToString();
        }

        private string AssignClientContext()
        {
            var parameters = Config.ServiceModel.ClientContextParameters;
            var code = new StringBuilder();
            foreach (var param in parameters)
            {
                string valueSource = $"config.{param.name}";
                Parameter parameter;
                if (Config.EndpointsRuleSet.parameters.TryGetValue(param.name, out parameter) && parameter.builtIn != null)
                {
                    valueSource = GetValueSource(Config.EndpointsRuleSet.parameters[param.name]);
                }
                code.AppendLine($@"{indent}result.{param.name} = {valueSource};");
            }
            return code.ToString();
        }

        private string AssignOperationContext()
        {
            var code = new StringBuilder();

            var ops = Config.ServiceModel.Operations.Where(x => x.StaticContextParameters.Count > 0 || x.OperationContextParameters.Count > 0 || x.RequestStructure?.Members.Any(c => c.ContextParameter != null) == true);
            foreach (var op in ops)
            {
                code.AppendLine($@"{indent}if (requestContext.RequestName == ""{op.Name}Request"") {{");

                foreach (var param in op.StaticContextParameters)
                {
                    code.AppendLine($@"{innerIndent}result.{param.name} = {param.nativeValue};");
                }

                if (op.RequestStructure == null)
                {
                    continue;
                }
                var memberswithContextParameter = op.RequestStructure.Members.Where(c => c.ContextParameter != null).ToList();
                if (memberswithContextParameter.Count > 0 || op.OperationContextParameters.Count > 0)
                {
                    code.AppendLine($@"{innerIndent}var request = ({op.Name}Request)requestContext.OriginalRequest;");
                }

                foreach (var param in op.OperationContextParameters)
                {
                    var nativeValue = param.GetNativeValue(op.RequestStructure);
                    if (nativeValue == null)
                        continue;

                    code.AppendLine($@"{innerIndent}result.{param.name} = request.{nativeValue};");
                }

                foreach (var member in memberswithContextParameter)
                {
                    code.AppendLine($@"{innerIndent}result.{member.ContextParameter.name} = request.{member.PropertyName};");
                }
                code.AppendLine($@"{innerIndent}return result;");
                code.AppendLine($@"{indent}}}");
            }

            return code.ToString();
        }
    }
}
