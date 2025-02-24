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
    /// ModifyTransitGatewayVpcAttachment Request Marshaller
    /// </summary>       
    public class ModifyTransitGatewayVpcAttachmentRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayVpcAttachmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayVpcAttachmentRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyTransitGatewayVpcAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyTransitGatewayVpcAttachment");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddSubnetIds())
                {
                    if (publicRequest.AddSubnetIds.Count == 0)
                        request.Parameters.Add("AddSubnetIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddSubnetIds)
                         {
                             request.Parameters.Add("AddSubnetIds" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
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
                if(publicRequest.IsSetRemoveSubnetIds())
                {
                    if (publicRequest.RemoveSubnetIds.Count == 0)
                        request.Parameters.Add("RemoveSubnetIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveSubnetIds)
                         {
                             request.Parameters.Add("RemoveSubnetIds" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("TransitGatewayAttachmentId", StringUtils.FromString(publicRequest.TransitGatewayAttachmentId));
                }
            }
            return request;
        }
                    private static ModifyTransitGatewayVpcAttachmentRequestMarshaller _instance = new ModifyTransitGatewayVpcAttachmentRequestMarshaller();        

        internal static ModifyTransitGatewayVpcAttachmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyTransitGatewayVpcAttachmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}