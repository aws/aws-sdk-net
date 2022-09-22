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

/*
 * Do not modify this file. This file is generated from the ep2-s3-host-label-2022-08-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Ep2s3hostlabel.Internal
{
    /// <summary>
    /// Amazon Ep2s3hostlabel endpoint provider.
    /// Resolves endpoint for given set of Ep2s3hostlabelEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEp2s3hostlabelEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Ep2s3hostlabelEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["BucketName"] == null)
                throw new AmazonClientException("BucketName parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["BucketName"] = parameters["BucketName"],
            };
            if (IsVirtualHostableS3Bucket(Interpolate(@"{BucketName}", refs), false))
            {
                return new Endpoint(Interpolate(@"https://{BucketName}.s3.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsVirtualHostableS3Bucket(Interpolate(@"{BucketName}", refs), true))
            {
                return new Endpoint(Interpolate(@"http://{BucketName}.s3.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("not isVirtualHostableS3Bucket");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}