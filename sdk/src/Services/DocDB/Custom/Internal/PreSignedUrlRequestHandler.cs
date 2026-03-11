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
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System;
using System.Globalization;

namespace Amazon.DocDB.Internal
{
    /// <summary>
    /// Custom pipeline handler to populate PreSignedUrl if it's empty, and the SourceRegion paramter is populated.
    /// </summary>
    public class PreSignedUrlRequestHandler : PipelineHandler
    {
        private const string UriSchemeHTTPS = "https";
        private const string DocDBServiceNameForSigning = "rds";
        private const string HTTPGet = "GET";
        private const string DestinationRegionParameterKey = "DestinationRegion";
        private const string XAmzExpires = "X-Amz-Expires";
        private readonly TimeSpan ExpirationTime = TimeSpan.FromMinutes(60);
        private const string XAmzSecurityToken = "X-Amz-Security-Token";
        private readonly AWSCredentials _credentials;

        /// <summary>
        /// Construct instance of PreSignedUrlRequestHandler
        /// </summary>
        /// <param name="credentials"></param>
        public PreSignedUrlRequestHandler(AWSCredentials credentials)
        {
            _credentials = credentials ?? DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);
        }

        /// <summary>
        /// <para>
        /// Auto-generates pre-signed URLs for requests that implement <see cref="IPreSignedUrlRequest"/>.
        /// if the PreSignedUrl property isn't set and the SourceRegion property is set.
        /// </para>
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var preSignedUrlRequest = executionContext.RequestContext.OriginalRequest as IPreSignedUrlRequest;
            if (preSignedUrlRequest != null && preSignedUrlRequest.SourceRegion != null && preSignedUrlRequest.PreSignedUrl == null)
            {
                var config = executionContext.RequestContext.ClientConfig;

                var endpoint = RegionEndpoint.GetBySystemName(preSignedUrlRequest.SourceRegion);
                if (endpoint == null)
                {
                    throw new AmazonDocDBException(string.Format(CultureInfo.InvariantCulture, "No endpoint for region {0}.", preSignedUrlRequest.SourceRegion));
                }

                // Marshall this request and prepare it to be signed
                var marshaller = executionContext.RequestContext.Marshaller;
                var iRequest = marshaller.Marshall(preSignedUrlRequest as AmazonWebServiceRequest);
                iRequest.UseQueryString = true;
                iRequest.HttpMethod = HTTPGet;
                iRequest.Endpoint = new Uri(config.DetermineServiceOperationEndpoint(new Runtime.Endpoints.ServiceOperationEndpointParameters(executionContext.RequestContext.OriginalRequest, RegionEndpoint.GetBySystemName(preSignedUrlRequest.SourceRegion))).URL);
                iRequest.Parameters[DestinationRegionParameterKey] = executionContext.RequestContext.ClientConfig.RegionEndpoint.SystemName;
                iRequest.Parameters[XAmzExpires] = ((int)ExpirationTime.TotalSeconds).ToString(CultureInfo.InvariantCulture);

                var immutableCredentials = _credentials.GetCredentials();
                if (immutableCredentials.UseToken)
                {
                    iRequest.Parameters[XAmzSecurityToken] = immutableCredentials.Token;
                }

                // Create presigned URL and assign it
                var signingResult = AWS4PreSignedUrlSigner.SignRequest(iRequest, config, new RequestMetrics(),
                    immutableCredentials.AccessKey, immutableCredentials.SecretKey, DocDBServiceNameForSigning, preSignedUrlRequest.SourceRegion);

                var authorization = "&" + signingResult.ForQueryParameters;

                preSignedUrlRequest.PreSignedUrl = AmazonServiceClient.ComposeUrl(iRequest).AbsoluteUri + authorization;
            }
        }
    }
}
