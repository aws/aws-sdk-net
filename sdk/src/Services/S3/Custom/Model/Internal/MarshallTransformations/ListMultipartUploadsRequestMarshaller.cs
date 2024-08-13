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
    /// List Multipart Uploads Request Marshaller
    /// </summary>       
    public class ListMultipartUploadsRequestMarshaller : IMarshaller<IRequest, ListMultipartUploadsRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((ListMultipartUploadsRequest)input);
		}

        public IRequest Marshall(ListMultipartUploadsRequest listMultipartUploadsRequest)
        {
            IRequest request = new DefaultRequest(listMultipartUploadsRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (listMultipartUploadsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(listMultipartUploadsRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(listMultipartUploadsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "ListMultipartUploadsRequest.BucketName");

            if (listMultipartUploadsRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(listMultipartUploadsRequest.RequestPayer));

            request.ResourcePath = "/";

            request.AddSubResource("uploads");

            if (listMultipartUploadsRequest.IsSetDelimiter())
                request.Parameters.Add("delimiter", S3Transforms.ToStringValue(listMultipartUploadsRequest.Delimiter));
            if (listMultipartUploadsRequest.IsSetKeyMarker())
                request.Parameters.Add("key-marker", S3Transforms.ToStringValue(listMultipartUploadsRequest.KeyMarker));
            if (listMultipartUploadsRequest.IsSetMaxUploads())
                request.Parameters.Add("max-uploads", S3Transforms.ToStringValue(listMultipartUploadsRequest.MaxUploads.Value));
            if (listMultipartUploadsRequest.IsSetPrefix())
                request.Parameters.Add("prefix", S3Transforms.ToStringValue(listMultipartUploadsRequest.Prefix));
            if (listMultipartUploadsRequest.IsSetUploadIdMarker())
                request.Parameters.Add("upload-id-marker", S3Transforms.ToStringValue(listMultipartUploadsRequest.UploadIdMarker));
            if (listMultipartUploadsRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", S3Transforms.ToStringValue(listMultipartUploadsRequest.Encoding));

            request.UseQueryString = true;
            
            return request;
        }

	    private static ListMultipartUploadsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static ListMultipartUploadsRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new ListMultipartUploadsRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
