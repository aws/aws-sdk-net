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

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Util;
using Amazon.Runtime.Identity;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class S3Signer : AbstractAWSSigner
    {
        private readonly Amazon.Runtime.Internal.Auth.S3Signer _s3Signer;

        public S3Signer()
        {
            _s3Signer = new Amazon.Runtime.Internal.Auth.S3Signer(RegionDetectionUpdater);
        }

        public override ClientProtocol Protocol
        {
            get { return _s3Signer.Protocol; }
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
        {
            _s3Signer.Sign(request, clientConfig, metrics, identity);
        }

        internal static void SignRequest(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            Amazon.Runtime.Internal.Auth.S3Signer.SignRequest(request, metrics, awsAccessKeyId, awsSecretAccessKey);
        }

        private static void RegionDetectionUpdater(IRequest request)
        {
            AmazonS3Uri s3Uri;
            if (AmazonS3Uri.TryParseAmazonS3Uri(request.Endpoint, out s3Uri))
            {
                if (s3Uri.Bucket != null)
                {
                    RegionEndpoint cachedRegion;
                    if (BucketRegionDetector.BucketRegionCache.TryGetValue(s3Uri.Bucket, out cachedRegion))
                    {
                        request.AlternateEndpoint = cachedRegion;
                    }
                }
            }
        }
    }
}
