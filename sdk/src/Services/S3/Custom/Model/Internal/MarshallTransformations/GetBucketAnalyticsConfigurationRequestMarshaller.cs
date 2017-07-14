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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

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

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(getAnalyticsConfigurationRequest.BucketName));
            request.AddSubResource("analytics");
            request.AddSubResource("id", getAnalyticsConfigurationRequest.AnalyticsId);
            request.UseQueryString = true;

            return request;
        }

        private static GetBucketAnalyticsConfigurationRequestMarshaller _instance;

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
