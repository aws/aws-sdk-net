/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Globalization;

namespace Amazon.RDS.Internal
{
    /// <summary>
    /// Custom pipeline handler to populate PreSignedUrl if it's empty, and the SourceRegion paramter is populated.
    /// </summary>
    public class PreSignedUrlRequestHandler : PipelineHandler
    {
        private const string UriSchemeHTTPS = "https";
        private const string RDSServiceNameForSigning = "rds";
        private const string HTTPGet = "GET";
        private const string DestinationRegionParameterKey = "DestinationRegion";

        private readonly AWSCredentials _credentials;

        /// <summary>
        /// Construct instance of PreSignedUrlRequestHandler
        /// </summary>
        /// <param name="credentials"></param>
        public PreSignedUrlRequestHandler(AWSCredentials credentials)
        {
            _credentials = credentials;
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
#if AWS_ASYNC_API 

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

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif

        /// <summary>
        /// Auto-generates pre-signed URLs for requests that implement <see cref="IPreSignedUrlRequest"/>.
        /// if the PreSignedUrl property isn't set and the SourceRegion property is set.
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
                    throw new AmazonRDSException(string.Format(CultureInfo.InvariantCulture, "No endpoint for region {0}.", preSignedUrlRequest.SourceRegion));
                }

                // Marshall this request and prepare it to be signed
                var marshaller = executionContext.RequestContext.Marshaller;
                var iRequest = marshaller.Marshall(preSignedUrlRequest as AmazonWebServiceRequest);
                iRequest.UseQueryString = true;
                iRequest.HttpMethod = HTTPGet;
                iRequest.Endpoint = new UriBuilder(UriSchemeHTTPS, endpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname).Uri;
                iRequest.Parameters[DestinationRegionParameterKey] = executionContext.RequestContext.ClientConfig.RegionEndpoint.SystemName;
                // Most pre signed URLS also have an X-Amz-Expires header.  But RDS just ignores it and always imposes a +/- 14 minute time limit instead.

                var immutableCredentials = _credentials.GetCredentials();
                if (immutableCredentials.UseToken)
                {
                    // Don't use HeaderKeys.XAmzSecurityTokenHeader because RDS treats this as case-sensitive
                    iRequest.Parameters["X-Amz-Security-Token"] = immutableCredentials.Token;
                }

                // Create presigned URL and assign it
                var signingResult = AWS4PreSignedUrlSigner.SignRequest(iRequest, config, new RequestMetrics(),
                    immutableCredentials.AccessKey, immutableCredentials.SecretKey, RDSServiceNameForSigning, preSignedUrlRequest.SourceRegion);

                var authorization = "&" + signingResult.ForQueryParameters;

                preSignedUrlRequest.PreSignedUrl = AmazonServiceClient.ComposeUrl(iRequest).AbsoluteUri + authorization;
            }
        }
    }
}
