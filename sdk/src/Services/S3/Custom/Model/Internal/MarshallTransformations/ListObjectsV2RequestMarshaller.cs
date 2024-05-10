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

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Objects Request Marshaller
    /// </summary>       
    public class ListObjectsV2RequestMarshaller : IMarshaller<IRequest, ListObjectsV2Request> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
            return this.Marshall((ListObjectsV2Request)input);
		}

        public IRequest Marshall(ListObjectsV2Request listObjectsRequest)
        {
            IRequest request = new DefaultRequest(listObjectsRequest, "AmazonS3");

            if (listObjectsRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(listObjectsRequest.RequestPayer.ToString()));

            if (listObjectsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(listObjectsRequest.ExpectedBucketOwner));

            if (listObjectsRequest.IsSetOptionalObjectAttributes())
                request.Headers.Add(S3Constants.AmzOptionalObjectAttributes, AWSSDKUtils.Join(listObjectsRequest.OptionalObjectAttributes));
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(listObjectsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "ListObjectsV2Request.BucketName");

            request.ResourcePath = "/";

            if (listObjectsRequest.IsSetDelimiter())
                request.Parameters.Add("delimiter", S3Transforms.ToStringValue(listObjectsRequest.Delimiter));
            if (listObjectsRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", S3Transforms.ToStringValue(listObjectsRequest.Encoding));
            if (listObjectsRequest.IsSetMaxKeys())
                request.Parameters.Add("max-keys", S3Transforms.ToStringValue(listObjectsRequest.MaxKeys.Value));
            if (listObjectsRequest.IsSetPrefix())
                request.Parameters.Add("prefix", S3Transforms.ToStringValue(listObjectsRequest.Prefix));
            if (listObjectsRequest.IsSetContinuationToken())
                request.Parameters.Add("continuation-token", S3Transforms.ToStringValue(listObjectsRequest.ContinuationToken));
            if (listObjectsRequest.IsSetFetchOwner())
                request.Parameters.Add("fetch-owner", S3Transforms.ToStringValue(listObjectsRequest.FetchOwner.Value));
            if (listObjectsRequest.IsSetStartAfter())
                request.Parameters.Add("start-after", S3Transforms.ToStringValue(listObjectsRequest.StartAfter));

            request.Parameters.Add("list-type", "2");

            request.UseQueryString = true;
            
            return request;
        }

	    private static ListObjectsV2RequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static ListObjectsV2RequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new ListObjectsV2RequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
