﻿/*
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List AnalyticsConfiguration Request Marshaller
    /// </summary>    
    public class ListBucketAnalyticsConfigurationsRequestMarshaller : IMarshaller<IRequest, ListBucketAnalyticsConfigurationsRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBucketAnalyticsConfigurationsRequest)input);
        }

        public IRequest Marshall(ListBucketAnalyticsConfigurationsRequest listBucketAnalyticsConfigurationsRequest)
        {
            IRequest request = new DefaultRequest(listBucketAnalyticsConfigurationsRequest, "AmazonS3");

            request.HttpMethod = "GET";
            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(listBucketAnalyticsConfigurationsRequest.BucketName));
            request.AddSubResource("analytics");
            if (listBucketAnalyticsConfigurationsRequest.IsSetContinuationToken())
            {
                request.AddSubResource("continuation-token", listBucketAnalyticsConfigurationsRequest.ContinuationToken.ToString());
            }
            request.UseQueryString = true;

            return request;
        }

        private static ListBucketAnalyticsConfigurationsRequestMarshaller _instance;

        public static ListBucketAnalyticsConfigurationsRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListBucketAnalyticsConfigurationsRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
