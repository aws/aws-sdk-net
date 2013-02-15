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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Revoke Cluster Security Group Ingress Request Marshaller
    /// </summary>       
    public class RevokeClusterSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, RevokeClusterSecurityGroupIngressRequest>
    {
        public IRequest Marshall(RevokeClusterSecurityGroupIngressRequest revokeClusterSecurityGroupIngressRequest)
        {
            IRequest request = new DefaultRequest(revokeClusterSecurityGroupIngressRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "RevokeClusterSecurityGroupIngress");
            request.Parameters.Add("Version", "2012-12-01");
            if (revokeClusterSecurityGroupIngressRequest != null && revokeClusterSecurityGroupIngressRequest.IsSetClusterSecurityGroupName())
            {
                request.Parameters.Add("ClusterSecurityGroupName", StringUtils.FromString(revokeClusterSecurityGroupIngressRequest.ClusterSecurityGroupName));
            }
            if (revokeClusterSecurityGroupIngressRequest != null && revokeClusterSecurityGroupIngressRequest.IsSetCIDRIP())
            {
                request.Parameters.Add("CIDRIP", StringUtils.FromString(revokeClusterSecurityGroupIngressRequest.CIDRIP));
            }
            if (revokeClusterSecurityGroupIngressRequest != null && revokeClusterSecurityGroupIngressRequest.IsSetEC2SecurityGroupName())
            {
                request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(revokeClusterSecurityGroupIngressRequest.EC2SecurityGroupName));
            }
            if (revokeClusterSecurityGroupIngressRequest != null && revokeClusterSecurityGroupIngressRequest.IsSetEC2SecurityGroupOwnerId())
            {
                request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(revokeClusterSecurityGroupIngressRequest.EC2SecurityGroupOwnerId));
            }

            return request;
        }
    }
}
