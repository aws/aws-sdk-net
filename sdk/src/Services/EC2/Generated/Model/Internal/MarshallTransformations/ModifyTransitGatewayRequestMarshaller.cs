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
    /// ModifyTransitGateway Request Marshaller
    /// </summary>       
    public class ModifyTransitGatewayRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyTransitGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyTransitGateway");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetOptions())
                {
                    if(publicRequest.Options.IsSetAddTransitGatewayCidrBlocks())
                    {
                        if (publicRequest.Options.AddTransitGatewayCidrBlocks.Count == 0)
                            request.Parameters.Add("Options" + "." + "AddTransitGatewayCidrBlocks", "");
                        else
                        {
                             int publicRequestOptionslistValueIndex = 1;
                             foreach(var publicRequestOptionslistValue in publicRequest.Options.AddTransitGatewayCidrBlocks)
                             {
                                 request.Parameters.Add("Options" + "." + "AddTransitGatewayCidrBlocks" + "." + publicRequestOptionslistValueIndex, StringUtils.FromString(publicRequestOptionslistValue));
                                 publicRequestOptionslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Options.IsSetAmazonSideAsn())
                    {
                        request.Parameters.Add("Options" + "." + "AmazonSideAsn", StringUtils.FromLong(publicRequest.Options.AmazonSideAsn));
                    }
                    if(publicRequest.Options.IsSetAssociationDefaultRouteTableId())
                    {
                        request.Parameters.Add("Options" + "." + "AssociationDefaultRouteTableId", StringUtils.FromString(publicRequest.Options.AssociationDefaultRouteTableId));
                    }
                    if(publicRequest.Options.IsSetAutoAcceptSharedAttachments())
                    {
                        request.Parameters.Add("Options" + "." + "AutoAcceptSharedAttachments", StringUtils.FromString(publicRequest.Options.AutoAcceptSharedAttachments));
                    }
                    if(publicRequest.Options.IsSetDefaultRouteTableAssociation())
                    {
                        request.Parameters.Add("Options" + "." + "DefaultRouteTableAssociation", StringUtils.FromString(publicRequest.Options.DefaultRouteTableAssociation));
                    }
                    if(publicRequest.Options.IsSetDefaultRouteTablePropagation())
                    {
                        request.Parameters.Add("Options" + "." + "DefaultRouteTablePropagation", StringUtils.FromString(publicRequest.Options.DefaultRouteTablePropagation));
                    }
                    if(publicRequest.Options.IsSetDnsSupport())
                    {
                        request.Parameters.Add("Options" + "." + "DnsSupport", StringUtils.FromString(publicRequest.Options.DnsSupport));
                    }
                    if(publicRequest.Options.IsSetPropagationDefaultRouteTableId())
                    {
                        request.Parameters.Add("Options" + "." + "PropagationDefaultRouteTableId", StringUtils.FromString(publicRequest.Options.PropagationDefaultRouteTableId));
                    }
                    if(publicRequest.Options.IsSetRemoveTransitGatewayCidrBlocks())
                    {
                        if (publicRequest.Options.RemoveTransitGatewayCidrBlocks.Count == 0)
                            request.Parameters.Add("Options" + "." + "RemoveTransitGatewayCidrBlocks", "");
                        else
                        {
                             int publicRequestOptionslistValueIndex = 1;
                             foreach(var publicRequestOptionslistValue in publicRequest.Options.RemoveTransitGatewayCidrBlocks)
                             {
                                 request.Parameters.Add("Options" + "." + "RemoveTransitGatewayCidrBlocks" + "." + publicRequestOptionslistValueIndex, StringUtils.FromString(publicRequestOptionslistValue));
                                 publicRequestOptionslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Options.IsSetSecurityGroupReferencingSupport())
                    {
                        request.Parameters.Add("Options" + "." + "SecurityGroupReferencingSupport", StringUtils.FromString(publicRequest.Options.SecurityGroupReferencingSupport));
                    }
                    if(publicRequest.Options.IsSetVpnEcmpSupport())
                    {
                        request.Parameters.Add("Options" + "." + "VpnEcmpSupport", StringUtils.FromString(publicRequest.Options.VpnEcmpSupport));
                    }
                }
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
            }
            return request;
        }
                    private static ModifyTransitGatewayRequestMarshaller _instance = new ModifyTransitGatewayRequestMarshaller();        

        internal static ModifyTransitGatewayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyTransitGatewayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}