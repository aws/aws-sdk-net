/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Invalidation Request Marshaller
    /// </summary>       
    public class GetInvalidationRequestMarshaller : IMarshaller<IRequest, GetInvalidationRequest>
    {
        
    
        public IRequest Marshall(GetInvalidationRequest getInvalidationRequest)
        {
            IRequest request = new DefaultRequest(getInvalidationRequest, "AmazonCloudFront");



            request.HttpMethod = "GET";
            string uriResourcePath = "2014-01-31/distribution/{DistributionId}/invalidation/{Id}"; 
            uriResourcePath = uriResourcePath.Replace("{DistributionId}", getInvalidationRequest.IsSetDistributionId() ? getInvalidationRequest.DistributionId.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Id}", getInvalidationRequest.IsSetId() ? getInvalidationRequest.Id.ToString() : "" ); 
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
            
            
            return request;
        }
    }
}
    
