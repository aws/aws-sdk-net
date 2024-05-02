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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Bucket MetricsConfigurationRequest Marshaller
    /// </summary>     
    public class ListBucketMetricsConfigurationsRequestMarshaller : IMarshaller<IRequest, ListBucketMetricsConfigurationsRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBucketMetricsConfigurationsRequest)input);
        }

        public IRequest Marshall(ListBucketMetricsConfigurationsRequest listBucketMetricsConfigurationRequest)
        {
            IRequest request = new DefaultRequest(listBucketMetricsConfigurationRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (listBucketMetricsConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(listBucketMetricsConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(listBucketMetricsConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "ListBucketMetricsConfigurationsRequest.BucketName");

            request.ResourcePath = "/";
            request.AddSubResource("metrics");
            if (listBucketMetricsConfigurationRequest.IsSetContinuationToken())
            {
                request.AddSubResource("continuation-token", listBucketMetricsConfigurationRequest.ContinuationToken.ToString());
            }
            
            request.UseQueryString = true;

            return request;
        }

        private static ListBucketMetricsConfigurationsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static ListBucketMetricsConfigurationsRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListBucketMetricsConfigurationsRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
