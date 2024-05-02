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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Bucket MetricsConfigurationRequest Marshaller
    /// </summary>   
    public class GetBucketMetricsConfigurationRequestMarshaller : IMarshaller<IRequest, GetBucketMetricsConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketMetricsConfigurationRequest)input);
        }

        public IRequest Marshall(GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest)
        {
            IRequest request = new DefaultRequest(getBucketMetricsConfigurationRequest, "AmazonS3");

            request.Suppress404Exceptions = true;
            request.HttpMethod = "GET";

            if (getBucketMetricsConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getBucketMetricsConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getBucketMetricsConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketMetricsConfigurationRequest.BucketName");

            request.ResourcePath = "/";
            request.AddSubResource("metrics");
            request.AddSubResource("id", getBucketMetricsConfigurationRequest.MetricsId);
            request.UseQueryString = true;

            return request;
        }

        private static GetBucketMetricsConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static GetBucketMetricsConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketMetricsConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
