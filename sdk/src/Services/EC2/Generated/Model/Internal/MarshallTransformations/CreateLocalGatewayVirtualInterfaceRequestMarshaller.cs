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
    /// CreateLocalGatewayVirtualInterface Request Marshaller
    /// </summary>       
    public class CreateLocalGatewayVirtualInterfaceRequestMarshaller : IMarshaller<IRequest, CreateLocalGatewayVirtualInterfaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLocalGatewayVirtualInterfaceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLocalGatewayVirtualInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateLocalGatewayVirtualInterface");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetLocalAddress())
                {
                    request.Parameters.Add("LocalAddress", StringUtils.FromString(publicRequest.LocalAddress));
                }
                if(publicRequest.IsSetLocalGatewayVirtualInterfaceGroupId())
                {
                    request.Parameters.Add("LocalGatewayVirtualInterfaceGroupId", StringUtils.FromString(publicRequest.LocalGatewayVirtualInterfaceGroupId));
                }
                if(publicRequest.IsSetOutpostLagId())
                {
                    request.Parameters.Add("OutpostLagId", StringUtils.FromString(publicRequest.OutpostLagId));
                }
                if(publicRequest.IsSetPeerAddress())
                {
                    request.Parameters.Add("PeerAddress", StringUtils.FromString(publicRequest.PeerAddress));
                }
                if(publicRequest.IsSetPeerBgpAsn())
                {
                    request.Parameters.Add("PeerBgpAsn", StringUtils.FromInt(publicRequest.PeerBgpAsn));
                }
                if(publicRequest.IsSetPeerBgpAsnExtended())
                {
                    request.Parameters.Add("PeerBgpAsnExtended", StringUtils.FromLong(publicRequest.PeerBgpAsnExtended));
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
                if(publicRequest.IsSetVlan())
                {
                    request.Parameters.Add("Vlan", StringUtils.FromInt(publicRequest.Vlan));
                }
            }
            return request;
        }
                    private static CreateLocalGatewayVirtualInterfaceRequestMarshaller _instance = new CreateLocalGatewayVirtualInterfaceRequestMarshaller();        

        internal static CreateLocalGatewayVirtualInterfaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLocalGatewayVirtualInterfaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}