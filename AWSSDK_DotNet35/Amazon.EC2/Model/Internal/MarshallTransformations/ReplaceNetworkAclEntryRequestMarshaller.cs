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
    /// Replace Network Acl Entry Request Marshaller
    /// </summary>       
    public class ReplaceNetworkAclEntryRequestMarshaller : IMarshaller<IRequest, ReplaceNetworkAclEntryRequest>
    {
        public IRequest Marshall(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest)
        {
            IRequest request = new DefaultRequest(replaceNetworkAclEntryRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ReplaceNetworkAclEntry");
            request.Parameters.Add("Version", "2013-10-15");
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetNetworkAclId())
            {
                request.Parameters.Add("NetworkAclId", StringUtils.FromString(replaceNetworkAclEntryRequest.NetworkAclId));
            }
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetRuleNumber())
            {
                request.Parameters.Add("RuleNumber", StringUtils.FromInt(replaceNetworkAclEntryRequest.RuleNumber));
            }
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(replaceNetworkAclEntryRequest.Protocol));
            }
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetRuleAction())
            {
                request.Parameters.Add("RuleAction", StringUtils.FromString(replaceNetworkAclEntryRequest.RuleAction));
            }
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetEgress())
            {
                request.Parameters.Add("Egress", StringUtils.FromBool(replaceNetworkAclEntryRequest.Egress));
            }
            if (replaceNetworkAclEntryRequest != null && replaceNetworkAclEntryRequest.IsSetCidrBlock())
            {
                request.Parameters.Add("CidrBlock", StringUtils.FromString(replaceNetworkAclEntryRequest.CidrBlock));
            }
            if (replaceNetworkAclEntryRequest != null)
            {
                IcmpTypeCode icmpTypeCode = replaceNetworkAclEntryRequest.IcmpTypeCode;
                if (icmpTypeCode != null && icmpTypeCode.IsSetType())
                {
                    request.Parameters.Add("Icmp.Type", StringUtils.FromInt(icmpTypeCode.Type));
                }
                if (icmpTypeCode != null && icmpTypeCode.IsSetCode())
                {
                    request.Parameters.Add("Icmp.Code", StringUtils.FromInt(icmpTypeCode.Code));
                }
            }
            if (replaceNetworkAclEntryRequest != null)
            {
                PortRange portRange = replaceNetworkAclEntryRequest.PortRange;
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
