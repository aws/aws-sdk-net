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
    /// ModifyTransitGatewayPolicyTableEntry Request Marshaller
    /// </summary>
    public partial class ModifyTransitGatewayPolicyTableEntryRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayPolicyTableEntryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayPolicyTableEntryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyTransitGatewayPolicyTableEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyTransitGatewayPolicyTableEntry");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetPolicyRule())
            {
                if (publicRequest.PolicyRule.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("PolicyRule" + ".DestinationCidrBlock", StringUtils.FromString(publicRequest.PolicyRule.DestinationCidrBlock));
                }
                if (publicRequest.PolicyRule.IsSetDestinationPortRange())
                {
                    request.Parameters.Add("PolicyRule" + ".DestinationPortRange", StringUtils.FromString(publicRequest.PolicyRule.DestinationPortRange));
                }
                if (publicRequest.PolicyRule.IsSetMetaData())
                {
                    if (publicRequest.PolicyRule.MetaData.IsSetMetaDataKey())
                    {
                        request.Parameters.Add("PolicyRule" + ".MetaData" + ".MetaDataKey", StringUtils.FromString(publicRequest.PolicyRule.MetaData.MetaDataKey));
                    }
                    if (publicRequest.PolicyRule.MetaData.IsSetMetaDataValue())
                    {
                        request.Parameters.Add("PolicyRule" + ".MetaData" + ".MetaDataValue", StringUtils.FromString(publicRequest.PolicyRule.MetaData.MetaDataValue));
                    }
                }
                if (publicRequest.PolicyRule.IsSetProtocol())
                {
                    request.Parameters.Add("PolicyRule" + ".Protocol", StringUtils.FromString(publicRequest.PolicyRule.Protocol));
                }
                if (publicRequest.PolicyRule.IsSetSourceCidrBlock())
                {
                    request.Parameters.Add("PolicyRule" + ".SourceCidrBlock", StringUtils.FromString(publicRequest.PolicyRule.SourceCidrBlock));
                }
                if (publicRequest.PolicyRule.IsSetSourcePortRange())
                {
                    request.Parameters.Add("PolicyRule" + ".SourcePortRange", StringUtils.FromString(publicRequest.PolicyRule.SourcePortRange));
                }
            }
            if (publicRequest.IsSetPolicyRuleNumber())
            {
                request.Parameters.Add("PolicyRuleNumber", StringUtils.FromString(publicRequest.PolicyRuleNumber));
            }
            if (publicRequest.IsSetTargetRouteTableId())
            {
                request.Parameters.Add("TargetRouteTableId", StringUtils.FromString(publicRequest.TargetRouteTableId));
            }
            if (publicRequest.IsSetTransitGatewayPolicyTableId())
            {
                request.Parameters.Add("TransitGatewayPolicyTableId", StringUtils.FromString(publicRequest.TransitGatewayPolicyTableId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyTransitGatewayPolicyTableEntryRequestMarshaller _instance = new();

        internal static ModifyTransitGatewayPolicyTableEntryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyTransitGatewayPolicyTableEntryRequestMarshaller Instance => _instance;
    }
}
