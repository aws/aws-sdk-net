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
    /// ModifyTransitGatewayVpcAttachment Request Marshaller
    /// </summary>
    public partial class ModifyTransitGatewayVpcAttachmentRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayVpcAttachmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayVpcAttachmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyTransitGatewayVpcAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyTransitGatewayVpcAttachment");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAddSubnetIds())
            {
                if (publicRequest.AddSubnetIds.Count == 0)
                {
                    request.Parameters.Add("AddSubnetIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddSubnetIds)
                    {
                        request.Parameters.Add("AddSubnetIds" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetOptions())
            {
                if (publicRequest.Options.IsSetApplianceModeSupport())
                {
                    request.Parameters.Add("Options" + ".ApplianceModeSupport", StringUtils.FromString(publicRequest.Options.ApplianceModeSupport));
                }
                if (publicRequest.Options.IsSetDnsSupport())
                {
                    request.Parameters.Add("Options" + ".DnsSupport", StringUtils.FromString(publicRequest.Options.DnsSupport));
                }
                if (publicRequest.Options.IsSetIpv6Support())
                {
                    request.Parameters.Add("Options" + ".Ipv6Support", StringUtils.FromString(publicRequest.Options.Ipv6Support));
                }
                if (publicRequest.Options.IsSetSecurityGroupReferencingSupport())
                {
                    request.Parameters.Add("Options" + ".SecurityGroupReferencingSupport", StringUtils.FromString(publicRequest.Options.SecurityGroupReferencingSupport));
                }
            }
            if (publicRequest.IsSetRemoveSubnetIds())
            {
                if (publicRequest.RemoveSubnetIds.Count == 0)
                {
                    request.Parameters.Add("RemoveSubnetIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveSubnetIds)
                    {
                        request.Parameters.Add("RemoveSubnetIds" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
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

        private static readonly ModifyTransitGatewayVpcAttachmentRequestMarshaller _instance = new();

        internal static ModifyTransitGatewayVpcAttachmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyTransitGatewayVpcAttachmentRequestMarshaller Instance => _instance;
    }
}
