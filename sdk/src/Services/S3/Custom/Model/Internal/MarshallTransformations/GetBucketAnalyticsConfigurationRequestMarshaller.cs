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
    /// Get BucketAnalyticsConfiguration Request Marshaller
    /// </summary>    
    public class GetBucketAnalyticsConfigurationRequestMarshaller : IMarshaller<IRequest, GetBucketAnalyticsConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketAnalyticsConfigurationRequest)input);
        }

        public IRequest Marshall(GetBucketAnalyticsConfigurationRequest getAnalyticsConfigurationRequest)
        {
            IRequest request = new DefaultRequest(getAnalyticsConfigurationRequest, "AmazonS3");

            request.Suppress404Exceptions = true;
            request.HttpMethod = "GET";

            if (getAnalyticsConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getAnalyticsConfigurationRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getAnalyticsConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketAnalyticsConfigurationRequest.BucketName");

            request.ResourcePath = "/";
            request.AddSubResource("analytics");
            request.AddSubResource("id", getAnalyticsConfigurationRequest.AnalyticsId);
            request.UseQueryString = true;

            return request;
        }

        private static GetBucketAnalyticsConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static GetBucketAnalyticsConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketAnalyticsConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
