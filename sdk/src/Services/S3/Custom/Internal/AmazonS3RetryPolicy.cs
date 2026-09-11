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
        /// <c>true</c> or <c>false</c> when the retry decision can be made here; <c>null</c> when the
        /// exception looks like a bucket/region mismatch and the decision must be deferred to the
        /// asynchronous <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/> path, which
        /// resolves the bucket's Region (from the x-amz-bucket-region response header when present,
        /// otherwise via a HEAD bucket network call) before deciding whether to retry.
        /// </returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);            
        }
        /// <summary>
        /// Shared synchronous retry triage for S3.
        /// Returns <c>true</c>/<c>false</c> for cases that can be decided without any further lookup.
        /// Returns <c>null</c> to signal that the exception may be a bucket/region mismatch: the
        /// caller (<see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/>) then resolves the
        /// bucket's Region — cheaply from the x-amz-bucket-region response header when it is present,
        /// or via a HEAD bucket network call as a fallback — and retries against the correct Region.
        /// <c>null</c> does not by itself imply a network call will happen.
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

                // A bucket that lives in a different Region than the one the client is
                // configured for can respond with a redirect status instead of a 400 when the
                // bucket is in us-east-1 and the client is not (301 MovedPermanently), or in the
                // rarer 308 PermanentRedirect case. These responses still carry the correct
                // Region in the x-amz-bucket-region header, so treat them as inconclusive and let
                // the caller detect the region mismatch and retry against the correct Region
                // (mirroring the AWS CLI behavior). Without this, HeadBucket and other operations
                // against a us-east-1 bucket from a non-us-east-1 client would surface the error
                // instead of following the redirect.
                // See https://github.com/aws/aws-tools-for-powershell/issues/413 (DOTNET-8539).
                if (serviceException.StatusCode == HttpStatusCode.MovedPermanently ||
                    serviceException.StatusCode == HttpStatusCode.PermanentRedirect)
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
        ///
        /// The endpoint (not just <see cref="IRequest.AuthenticationRegion"/>) must be rewritten
        /// because the S3 endpoint resolver runs once, before the retry loop, and is not
        /// re-evaluated on retry; the same reason <see cref="Amazon.Runtime.Internal.RedirectHandler"/>
        /// rewrites the endpoint when following a 307. Returns <c>false</c> if the Region is not
        /// recognized by this SDK build, in which case the caller should not retry.
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
                // Unknown region on an older SDK build: leave the request untouched.
                return false;
            }

            var requestContext = executionContext.RequestContext;

            // Re-resolve the operation endpoint for the corrected Region using the pipeline's
            // endpoint provider (preserves FIPS/dualstack/accelerate/path-style/ARN handling).
            var parameters = new ServiceOperationEndpointParameters(requestContext.OriginalRequest, correctedEndpoint);
            var endpoint = requestContext.ClientConfig.DetermineServiceOperationEndpoint(parameters);
            requestContext.Request.Endpoint = new Uri(endpoint.URL);

            // Drop the stale Host header so it is recomputed for the new endpoint on re-sign,
            // mirroring AmazonS3RedirectHandler.FinalizeForRedirect (the 307 path).
            if (requestContext.Request.Headers.ContainsKey(HeaderKeys.HostHeader))
            {
                requestContext.Request.Headers.Remove(HeaderKeys.HostHeader);
            }

            // Set the signing region and let the pipeline re-sign. Unlike AmazonS3RedirectHandler
            // (which signs inline because it runs inner to the Signer), this runs in the retry
            // policy -- outer to the Signer -- so the Signer re-runs on the retry. AlternateEndpoint
            // is the primary signing-region signal (see AWS4Signer.DetermineSigningRegion).
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
        /// <c>true</c> or <c>false</c> when the retry decision can be made here; <c>null</c> when the
        /// exception looks like a bucket/region mismatch and the decision must be deferred to the
        /// asynchronous <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/> path, which
        /// resolves the bucket's Region (from the x-amz-bucket-region response header when present,
        /// otherwise via a HEAD bucket network call) before deciding whether to retry.
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
        /// <c>true</c> or <c>false</c> when the retry decision can be made here; <c>null</c> when the
        /// exception looks like a bucket/region mismatch and the decision must be deferred to the
        /// asynchronous <see cref="AmazonS3RetryPolicy.SharedRetryForExceptionAsync"/> path, which
        /// resolves the bucket's Region (from the x-amz-bucket-region response header when present,
        /// otherwise via a HEAD bucket network call) before deciding whether to retry.
        /// </returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);
        }
    }
}
