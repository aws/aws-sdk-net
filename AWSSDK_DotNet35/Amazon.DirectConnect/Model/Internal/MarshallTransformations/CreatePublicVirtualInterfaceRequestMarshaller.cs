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
    /// Create Public Virtual Interface Request Marshaller
    /// </summary>       
    internal class CreatePublicVirtualInterfaceRequestMarshaller : IMarshaller<IRequest, CreatePublicVirtualInterfaceRequest> 
    {
        

        public IRequest Marshall(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest) 
        {

            IRequest request = new DefaultRequest(createPublicVirtualInterfaceRequest, "AmazonDirectConnect");
            string target = "OvertureService.CreatePublicVirtualInterface";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
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
            
             
            using (StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createPublicVirtualInterfaceRequest != null && createPublicVirtualInterfaceRequest.IsSetConnectionId()) 
                {
                    writer.WritePropertyName("connectionId");
                    writer.Write(createPublicVirtualInterfaceRequest.ConnectionId);
                }

                if (createPublicVirtualInterfaceRequest != null) 
                {
                    NewPublicVirtualInterface newPublicVirtualInterface = createPublicVirtualInterfaceRequest.NewPublicVirtualInterface;
                    if (newPublicVirtualInterface != null)
                    {
                        writer.WritePropertyName("newPublicVirtualInterface");
                        writer.WriteObjectStart();
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetVirtualInterfaceName()) 
                        {
                            writer.WritePropertyName("virtualInterfaceName");
                            writer.Write(newPublicVirtualInterface.VirtualInterfaceName);
                        }
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetVlan()) 
                        {
                            writer.WritePropertyName("vlan");
                            writer.Write(newPublicVirtualInterface.Vlan);
                        }
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetAsn()) 
                        {
                            writer.WritePropertyName("asn");
                            writer.Write(newPublicVirtualInterface.Asn);
                        }
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetAuthKey()) 
                        {
                            writer.WritePropertyName("authKey");
                            writer.Write(newPublicVirtualInterface.AuthKey);
                        }
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetAmazonAddress()) 
                        {
                            writer.WritePropertyName("amazonAddress");
                            writer.Write(newPublicVirtualInterface.AmazonAddress);
                        }
                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.IsSetCustomerAddress()) 
                        {
                            writer.WritePropertyName("customerAddress");
                            writer.Write(newPublicVirtualInterface.CustomerAddress);
                        }

                        if (newPublicVirtualInterface != null && newPublicVirtualInterface.RouteFilterPrefixes != null && newPublicVirtualInterface.RouteFilterPrefixes.Count > 0)
                        {
                            List<RouteFilterPrefix> routeFilterPrefixesList = newPublicVirtualInterface.RouteFilterPrefixes;
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
