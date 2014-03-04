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
    /// Allocate Private Virtual Interface Request Marshaller
    /// </summary>       
    internal class AllocatePrivateVirtualInterfaceRequestMarshaller : IMarshaller<IRequest, AllocatePrivateVirtualInterfaceRequest> 
    {
        

        public IRequest Marshall(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest) 
        {

            IRequest request = new DefaultRequest(allocatePrivateVirtualInterfaceRequest, "AmazonDirectConnect");
            string target = "OvertureService.AllocatePrivateVirtualInterface";
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
                
                if (allocatePrivateVirtualInterfaceRequest != null && allocatePrivateVirtualInterfaceRequest.IsSetConnectionId()) 
                {
                    writer.WritePropertyName("connectionId");
                    writer.Write(allocatePrivateVirtualInterfaceRequest.ConnectionId);
                }
                if (allocatePrivateVirtualInterfaceRequest != null && allocatePrivateVirtualInterfaceRequest.IsSetOwnerAccount()) 
                {
                    writer.WritePropertyName("ownerAccount");
                    writer.Write(allocatePrivateVirtualInterfaceRequest.OwnerAccount);
                }

                if (allocatePrivateVirtualInterfaceRequest != null) 
                {
                    NewPrivateVirtualInterfaceAllocation newPrivateVirtualInterfaceAllocation = allocatePrivateVirtualInterfaceRequest.NewPrivateVirtualInterfaceAllocation;
                    if (newPrivateVirtualInterfaceAllocation != null)
                    {
                        writer.WritePropertyName("newPrivateVirtualInterfaceAllocation");
                        writer.WriteObjectStart();
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetVirtualInterfaceName()) 
                        {
                            writer.WritePropertyName("virtualInterfaceName");
                            writer.Write(newPrivateVirtualInterfaceAllocation.VirtualInterfaceName);
                        }
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetVlan()) 
                        {
                            writer.WritePropertyName("vlan");
                            writer.Write(newPrivateVirtualInterfaceAllocation.Vlan);
                        }
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetAsn()) 
                        {
                            writer.WritePropertyName("asn");
                            writer.Write(newPrivateVirtualInterfaceAllocation.Asn);
                        }
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetAuthKey()) 
                        {
                            writer.WritePropertyName("authKey");
                            writer.Write(newPrivateVirtualInterfaceAllocation.AuthKey);
                        }
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetAmazonAddress()) 
                        {
                            writer.WritePropertyName("amazonAddress");
                            writer.Write(newPrivateVirtualInterfaceAllocation.AmazonAddress);
                        }
                        if (newPrivateVirtualInterfaceAllocation != null && newPrivateVirtualInterfaceAllocation.IsSetCustomerAddress()) 
                        {
                            writer.WritePropertyName("customerAddress");
                            writer.Write(newPrivateVirtualInterfaceAllocation.CustomerAddress);
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
