/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Allocate Public Virtual Interface Request Marshaller
    /// </summary>       
    internal class AllocatePublicVirtualInterfaceRequestMarshaller : IMarshaller<IRequest, AllocatePublicVirtualInterfaceRequest> 
    {
        

        public IRequest Marshall(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest) 
        {

            IRequest request = new DefaultRequest(allocatePublicVirtualInterfaceRequest, "AmazonDirectConnect");
            string target = "OvertureService.AllocatePublicVirtualInterface";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (allocatePublicVirtualInterfaceRequest != null && allocatePublicVirtualInterfaceRequest.IsSetConnectionId()) 
                {
                    writer.WritePropertyName("connectionId");
                    writer.Write(allocatePublicVirtualInterfaceRequest.ConnectionId);
                }
                if (allocatePublicVirtualInterfaceRequest != null && allocatePublicVirtualInterfaceRequest.IsSetOwnerAccount()) 
                {
                    writer.WritePropertyName("ownerAccount");
                    writer.Write(allocatePublicVirtualInterfaceRequest.OwnerAccount);
                }

                if (allocatePublicVirtualInterfaceRequest != null) 
                {
                    NewPublicVirtualInterfaceAllocation newPublicVirtualInterfaceAllocation = allocatePublicVirtualInterfaceRequest.NewPublicVirtualInterfaceAllocation;
                    if (newPublicVirtualInterfaceAllocation != null)
                    {
                        writer.WritePropertyName("newPublicVirtualInterfaceAllocation");
                        writer.WriteObjectStart();
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetVirtualInterfaceName()) 
                        {
                            writer.WritePropertyName("virtualInterfaceName");
                            writer.Write(newPublicVirtualInterfaceAllocation.VirtualInterfaceName);
                        }
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetVlan()) 
                        {
                            writer.WritePropertyName("vlan");
                            writer.Write(newPublicVirtualInterfaceAllocation.Vlan);
                        }
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetAsn()) 
                        {
                            writer.WritePropertyName("asn");
                            writer.Write(newPublicVirtualInterfaceAllocation.Asn);
                        }
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetAuthKey()) 
                        {
                            writer.WritePropertyName("authKey");
                            writer.Write(newPublicVirtualInterfaceAllocation.AuthKey);
                        }
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetAmazonAddress()) 
                        {
                            writer.WritePropertyName("amazonAddress");
                            writer.Write(newPublicVirtualInterfaceAllocation.AmazonAddress);
                        }
                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.IsSetCustomerAddress()) 
                        {
                            writer.WritePropertyName("customerAddress");
                            writer.Write(newPublicVirtualInterfaceAllocation.CustomerAddress);
                        }

                        if (newPublicVirtualInterfaceAllocation != null && newPublicVirtualInterfaceAllocation.RouteFilterPrefixes != null && newPublicVirtualInterfaceAllocation.RouteFilterPrefixes.Count > 0)
                        {
                            List<RouteFilterPrefix> routeFilterPrefixesList = newPublicVirtualInterfaceAllocation.RouteFilterPrefixes;
                            writer.WritePropertyName("routeFilterPrefixes");
                            writer.WriteArrayStart();

                            foreach (RouteFilterPrefix routeFilterPrefixesListValue in routeFilterPrefixesList) 
                            {
                                writer.WriteObjectStart();
                                if (routeFilterPrefixesListValue != null && routeFilterPrefixesListValue.IsSetCidr()) 
                                {
                                    writer.WritePropertyName("cidr");
                                    writer.Write(routeFilterPrefixesListValue.Cidr);
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
