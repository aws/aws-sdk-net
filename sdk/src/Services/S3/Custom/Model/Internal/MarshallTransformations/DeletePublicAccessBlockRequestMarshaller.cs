/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// DeletePublicAccessBlock Request Marshaller
    /// </summary>    
    public class DeletePublicAccessBlockRequestMarshaller : IMarshaller<IRequest, DeletePublicAccessBlockRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePublicAccessBlockRequest)input);
        }

        public IRequest Marshall(DeletePublicAccessBlockRequest deletePublicAccessBlockRequest)
        {
            IRequest request = new DefaultRequest(deletePublicAccessBlockRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(deletePublicAccessBlockRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "deletePublicAccessBlockRequest.BucketName");

			request.MarshallerVersion = 2;
			request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(deletePublicAccessBlockRequest.BucketName));
            request.AddSubResource("publicAccessBlock");
            request.UseQueryString = true;
            return request;
        }

        private static DeletePublicAccessBlockRequestMarshaller _instance;

        public static DeletePublicAccessBlockRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeletePublicAccessBlockRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
