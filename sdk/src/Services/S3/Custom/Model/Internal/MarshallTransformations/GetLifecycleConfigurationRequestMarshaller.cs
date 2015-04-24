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
    /// Get Bucket Lifecycle Request Marshaller
    /// </summary>       
    public class GetLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, GetLifecycleConfigurationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetLifecycleConfigurationRequest)input);
		}

        public IRequest Marshall(GetLifecycleConfigurationRequest getLifecycleConfiguration)
        {
            IRequest request = new DefaultRequest(getLifecycleConfiguration, "AmazonS3");

            request.Suppress404Exceptions = true;
            request.HttpMethod = "GET";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(getLifecycleConfiguration.BucketName));
            request.AddSubResource("lifecycle");
            request.UseQueryString = true;
            
            return request;
        }
    }
}
    
