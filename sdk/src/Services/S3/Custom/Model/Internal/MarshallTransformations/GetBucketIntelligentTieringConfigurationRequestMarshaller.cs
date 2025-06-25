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
	/// Get InventoryConfiguration Request Marshaller
	/// </summary>    
	public class GetBucketIntelligentTieringConfigurationRequestMarshaller : IMarshaller<IRequest, GetBucketIntelligentTieringConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
	{
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketIntelligentTieringConfigurationRequest)input);
        }

        public IRequest Marshall(GetBucketIntelligentTieringConfigurationRequest getBucketIntelligentTieringConfigurationRequest)
        {
            IRequest request = new DefaultRequest(getBucketIntelligentTieringConfigurationRequest, "AmazonS3");

            request.Suppress404Exceptions = true;
            request.HttpMethod = "GET";
            
            if (string.IsNullOrEmpty(getBucketIntelligentTieringConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketInventoryConfigurationRequest.BucketName");

            if (getBucketIntelligentTieringConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getBucketIntelligentTieringConfigurationRequest.ExpectedBucketOwner));

            request.ResourcePath = "/";
            request.AddSubResource("intelligent-tiering");
            request.AddSubResource("id", getBucketIntelligentTieringConfigurationRequest.IntelligentTieringId);
            request.UseQueryString = true;

            return request;
        }

        private static GetBucketIntelligentTieringConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static GetBucketIntelligentTieringConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketIntelligentTieringConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
