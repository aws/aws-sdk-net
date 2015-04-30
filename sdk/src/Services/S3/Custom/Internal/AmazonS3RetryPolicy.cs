/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Net;
using Amazon.S3.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3RetryPolicy : DefaultRetryPolicy
    {
        private const string AWS_KMS_Signature_Error = "AWS KMS managed keys require AWS Signature Version 4";

        private static ICollection<Type> RequestsWith200Error = new HashSet<Type>
        {
            typeof(CopyObjectRequest),
            typeof(CopyPartRequest),
            typeof(CompleteMultipartUploadRequest)
        };

        /// <summary>
        /// Constructor for AmazonS3RetryPolicy.
        /// </summary>
        /// <param name="maxRetries">The maximum number of retries before throwing
        /// back a exception. This does not count the initial request.</param>
        public AmazonS3RetryPolicy(int maxRetries) :
            base(maxRetries)
        {
        }

        /// <summary>
        /// Return true if the request should be retried. Implements additional checks 
        /// specific to S3 on top of the checks in DefaultRetryPolicy.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override bool RetryForException(Runtime.IExecutionContext executionContext, Exception exception)
        {
            var serviceException = exception as AmazonServiceException;
            if (serviceException != null)
            {
                if (serviceException.StatusCode == HttpStatusCode.OK)
                {
                    var requestType = executionContext.RequestContext.OriginalRequest.GetType();
                    if (AmazonS3RetryPolicy.RequestsWith200Error.Contains(requestType))
                    {
                        // Retry on HTTP 200 responses which contain an error response.
                        // CopyObject, CopyPart and CompleteMultipartUpload operations can return this
                        // response.
                        return true;
                    }
                }

                if (serviceException.StatusCode == HttpStatusCode.BadRequest)
                {
                    var configuredUri = new Uri(executionContext.RequestContext.ClientConfig.DetermineServiceURL());
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
                        Logger.InfoFormat("Request {0}: the bucket you are attempting to access should be addressed using a region-specific endpoint."
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
                            r.UseSigV4 = true;
                            r.AuthenticationRegion = RegionEndpoint.USEast1.SystemName;
                            executionContext.RequestContext.IsSigned = false;
                        }
                        return true;
                    }
                }
            }

            return base.RetryForException(executionContext, exception);
        }
    }
}
