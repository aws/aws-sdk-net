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
    /// ModifyTransitGatewayAttachmentNatConfiguration Request Marshaller
    /// </summary>
    public partial class ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayAttachmentNatConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayAttachmentNatConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyTransitGatewayAttachmentNatConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyTransitGatewayAttachmentNatConfiguration");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetNatGatewayRules())
            {
                if (publicRequest.NatGatewayRules.Count == 0)
                {
                    request.Parameters.Add("NatGatewayRule", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NatGatewayRules)
                    {
                        if (item0.IsSetMatchSourceCidr())
                        {
                            request.Parameters.Add("NatGatewayRule" + "." + index0 + ".MatchSourceCidr", StringUtils.FromString(item0.MatchSourceCidr));
                        }
                        if (item0.IsSetNatCidr())
                        {
                            request.Parameters.Add("NatGatewayRule" + "." + index0 + ".NatCidr", StringUtils.FromString(item0.NatCidr));
                        }
                        if (item0.IsSetRuleNumber())
                        {
                            request.Parameters.Add("NatGatewayRule" + "." + index0 + ".RuleNumber", StringUtils.FromInt(item0.RuleNumber.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNatGatewaySupport())
            {
                request.Parameters.Add("NatGatewaySupport", StringUtils.FromString(publicRequest.NatGatewaySupport));
            }
            if (publicRequest.IsSetNatSystemRouteSupport())
            {
                request.Parameters.Add("NatSystemRouteSupport", StringUtils.FromString(publicRequest.NatSystemRouteSupport));
            }
            if (publicRequest.IsSetResetNatGatewayRules())
            {
                request.Parameters.Add("ResetNatGatewayRules", StringUtils.FromBool(publicRequest.ResetNatGatewayRules.Value));
            }
            if (publicRequest.IsSetTransitGatewayAttachmentId())
            {
                request.Parameters.Add("TransitGatewayAttachmentId", StringUtils.FromString(publicRequest.TransitGatewayAttachmentId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller _instance = new();

        internal static ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller Instance => _instance;
    }
}
