/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Transform
{
    /// <summary>
    /// Create Cache Parameter Group Request Marshaller
    /// </summary>       
    public class CreateCacheParameterGroupRequestMarshaller : IMarshaller<IRequest<CreateCacheParameterGroupRequest>, CreateCacheParameterGroupRequest> 
    {

        public IRequest<CreateCacheParameterGroupRequest> Marshall(CreateCacheParameterGroupRequest createCacheParameterGroupRequest) 
        {
            IRequest<CreateCacheParameterGroupRequest> request = new DefaultRequest<CreateCacheParameterGroupRequest>(createCacheParameterGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "CreateCacheParameterGroup");
            request.Parameters.Add("Version", "2011-07-15");
            if (createCacheParameterGroupRequest != null && createCacheParameterGroupRequest.IsSetCacheParameterGroupName()) 
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(createCacheParameterGroupRequest.CacheParameterGroupName));
            }
            if (createCacheParameterGroupRequest != null && createCacheParameterGroupRequest.IsSetCacheParameterGroupFamily()) 
            {
                request.Parameters.Add("CacheParameterGroupFamily", StringUtils.FromString(createCacheParameterGroupRequest.CacheParameterGroupFamily));
            }
            if (createCacheParameterGroupRequest != null && createCacheParameterGroupRequest.IsSetDescription()) 
            {
                request.Parameters.Add("Description", StringUtils.FromString(createCacheParameterGroupRequest.Description));
            }


            return request;
        }
    }
}
