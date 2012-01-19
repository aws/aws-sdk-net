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
    /// Describe Cache Security Groups Request Marshaller
    /// </summary>       
    public class DescribeCacheSecurityGroupsRequestMarshaller : IMarshaller<IRequest<DescribeCacheSecurityGroupsRequest>, DescribeCacheSecurityGroupsRequest> 
    {

        public IRequest<DescribeCacheSecurityGroupsRequest> Marshall(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest) 
        {
            IRequest<DescribeCacheSecurityGroupsRequest> request = new DefaultRequest<DescribeCacheSecurityGroupsRequest>(describeCacheSecurityGroupsRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeCacheSecurityGroups");
            request.Parameters.Add("Version", "2011-07-15");
            if (describeCacheSecurityGroupsRequest != null && describeCacheSecurityGroupsRequest.IsSetCacheSecurityGroupName()) 
            {
                request.Parameters.Add("CacheSecurityGroupName", StringUtils.FromString(describeCacheSecurityGroupsRequest.CacheSecurityGroupName));
            }
            if (describeCacheSecurityGroupsRequest != null && describeCacheSecurityGroupsRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeCacheSecurityGroupsRequest.MaxRecords));
            }
            if (describeCacheSecurityGroupsRequest != null && describeCacheSecurityGroupsRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeCacheSecurityGroupsRequest.Marker));
            }


            return request;
        }
    }
}
