/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Bundle Instance Request Marshaller
    /// </summary>       
    public class BundleInstanceRequestMarshaller : IMarshaller<IRequest, BundleInstanceRequest>
    {
        public IRequest Marshall(BundleInstanceRequest bundleInstanceRequest)
        {
            IRequest request = new DefaultRequest(bundleInstanceRequest, "AmazonEC2");
            request.Parameters.Add("Action", "BundleInstance");
            request.Parameters.Add("Version", "2013-10-15");
            if (bundleInstanceRequest != null && bundleInstanceRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(bundleInstanceRequest.InstanceId));
            }
            if (bundleInstanceRequest != null)
            {
                Storage storage = bundleInstanceRequest.Storage;
                if (storage != null)
                {
                    S3Storage s3 = storage.S3;
                    if (s3 != null && s3.IsSetBucket())
                    {
                        request.Parameters.Add("Storage.S3.Bucket", StringUtils.FromString(s3.Bucket));
                    }
                    if (s3 != null && s3.IsSetPrefix())
                    {
                        request.Parameters.Add("Storage.S3.Prefix", StringUtils.FromString(s3.Prefix));
                    }
                    if (s3 != null && s3.IsSetAWSAccessKeyId())
                    {
                        request.Parameters.Add("Storage.S3.AWSAccessKeyId", StringUtils.FromString(s3.AWSAccessKeyId));
                    }
                    if (s3 != null && s3.IsSetUploadPolicy())
                    {
                        request.Parameters.Add("Storage.S3.UploadPolicy", StringUtils.FromString(s3.UploadPolicy));
                    }
                    if (s3 != null && s3.IsSetUploadPolicySignature())
                    {
                        request.Parameters.Add("Storage.S3.UploadPolicySignature", StringUtils.FromString(s3.UploadPolicySignature));
                    }
                }
            }

            return request;
        }
    }
}
