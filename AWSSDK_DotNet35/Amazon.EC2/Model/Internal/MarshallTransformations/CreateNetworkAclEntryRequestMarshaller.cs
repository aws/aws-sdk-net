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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Network Acl Entry Request Marshaller
    /// </summary>       
    public class CreateNetworkAclEntryRequestMarshaller : IMarshaller<IRequest, CreateNetworkAclEntryRequest>
    {
        public IRequest Marshall(CreateNetworkAclEntryRequest createNetworkAclEntryRequest)
        {
            IRequest request = new DefaultRequest(createNetworkAclEntryRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateNetworkAclEntry");
            request.Parameters.Add("Version", "2013-10-15");
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetNetworkAclId())
            {
                request.Parameters.Add("NetworkAclId", StringUtils.FromString(createNetworkAclEntryRequest.NetworkAclId));
            }
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetRuleNumber())
            {
                request.Parameters.Add("RuleNumber", StringUtils.FromInt(createNetworkAclEntryRequest.RuleNumber));
            }
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(createNetworkAclEntryRequest.Protocol));
            }
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetRuleAction())
            {
                request.Parameters.Add("RuleAction", StringUtils.FromString(createNetworkAclEntryRequest.RuleAction));
            }
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetEgress())
            {
                request.Parameters.Add("Egress", StringUtils.FromBool(createNetworkAclEntryRequest.Egress));
            }
            if (createNetworkAclEntryRequest != null && createNetworkAclEntryRequest.IsSetCidrBlock())
            {
                request.Parameters.Add("CidrBlock", StringUtils.FromString(createNetworkAclEntryRequest.CidrBlock));
            }
            if (createNetworkAclEntryRequest != null)
            {
                IcmpTypeCode icmpTypeCode = createNetworkAclEntryRequest.IcmpTypeCode;
                if (icmpTypeCode != null && icmpTypeCode.IsSetType())
                {
                    request.Parameters.Add("Icmp.Type", StringUtils.FromInt(icmpTypeCode.Type));
                }
                if (icmpTypeCode != null && icmpTypeCode.IsSetCode())
                {
                    request.Parameters.Add("Icmp.Code", StringUtils.FromInt(icmpTypeCode.Code));
                }
            }
            if (createNetworkAclEntryRequest != null)
            {
                PortRange portRange = createNetworkAclEntryRequest.PortRange;
                if (portRange != null && portRange.IsSetFrom())
                {
                    request.Parameters.Add("PortRange.From", StringUtils.FromInt(portRange.From));
                }
                if (portRange != null && portRange.IsSetTo())
                {
                    request.Parameters.Add("PortRange.To", StringUtils.FromInt(portRange.To));
                }
            }

            return request;
        }
    }
}
