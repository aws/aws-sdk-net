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
    /// CreateTransitGatewayVpcAttachment Request Marshaller
    /// </summary>       
    public class CreateTransitGatewayVpcAttachmentRequestMarshaller : IMarshaller<IRequest, CreateTransitGatewayVpcAttachmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransitGatewayVpcAttachmentRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTransitGatewayVpcAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateTransitGatewayVpcAttachment");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetOptions())
                {
                    if(publicRequest.Options.IsSetApplianceModeSupport())
                    {
                        request.Parameters.Add("Options" + "." + "ApplianceModeSupport", StringUtils.FromString(publicRequest.Options.ApplianceModeSupport));
                    }
                    if(publicRequest.Options.IsSetDnsSupport())
                    {
                        request.Parameters.Add("Options" + "." + "DnsSupport", StringUtils.FromString(publicRequest.Options.DnsSupport));
                    }
                    if(publicRequest.Options.IsSetIpv6Support())
                    {
                        request.Parameters.Add("Options" + "." + "Ipv6Support", StringUtils.FromString(publicRequest.Options.Ipv6Support));
                    }
                    if(publicRequest.Options.IsSetSecurityGroupReferencingSupport())
                    {
                        request.Parameters.Add("Options" + "." + "SecurityGroupReferencingSupport", StringUtils.FromString(publicRequest.Options.SecurityGroupReferencingSupport));
                    }
                }
                if(publicRequest.IsSetSubnetIds())
                {
                    if (publicRequest.SubnetIds.Count == 0)
                        request.Parameters.Add("SubnetIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SubnetIds)
                         {
                             request.Parameters.Add("SubnetIds" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecifications", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
                if(publicRequest.IsSetVpcId())
                {
                    request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
                }
            }
            return request;
        }
                    private static CreateTransitGatewayVpcAttachmentRequestMarshaller _instance = new CreateTransitGatewayVpcAttachmentRequestMarshaller();        

        internal static CreateTransitGatewayVpcAttachmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTransitGatewayVpcAttachmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}