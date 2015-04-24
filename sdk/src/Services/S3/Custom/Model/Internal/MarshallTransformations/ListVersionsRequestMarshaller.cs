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
    /// List Object Versions Request Marshaller
    /// </summary>       
    public class ListVersionsRequestMarshaller : IMarshaller<IRequest, ListVersionsRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((ListVersionsRequest)input);
		}

        public IRequest Marshall(ListVersionsRequest listVersionsRequest)
        {
            IRequest request = new DefaultRequest(listVersionsRequest, "AmazonS3");

            request.HttpMethod = "GET";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(listVersionsRequest.BucketName));

            request.AddSubResource("versions");

            if (listVersionsRequest.IsSetDelimiter())
                request.Parameters.Add("delimiter", S3Transforms.ToStringValue(listVersionsRequest.Delimiter));
            if (listVersionsRequest.IsSetKeyMarker())
                request.Parameters.Add("key-marker", S3Transforms.ToStringValue(listVersionsRequest.KeyMarker));
            if (listVersionsRequest.IsSetMaxKeys())
                request.Parameters.Add("max-keys", S3Transforms.ToStringValue(listVersionsRequest.MaxKeys));
            if (listVersionsRequest.IsSetPrefix())
                request.Parameters.Add("prefix", S3Transforms.ToStringValue(listVersionsRequest.Prefix));
            if (listVersionsRequest.IsSetVersionIdMarker())
                request.Parameters.Add("version-id-marker", S3Transforms.ToStringValue(listVersionsRequest.VersionIdMarker));
            if (listVersionsRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", S3Transforms.ToStringValue(listVersionsRequest.Encoding));

            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
