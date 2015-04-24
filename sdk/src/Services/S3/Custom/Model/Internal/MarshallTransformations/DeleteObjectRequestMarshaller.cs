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
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Object Request Marshaller
    /// </summary>       
    public class DeleteObjectRequestMarshaller : IMarshaller<IRequest, DeleteObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((DeleteObjectRequest)input);
		}

        public IRequest Marshall(DeleteObjectRequest deleteObjectRequest)
        {
            IRequest request = new DefaultRequest(deleteObjectRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            if (deleteObjectRequest.IsSetMfaCodes())
                request.Headers.Add(HeaderKeys.XAmzMfaHeader, deleteObjectRequest.MfaCodes.FormattedMfaCodes);

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}", 
                                                 S3Transforms.ToStringValue(deleteObjectRequest.BucketName), 
                                                 S3Transforms.ToStringValue(deleteObjectRequest.Key));

            if (deleteObjectRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(deleteObjectRequest.VersionId));
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
