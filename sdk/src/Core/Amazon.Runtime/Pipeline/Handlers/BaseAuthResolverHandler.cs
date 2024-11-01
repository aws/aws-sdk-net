/*
* Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
* 
* Licensed under the Apache License, Version 2.0 (the "License").
* You may not use this file except in compliance with the License.
* A copy of the License is located at
* 
*  http://aws.amazon.com/apache2.0
* 
* or in the "license" file accompanying this file. This file is distributed
* on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
* express or implied. See the License for the specific language governing
* permissions and limitations under the License.
*/

using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Smithy.Identity.Abstractions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.Runtime.Internal
{
    public abstract class BaseAuthResolverHandler : PipelineHandler
    {
        // These are the client supported schemes, included here for now.
        private readonly HashSet<IAuthScheme<BaseIdentity>> _supportedSchemes = new()
        {
            new AnonymousAuthScheme(),
            new AwsV4aAuthScheme(),
            new AwsV4AuthScheme()
        };

        // Actual pipeline handler implementation will include other methods (such as InvokeAsync) too.
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        protected void PreInvoke(IExecutionContext executionContext)
        {
            var authOptions = ResolveAuthOptions(executionContext);
            if (authOptions == null || !authOptions.Any())
            {
                throw new AmazonClientException("TBD - no valid auth schemes for the current request");
            }

            foreach (var authOption in authOptions)
            {
                var scheme = _supportedSchemes.FirstOrDefault(s => s.SchemeId == authOption.SchemeId);
                if (scheme == null)
                {
                    // Current auth scheme option is not enabled, continue iterating.
                    continue;
                }

                // TODO: Retrieve identity resolver and signer for the current scheme and attach them to request context.
                // Interfaces haven't been defined yet, but code will be similar to:
                // var identityResolver = scheme.IdentityResolver();
                // var identity = identityResolver.GetIdentity();
                // var signer = scheme.Signer();

                // This code would also need to handle existing scenarios, such as:
                // - Customer explicitly set credentials on their service client (i.e. new AmazonS3Client(new BasicAWSCredentials))
            }
        }

        /// <summary>
        /// Certain allow-listed services contain auth schemes in their endpoint ruleset. For those, we'll attempt to
        /// retrieve the auth options from the attributes of the resolved endpoint.
        /// </summary>
        protected static List<IAuthSchemeOption> RetrieveSchemesFromEndpoint(Endpoint endpoint)
        {
            if (endpoint == null || endpoint.Attributes == null)
            {
                return null;
            }

            var authSchemes = (IList)endpoint.Attributes["authSchemes"];
            if (authSchemes == null)
            {
                return null;
            }

            var schemeNames = authSchemes.OfType<PropertyBag>().Select(scheme => (string)scheme["name"]).ToList();

            // If there's only one scheme, we'll try to return one of the default collections to avoid extra allocations.
            if (schemeNames.Count == 1)
            {
                var schemeName = schemeNames.First();
                switch (schemeName)
                {
                    case "sigv4":
                    case "sigv4-s3express":
                        return AuthSchemeOption.DEFAULT_SIGV4;
                    case "sigv4a":
                        return AuthSchemeOption.DEFAULT_SIGV4A;
                    default:
                        break;
                }
            }
            
            // If there's more than one scheme, we'll just return them as is (adding prefixes since the model doesn't have them).
            // Another important callout is that the BaseEndpointResolver will handle populating the request context with additional 
            // parameters from the endpoint attributes (e.g. whether to disable double encoding).
            var options = new List<IAuthSchemeOption>();
            foreach (var schemeName in schemeNames)
            {
                switch (schemeName)
                {
                    case "sigv4":
                    case "sigv4-s3express":
                        options.Add(new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 });
                        break;
                    case "sigv4a":
                        options.Add(new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A });
                        break;
                    default:
                        break;
                }
            }
            return options;
        }

        /// <summary>
        /// Invokes the service auth scheme resolver to determine which auth options we should consider for this request.
        /// </summary>
        protected abstract List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext);
    }
}
