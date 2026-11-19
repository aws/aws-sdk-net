/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNetworkAclEntry Request Marshaller
    /// </summary>
    public partial class CreateNetworkAclEntryRequestMarshaller : IMarshaller<IRequest, CreateNetworkAclEntryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkAclEntryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateNetworkAclEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateNetworkAclEntry");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCidrBlock())
            {
                request.Parameters.Add("CidrBlock", StringUtils.FromString(publicRequest.CidrBlock));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEgress())
            {
                request.Parameters.Add("Egress", StringUtils.FromBool(publicRequest.Egress.Value));
            }
            if (publicRequest.IsSetIcmpTypeCode())
            {
                if (publicRequest.IcmpTypeCode.IsSetCode())
                {
                    request.Parameters.Add("Icmp" + ".Code", StringUtils.FromInt(publicRequest.IcmpTypeCode.Code.Value));
                }
                if (publicRequest.IcmpTypeCode.IsSetType())
                {
                    request.Parameters.Add("Icmp" + ".Type", StringUtils.FromInt(publicRequest.IcmpTypeCode.Type.Value));
                }
            }
            if (publicRequest.IsSetIpv6CidrBlock())
            {
                request.Parameters.Add("Ipv6CidrBlock", StringUtils.FromString(publicRequest.Ipv6CidrBlock));
            }
            if (publicRequest.IsSetNetworkAclId())
            {
                request.Parameters.Add("NetworkAclId", StringUtils.FromString(publicRequest.NetworkAclId));
            }
            if (publicRequest.IsSetPortRange())
            {
                if (publicRequest.PortRange.IsSetFrom())
                {
                    request.Parameters.Add("PortRange" + ".From", StringUtils.FromInt(publicRequest.PortRange.From.Value));
                }
                if (publicRequest.PortRange.IsSetTo())
                {
                    request.Parameters.Add("PortRange" + ".To", StringUtils.FromInt(publicRequest.PortRange.To.Value));
                }
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
            }
            if (publicRequest.IsSetRuleAction())
            {
                request.Parameters.Add("RuleAction", StringUtils.FromString(publicRequest.RuleAction));
            }
            if (publicRequest.IsSetRuleNumber())
            {
                request.Parameters.Add("RuleNumber", StringUtils.FromInt(publicRequest.RuleNumber.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateNetworkAclEntryRequestMarshaller _instance = new();

        internal static CreateNetworkAclEntryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateNetworkAclEntryRequestMarshaller Instance => _instance;
    }
}
