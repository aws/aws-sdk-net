/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Authorize Cache Security Group Ingress Request Marshaller
    /// </summary>       
    public class AuthorizeCacheSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest<AuthorizeCacheSecurityGroupIngressRequest>, AuthorizeCacheSecurityGroupIngressRequest> 
    {

        public IRequest<AuthorizeCacheSecurityGroupIngressRequest> Marshall(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest) 
        {
            IRequest<AuthorizeCacheSecurityGroupIngressRequest> request = new DefaultRequest<AuthorizeCacheSecurityGroupIngressRequest>(authorizeCacheSecurityGroupIngressRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "AuthorizeCacheSecurityGroupIngress");
            request.Parameters.Add("Version", "2011-07-15");
            if (authorizeCacheSecurityGroupIngressRequest != null && authorizeCacheSecurityGroupIngressRequest.IsSetCacheSecurityGroupName()) 
            {
                request.Parameters.Add("CacheSecurityGroupName", StringUtils.FromString(authorizeCacheSecurityGroupIngressRequest.CacheSecurityGroupName));
            }
            if (authorizeCacheSecurityGroupIngressRequest != null && authorizeCacheSecurityGroupIngressRequest.IsSetEC2SecurityGroupName()) 
            {
                request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(authorizeCacheSecurityGroupIngressRequest.EC2SecurityGroupName));
            }
            if (authorizeCacheSecurityGroupIngressRequest != null && authorizeCacheSecurityGroupIngressRequest.IsSetEC2SecurityGroupOwnerId()) 
            {
                request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(authorizeCacheSecurityGroupIngressRequest.EC2SecurityGroupOwnerId));
            }


            return request;
        }
    }
}
