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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Revoke D B Security Group Ingress Request Marshaller
    /// </summary>       
    public class RevokeDBSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, RevokeDBSecurityGroupIngressRequest>
    {
        public IRequest Marshall(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest)
        {
            IRequest request = new DefaultRequest(revokeDBSecurityGroupIngressRequest, "AmazonRDS");
            request.Parameters.Add("Action", "RevokeDBSecurityGroupIngress");
            request.Parameters.Add("Version", "2013-01-10");
            if (revokeDBSecurityGroupIngressRequest != null && revokeDBSecurityGroupIngressRequest.IsSetDBSecurityGroupName())
            {
                request.Parameters.Add("DBSecurityGroupName", StringUtils.FromString(revokeDBSecurityGroupIngressRequest.DBSecurityGroupName));
            }
            if (revokeDBSecurityGroupIngressRequest != null && revokeDBSecurityGroupIngressRequest.IsSetCIDRIP())
            {
                request.Parameters.Add("CIDRIP", StringUtils.FromString(revokeDBSecurityGroupIngressRequest.CIDRIP));
            }
            if (revokeDBSecurityGroupIngressRequest != null && revokeDBSecurityGroupIngressRequest.IsSetEC2SecurityGroupName())
            {
                request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(revokeDBSecurityGroupIngressRequest.EC2SecurityGroupName));
            }
            if (revokeDBSecurityGroupIngressRequest != null && revokeDBSecurityGroupIngressRequest.IsSetEC2SecurityGroupId())
            {
                request.Parameters.Add("EC2SecurityGroupId", StringUtils.FromString(revokeDBSecurityGroupIngressRequest.EC2SecurityGroupId));
            }
            if (revokeDBSecurityGroupIngressRequest != null && revokeDBSecurityGroupIngressRequest.IsSetEC2SecurityGroupOwnerId())
            {
                request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(revokeDBSecurityGroupIngressRequest.EC2SecurityGroupOwnerId));
            }

            return request;
        }
    }
}
