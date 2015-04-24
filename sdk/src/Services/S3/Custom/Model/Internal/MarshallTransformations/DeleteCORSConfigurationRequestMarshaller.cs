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
    /// Delete Bucket Cors Request Marshaller
    /// </summary>       
    public class DeleteCORSConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteCORSConfigurationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((DeleteCORSConfigurationRequest)input);
		}

        public IRequest Marshall(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest)
        {
            IRequest request = new DefaultRequest(deleteCORSConfigurationRequest, "AmazonS3");

            request.HttpMethod = "DELETE";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(deleteCORSConfigurationRequest.BucketName));
            request.AddSubResource("cors");
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
