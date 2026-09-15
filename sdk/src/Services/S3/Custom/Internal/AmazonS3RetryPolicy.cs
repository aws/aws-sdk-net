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
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public partial class AmazonS3RetryPolicy : DefaultRetryPolicy
    {
        private const string AWS_KMS_Signature_Error = "AWS KMS managed keys require AWS Signature Version 4";

        /// <summary>
        /// Constructor for AmazonS3RetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public AmazonS3RetryPolicy(IClientConfig config) :
            base(config)
        {
        }

        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        /// <returns>
        /// <c>true</c>/<c>false</c> when the retry decision can be made synchronously; <c>null</c>
        /// when it must be deferred to <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/>
        /// for bucket/region-mismatch detection.
        /// </returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);            
        }
        /// <summary>
        /// Shared synchronous retry triage for S3. Returns <c>true</c>/<c>false</c> for
        /// cases that can be decided without further lookup, or <c>null</c> to signal a
        /// possible bucket/region mismatch (the async caller then resolves the bucket's
        /// Region from the x-amz-bucket-region header or a HEAD bucket fallback).
        /// </summary>
        internal static bool? SharedRetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception, 
            Runtime.Internal.Util.ILogger logger,
            Func<Runtime.IExecutionContext, Exception, bool> baseRetryForException)
        {
            var serviceException = exception as AmazonServiceException;
            if (serviceException != null)
            {
                if (serviceException.StatusCode == HttpStatusCode.OK)
                {
                    var requestType = executionContext.RequestContext.OriginalRequest.GetType();
                    if (RequestsWith200Error.Contains(requestType))
                    {
                        // Retry on HTTP 200 responses which contain an error response
                        // CopyObject, CopyPart and CompleteMultipartUpload operations can return this
                        // response.
                        return true;
                    }
                }

                // A bucket in a different Region can be answered with a redirect instead of a 400
                // (301 when the bucket is in us-east-1 and the client is not; more rarely 308).
                // These carry the correct Region in the x-amz-bucket-region header, so treat them
                // as inconclusive. This is limited to HeadBucket so other operations preserve the
                // prior behavior of surfacing the redirect as an error.
                if (executionContext.RequestContext.OriginalRequest is HeadBucketRequest &&
                    (serviceException.StatusCode == HttpStatusCode.MovedPermanently ||
                     (int)serviceException.StatusCode == 308))
                {
                    return null;
                }

                if (serviceException.StatusCode == HttpStatusCode.BadRequest)
                {
                    var parameters = new ServiceOperationEndpointParameters(executionContext.RequestContext.OriginalRequest);
                    var endpoint = executionContext.RequestContext.ClientConfig
                        .DetermineServiceOperationEndpoint(parameters);
                    var configuredUri = new Uri(endpoint.URL);

                    if (configuredUri.Host.Equals(S3Constants.S3DefaultEndpoint) &&
                        (serviceException.Message.Contains(AWS4Signer.AWS4AlgorithmTag) ||
                         serviceException.Message.Contains(AWS_KMS_Signature_Error))
                        )
                    {
                        // If the response message indicates AWS4 signing should have been used,
                        // we've attempted to access a bucket in an AWS4-only region (e.g. EU Central (Frankfurt)) with an AWS2
                        // signature and/or client not configured with the correct region.
                        // Retry the request to the s3-external endpoint to yield a 307 redirect
                        // that we can then follow to the correct bucket location with the expected
                        // signing algorithm.
                        logger.InfoFormat("Request {0}: the bucket you are attempting to access should be addressed using a region-specific endpoint."
                                            + " Additional calls will be made to attempt to determine the correct region to be used."
                                            + " For better performance configure your client to use the correct region.",
                                            executionContext.RequestContext.RequestName);

                        var r = executionContext.RequestContext.Request;
                        var s3Uri = new AmazonS3Uri(r.Endpoint);

                        // since DNS resolved, yielding an auth error from the service,
                        // we're assuming we do not need to test (again) for dns compatibility
                        // on the bucket name
                        var tempEndpoint = string.Format(CultureInfo.InvariantCulture,
                            "https://{0}.{1}", s3Uri.Bucket, S3Constants.S3AlternateDefaultEndpoint);
                        r.Endpoint = new Uri(tempEndpoint);

                        if (serviceException.Message.Contains(AWS_KMS_Signature_Error))
                        {
                            r.SignatureVersion = SignatureVersion.SigV4;
                            r.AuthenticationRegion = RegionEndpoint.USEast1.SystemName;
                            executionContext.RequestContext.IsSigned = false;
                        }
                        return true;
                    }
                    else
                    {
                        // this means that the synchronous check is inconclusive and
                        // the caller needs to check for a bucket/region mismatch
                        return null;
                    }
                }
            }

            return baseRetryForException(executionContext, exception);
        }

        /// <summary>
        /// Redirects the request to <paramref name="correctedRegion"/> after a bucket/region
        /// mismatch is detected, so the retried request is both sent to and signed for that Region.
        /// Returns <c>false</c> when <paramref name="correctedRegion"/> (from the x-amz-bucket-region header)
        /// is not a valid hostname component.
        /// </summary>
        internal static bool RedirectToRegion(Runtime.IExecutionContext executionContext, string correctedRegion)
        {
            RegionEndpoint correctedEndpoint;
            try
            {
                correctedEndpoint = RegionEndpoint.GetBySystemName(correctedRegion);
            }
            catch (AmazonClientException)
            {
                // Malformed x-amz-bucket-region value (not a valid hostname component).
                return false;
            }

            var requestContext = executionContext.RequestContext;

            // Re-resolve the operation endpoint for the corrected Region via the endpoint provider.
            var parameters = new ServiceOperationEndpointParameters(requestContext.OriginalRequest, correctedEndpoint);
            var endpoint = requestContext.ClientConfig.DetermineServiceOperationEndpoint(parameters);
            requestContext.Request.Endpoint = new Uri(endpoint.URL);

            // Drop the stale Host header so it is recomputed for the new endpoint on re-sign.
            if (requestContext.Request.Headers.ContainsKey(HeaderKeys.HostHeader))
            {
                requestContext.Request.Headers.Remove(HeaderKeys.HostHeader);
            }

            // Set the signing region and let the pipeline re-sign on retry.
            requestContext.Request.AlternateEndpoint = correctedEndpoint;
            requestContext.Request.AuthenticationRegion = correctedRegion;
            requestContext.IsSigned = false;
            return true;
        }
    }


    public partial class AmazonS3StandardRetryPolicy : StandardRetryPolicy
    {
        /// <summary>
        /// Constructor for AmazonS3StandardRetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public AmazonS3StandardRetryPolicy(IClientConfig config) :
            base(config)
        {
        }

        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        /// <returns>
        /// <c>true</c>/<c>false</c> when the retry decision can be made synchronously; <c>null</c>
        /// when it must be deferred to <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/>
        /// for bucket/region-mismatch detection.
        /// </returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);
        }
    }


    public partial class AmazonS3AdaptiveRetryPolicy : AdaptiveRetryPolicy
    {
        /// <summary>
        /// Constructor for AmazonS3AdaptiveRetryPolicy.
        /// </summary>
        /// <param name="config">The IClientConfig object</param>
        public AmazonS3AdaptiveRetryPolicy(IClientConfig config) :
            base(config)
        {
        }

        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        /// <returns>
        /// <c>true</c>/<c>false</c> when the retry decision can be made synchronously; <c>null</c>
        /// when it must be deferred to <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/>
        /// for bucket/region-mismatch detection.
        /// </returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);
        }
    }
}
