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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Cache Subnet Group Request Marshaller
    /// </summary>       
    public class CreateCacheSubnetGroupRequestMarshaller : IMarshaller<IRequest, CreateCacheSubnetGroupRequest>
    {
        public IRequest Marshall(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest)
        {
            IRequest request = new DefaultRequest(createCacheSubnetGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "CreateCacheSubnetGroup");
            request.Parameters.Add("Version", "2012-11-15");
            if (createCacheSubnetGroupRequest != null && createCacheSubnetGroupRequest.IsSetCacheSubnetGroupName())
            {
                request.Parameters.Add("CacheSubnetGroupName", StringUtils.FromString(createCacheSubnetGroupRequest.CacheSubnetGroupName));
            }
            if (createCacheSubnetGroupRequest != null && createCacheSubnetGroupRequest.IsSetCacheSubnetGroupDescription())
            {
                request.Parameters.Add("CacheSubnetGroupDescription", StringUtils.FromString(createCacheSubnetGroupRequest.CacheSubnetGroupDescription));
            }
            if (createCacheSubnetGroupRequest != null)
            {
                List<string> subnetIdsList = createCacheSubnetGroupRequest.SubnetIds;

                int subnetIdsListIndex = 1;
                foreach (string subnetIdsListValue in subnetIdsList)
                { 
                    request.Parameters.Add("SubnetIds.member." + subnetIdsListIndex, StringUtils.FromString(subnetIdsListValue));
                    subnetIdsListIndex++;
                }
            }

            return request;
        }
    }
}
