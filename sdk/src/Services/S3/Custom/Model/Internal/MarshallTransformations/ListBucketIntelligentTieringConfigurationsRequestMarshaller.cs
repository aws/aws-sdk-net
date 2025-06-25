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
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Request Marshaller for ListBucketIntelligentTieringConfigurations
    /// </summary>    

    public class ListBucketIntelligentTieringConfigurationsRequestMarshaller : IMarshaller<IRequest, ListBucketIntelligentTieringConfigurationsRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBucketIntelligentTieringConfigurationsRequest)input);
        }

        public IRequest Marshall(ListBucketIntelligentTieringConfigurationsRequest listBucketIntelligentTieringConfigurationsRequest)
        {
            IRequest request = new DefaultRequest(listBucketIntelligentTieringConfigurationsRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(listBucketIntelligentTieringConfigurationsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "listBucketIntelligentTieringConfigurationsRequest.BucketName");

            if (listBucketIntelligentTieringConfigurationsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(listBucketIntelligentTieringConfigurationsRequest.ExpectedBucketOwner));

            request.ResourcePath = "/";
            request.AddSubResource("intelligent-tiering");
            if (listBucketIntelligentTieringConfigurationsRequest.IsSetContinuationToken())
            {
                request.AddSubResource("continuation-token", listBucketIntelligentTieringConfigurationsRequest.ContinuationToken.ToString());
            }

            request.UseQueryString = true;

            return request;
        }

        private static ListBucketIntelligentTieringConfigurationsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static ListBucketIntelligentTieringConfigurationsRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListBucketIntelligentTieringConfigurationsRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
