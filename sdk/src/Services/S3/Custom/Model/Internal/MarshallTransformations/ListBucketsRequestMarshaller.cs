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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Buckets Request Marshaller
    /// </summary>       
    public class ListBucketsRequestMarshaller : IMarshaller<IRequest, ListBucketsRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((ListBucketsRequest)input);
		}

        public IRequest Marshall(ListBucketsRequest listBucketsRequest)
        {
            IRequest request = new DefaultRequest(listBucketsRequest, "AmazonS3");

            request.HttpMethod = "GET";

            request.ResourcePath = "/";
            request.UseQueryString = true;

            return request;
        }
    }
}
    
