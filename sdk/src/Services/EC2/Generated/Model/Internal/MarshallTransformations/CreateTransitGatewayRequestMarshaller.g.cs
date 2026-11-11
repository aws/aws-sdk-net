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
    /// CreateTransitGateway Request Marshaller
    /// </summary>
    public partial class CreateTransitGatewayRequestMarshaller : IMarshaller<IRequest, CreateTransitGatewayRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransitGatewayRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTransitGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateTransitGateway");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetOptions())
            {
                if (publicRequest.Options.IsSetAmazonSideAsn())
                {
                    request.Parameters.Add("Options" + ".AmazonSideAsn", StringUtils.FromLong(publicRequest.Options.AmazonSideAsn.Value));
                }
                if (publicRequest.Options.IsSetAutoAcceptSharedAttachments())
                {
                    request.Parameters.Add("Options" + ".AutoAcceptSharedAttachments", StringUtils.FromString(publicRequest.Options.AutoAcceptSharedAttachments));
                }
                if (publicRequest.Options.IsSetDefaultRouteTableAssociation())
                {
                    request.Parameters.Add("Options" + ".DefaultRouteTableAssociation", StringUtils.FromString(publicRequest.Options.DefaultRouteTableAssociation));
                }
                if (publicRequest.Options.IsSetDefaultRouteTablePropagation())
                {
                    request.Parameters.Add("Options" + ".DefaultRouteTablePropagation", StringUtils.FromString(publicRequest.Options.DefaultRouteTablePropagation));
                }
                if (publicRequest.Options.IsSetDnsSupport())
                {
                    request.Parameters.Add("Options" + ".DnsSupport", StringUtils.FromString(publicRequest.Options.DnsSupport));
                }
                if (publicRequest.Options.IsSetMulticastSupport())
                {
                    request.Parameters.Add("Options" + ".MulticastSupport", StringUtils.FromString(publicRequest.Options.MulticastSupport));
                }
                if (publicRequest.Options.IsSetSecurityGroupReferencingSupport())
                {
                    request.Parameters.Add("Options" + ".SecurityGroupReferencingSupport", StringUtils.FromString(publicRequest.Options.SecurityGroupReferencingSupport));
                }
                if (publicRequest.Options.IsSetTransitGatewayCidrBlocks())
                {
                    if (publicRequest.Options.TransitGatewayCidrBlocks.Count == 0)
                    {
                        request.Parameters.Add("Options" + ".TransitGatewayCidrBlocks", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Options.TransitGatewayCidrBlocks)
                        {
                            request.Parameters.Add("Options" + ".TransitGatewayCidrBlocks" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Options.IsSetVpnEcmpSupport())
                {
                    request.Parameters.Add("Options" + ".VpnEcmpSupport", StringUtils.FromString(publicRequest.Options.VpnEcmpSupport));
                }
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateTransitGatewayRequestMarshaller _instance = new();

        internal static CreateTransitGatewayRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTransitGatewayRequestMarshaller Instance => _instance;
    }
}
