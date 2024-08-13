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
        /// <returns>a value if it can be determined, or null if the IO-bound calculations need to be done</returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);            
        }
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
        /// <returns>a value if it can be determined, or null if the IO-bound calculations need to be done</returns>
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
        /// <returns>a value if it can be determined, or null if the IO-bound calculations need to be done</returns>
        public bool? RetryForExceptionSync(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForExceptionSync(executionContext, exception, Logger, base.RetryForException);
        }
    }
}
