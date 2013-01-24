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
    /// Revoke Cache Security Group Ingress Request Marshaller
    /// </summary>       
    public class RevokeCacheSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, RevokeCacheSecurityGroupIngressRequest>
    {
        public IRequest Marshall(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest)
        {
            IRequest request = new DefaultRequest(revokeCacheSecurityGroupIngressRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "RevokeCacheSecurityGroupIngress");
            request.Parameters.Add("Version", "2012-11-15");
            if (revokeCacheSecurityGroupIngressRequest != null && revokeCacheSecurityGroupIngressRequest.IsSetCacheSecurityGroupName())
            {
                request.Parameters.Add("CacheSecurityGroupName", StringUtils.FromString(revokeCacheSecurityGroupIngressRequest.CacheSecurityGroupName));
            }
            if (revokeCacheSecurityGroupIngressRequest != null && revokeCacheSecurityGroupIngressRequest.IsSetEC2SecurityGroupName())
            {
                request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(revokeCacheSecurityGroupIngressRequest.EC2SecurityGroupName));
            }
            if (revokeCacheSecurityGroupIngressRequest != null && revokeCacheSecurityGroupIngressRequest.IsSetEC2SecurityGroupOwnerId())
            {
                request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(revokeCacheSecurityGroupIngressRequest.EC2SecurityGroupOwnerId));
            }

            return request;
        }
    }
}
