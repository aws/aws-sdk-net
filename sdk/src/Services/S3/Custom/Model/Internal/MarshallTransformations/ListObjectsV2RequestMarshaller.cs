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

            request.HttpMethod = "GET";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(listObjectsRequest.BucketName));

            if (listObjectsRequest.IsSetDelimiter())
                request.Parameters.Add("delimiter", S3Transforms.ToStringValue(listObjectsRequest.Delimiter));
            if (listObjectsRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", S3Transforms.ToStringValue(listObjectsRequest.Encoding));
            if (listObjectsRequest.IsSetMaxKeys())
                request.Parameters.Add("max-keys", S3Transforms.ToStringValue(listObjectsRequest.MaxKeys));
            if (listObjectsRequest.IsSetPrefix())
                request.Parameters.Add("prefix", S3Transforms.ToStringValue(listObjectsRequest.Prefix));
            if (listObjectsRequest.IsSetContinuationToken())
                request.Parameters.Add("continuation-token", S3Transforms.ToStringValue(listObjectsRequest.ContinuationToken));
            if (listObjectsRequest.IsSetFetchOwner())
                request.Parameters.Add("fetch-owner", listObjectsRequest.FetchOwner.ToString().ToLowerInvariant());
            if (listObjectsRequest.IsSetStartAfter())
                request.Parameters.Add("start-after", S3Transforms.ToStringValue(listObjectsRequest.StartAfter));

            request.Parameters.Add("list-type", "2");

            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
