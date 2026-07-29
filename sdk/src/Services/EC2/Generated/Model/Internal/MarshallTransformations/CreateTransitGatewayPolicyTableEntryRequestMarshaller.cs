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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTransitGatewayPolicyTableEntry Request Marshaller
    /// </summary>       
    public class CreateTransitGatewayPolicyTableEntryRequestMarshaller : IMarshaller<IRequest, CreateTransitGatewayPolicyTableEntryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransitGatewayPolicyTableEntryRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTransitGatewayPolicyTableEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateTransitGatewayPolicyTableEntry");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetPolicyRule())
                {
                    if(publicRequest.PolicyRule.IsSetDestinationCidrBlock())
                    {
                        request.Parameters.Add("PolicyRule" + "." + "DestinationCidrBlock", StringUtils.FromString(publicRequest.PolicyRule.DestinationCidrBlock));
                    }
                    if(publicRequest.PolicyRule.IsSetDestinationPortRange())
                    {
                        request.Parameters.Add("PolicyRule" + "." + "DestinationPortRange", StringUtils.FromString(publicRequest.PolicyRule.DestinationPortRange));
                    }
                    if(publicRequest.PolicyRule.IsSetMetaData())
                    {
                        if(publicRequest.PolicyRule.MetaData.IsSetMetaDataKey())
                        {
                            request.Parameters.Add("PolicyRule" + "." + "MetaData" + "." + "MetaDataKey", StringUtils.FromString(publicRequest.PolicyRule.MetaData.MetaDataKey));
                        }
                        if(publicRequest.PolicyRule.MetaData.IsSetMetaDataValue())
                        {
                            request.Parameters.Add("PolicyRule" + "." + "MetaData" + "." + "MetaDataValue", StringUtils.FromString(publicRequest.PolicyRule.MetaData.MetaDataValue));
                        }
                    }
                    if(publicRequest.PolicyRule.IsSetProtocol())
                    {
                        request.Parameters.Add("PolicyRule" + "." + "Protocol", StringUtils.FromString(publicRequest.PolicyRule.Protocol));
                    }
                    if(publicRequest.PolicyRule.IsSetSourceCidrBlock())
                    {
                        request.Parameters.Add("PolicyRule" + "." + "SourceCidrBlock", StringUtils.FromString(publicRequest.PolicyRule.SourceCidrBlock));
                    }
                    if(publicRequest.PolicyRule.IsSetSourcePortRange())
                    {
                        request.Parameters.Add("PolicyRule" + "." + "SourcePortRange", StringUtils.FromString(publicRequest.PolicyRule.SourcePortRange));
                    }
                }
                if(publicRequest.IsSetPolicyRuleNumber())
                {
                    request.Parameters.Add("PolicyRuleNumber", StringUtils.FromString(publicRequest.PolicyRuleNumber));
                }
                if(publicRequest.IsSetTargetRouteTableId())
                {
                    request.Parameters.Add("TargetRouteTableId", StringUtils.FromString(publicRequest.TargetRouteTableId));
                }
                if(publicRequest.IsSetTransitGatewayPolicyTableId())
                {
                    request.Parameters.Add("TransitGatewayPolicyTableId", StringUtils.FromString(publicRequest.TransitGatewayPolicyTableId));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static CreateTransitGatewayPolicyTableEntryRequestMarshaller _instance = new CreateTransitGatewayPolicyTableEntryRequestMarshaller();        

        internal static CreateTransitGatewayPolicyTableEntryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTransitGatewayPolicyTableEntryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}