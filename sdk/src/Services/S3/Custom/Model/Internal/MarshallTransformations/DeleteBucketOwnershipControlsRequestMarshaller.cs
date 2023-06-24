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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Bucket OwenershipControls Request Marshaller
    /// </summary>
    public class DeleteBucketOwnershipControlsRequestMarshaller : IMarshaller<IRequest, DeleteBucketOwnershipControlsRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBucketOwnershipControlsRequest)input);
        }

        public IRequest Marshall(DeleteBucketOwnershipControlsRequest deleteBucketOwnershipControlsRequest)
        {
            IRequest request = new DefaultRequest(deleteBucketOwnershipControlsRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(deleteBucketOwnershipControlsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "DeleteBucketOwnershipControlsRequest.BucketName");

            if (deleteBucketOwnershipControlsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(deleteBucketOwnershipControlsRequest.ExpectedBucketOwner));

            request.ResourcePath = "/";
            request.AddSubResource("ownershipControls");
            request.UseQueryString = true;

            return request;
        }

        private static DeleteBucketOwnershipControlsRequestMarshaller _instance;

        public static DeleteBucketOwnershipControlsRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteBucketOwnershipControlsRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
