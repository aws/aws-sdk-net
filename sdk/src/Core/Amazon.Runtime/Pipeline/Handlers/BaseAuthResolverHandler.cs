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
using Smithy.Identity.Abstractions;
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
            var authOptions = ResolveAuthOptions(executionContext.RequestContext);
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
        /// Invokes the service auth scheme resolver to determine which auth options we should consider for this request.
        /// </summary>
        protected abstract List<IAuthSchemeOption> ResolveAuthOptions(IRequestContext requestContext);
    }
}
