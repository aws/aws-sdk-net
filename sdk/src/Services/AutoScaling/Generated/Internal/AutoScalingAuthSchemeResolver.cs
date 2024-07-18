using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Smithy.Identity.Abstractions;
using System.Collections.Generic;

// Hand-written class at the moment, generated files will include documentation for public members.
#pragma warning disable CS1591

namespace Amazon.AutoScaling.Internal
{
    // Auth parameters and scheme resolvers will be generated for each service;
    // The logic for S3 and EventBridge (where authentication rules are in the endpoint-rule-set file) will be different.

    public class AutoScalingAuthSchemeParameters : IAuthSchemeParameters
    {
        public string Operation { get; set; }
        public string Region { get; set; }
    }

    public class AutoScalingAuthSchemeResolver : 
        BaseAuthResolverHandler, 
        IAuthSchemeResolver<AutoScalingAuthSchemeParameters>
    {
        public List<IAuthSchemeOption> ResolveAuthScheme(AutoScalingAuthSchemeParameters authParameters)
        {
            var options = new List<IAuthSchemeOption>();

            switch (authParameters.Operation)
            {
                case "Foo":
                    // An operation that doesn't require auth.
                    options.Add(new AuthSchemeOption { SchemeId = "smithy.api#noAuth" });
                    break;

                case "Bar":
                    // Another operation that supports both SigV4 and SigV4a.
                    options.Add(new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" });
                    options.Add(new AuthSchemeOption { SchemeId = "aws.auth#sigv4" });
                    break;

                default:
                    // Default for the service, applies to all remaining operation.
                    options.Add(new AuthSchemeOption { SchemeId = "aws.auth#sigv4" });
                    break;
            }

            return options;
        }

        protected override List<IAuthSchemeOption> ServiceSpecificHandler(IRequestContext requestContext)
        {
            // Map request values to auth scheme parameters.
            var mappedParameters = new AutoScalingAuthSchemeParameters
            {
                Operation = requestContext.Request.RequestName,
                Region = requestContext.ClientConfig.RegionEndpoint?.SystemName
            };

            return ResolveAuthScheme(mappedParameters);
        }
    }
}
