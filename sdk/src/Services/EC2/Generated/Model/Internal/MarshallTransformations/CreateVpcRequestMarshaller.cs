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
    /// CreateVpc Request Marshaller
    /// </summary>       
    public class CreateVpcRequestMarshaller : IMarshaller<IRequest, CreateVpcRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVpcRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVpc");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAmazonProvidedIpv6CidrBlock())
                {
                    request.Parameters.Add("AmazonProvidedIpv6CidrBlock", StringUtils.FromBool(publicRequest.AmazonProvidedIpv6CidrBlock));
                }
                if(publicRequest.IsSetCidrBlock())
                {
                    request.Parameters.Add("CidrBlock", StringUtils.FromString(publicRequest.CidrBlock));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceTenancy())
                {
                    request.Parameters.Add("InstanceTenancy", StringUtils.FromString(publicRequest.InstanceTenancy));
                }
                if(publicRequest.IsSetIpv4IpamPoolId())
                {
                    request.Parameters.Add("Ipv4IpamPoolId", StringUtils.FromString(publicRequest.Ipv4IpamPoolId));
                }
                if(publicRequest.IsSetIpv4NetmaskLength())
                {
                    request.Parameters.Add("Ipv4NetmaskLength", StringUtils.FromInt(publicRequest.Ipv4NetmaskLength));
                }
                if(publicRequest.IsSetIpv6CidrBlock())
                {
                    request.Parameters.Add("Ipv6CidrBlock", StringUtils.FromString(publicRequest.Ipv6CidrBlock));
                }
                if(publicRequest.IsSetIpv6CidrBlockNetworkBorderGroup())
                {
                    request.Parameters.Add("Ipv6CidrBlockNetworkBorderGroup", StringUtils.FromString(publicRequest.Ipv6CidrBlockNetworkBorderGroup));
                }
                if(publicRequest.IsSetIpv6IpamPoolId())
                {
                    request.Parameters.Add("Ipv6IpamPoolId", StringUtils.FromString(publicRequest.Ipv6IpamPoolId));
                }
                if(publicRequest.IsSetIpv6NetmaskLength())
                {
                    request.Parameters.Add("Ipv6NetmaskLength", StringUtils.FromInt(publicRequest.Ipv6NetmaskLength));
                }
                if(publicRequest.IsSetIpv6Pool())
                {
                    request.Parameters.Add("Ipv6Pool", StringUtils.FromString(publicRequest.Ipv6Pool));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static CreateVpcRequestMarshaller _instance = new CreateVpcRequestMarshaller();        

        internal static CreateVpcRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVpcRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}