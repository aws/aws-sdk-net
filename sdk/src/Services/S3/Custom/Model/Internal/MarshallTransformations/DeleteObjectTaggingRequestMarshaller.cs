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
using System.Globalization;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteObjectTaggingRequest Marshaller
    /// </summary>       
    public class DeleteObjectTaggingRequestMarshaller : IMarshaller<IRequest, DeleteObjectTaggingRequest>, IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall DeleteObjectTaggingRequest object into an http request.
        /// </summary>
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteObjectTaggingRequest)input);
        }

        /// <summary>
        /// Marshall DeleteObjectTaggingRequest object into an http request.
        /// </summary>
        public IRequest Marshall(DeleteObjectTaggingRequest deleteObjectTaggingRequest)
        {
            IRequest request = new DefaultRequest(deleteObjectTaggingRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (deleteObjectTaggingRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(deleteObjectTaggingRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(deleteObjectTaggingRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteObjectTaggingRequest.BucketName");
            if (string.IsNullOrEmpty(deleteObjectTaggingRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "DeleteObjectTaggingRequest.Key");
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(deleteObjectTaggingRequest.Key));
            request.ResourcePath = "/{Key+}";
            request.AddSubResource("tagging");

            if (deleteObjectTaggingRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(deleteObjectTaggingRequest.VersionId));
            
            return request;
        }

        private static DeleteObjectTaggingRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static DeleteObjectTaggingRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteObjectTaggingRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
