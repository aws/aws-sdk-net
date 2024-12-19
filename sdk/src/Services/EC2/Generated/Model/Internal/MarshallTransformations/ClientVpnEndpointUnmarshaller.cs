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
using System.Net;
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
    /// Response Unmarshaller for ClientVpnEndpoint Object
    /// </summary>  
    public class ClientVpnEndpointUnmarshaller : IXmlUnmarshaller<ClientVpnEndpoint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClientVpnEndpoint Unmarshall(XmlUnmarshallerContext context)
        {
            ClientVpnEndpoint unmarshalledObject = new ClientVpnEndpoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("associatedTargetNetwork/item", targetDepth))
                    {
                        var unmarshaller = AssociatedTargetNetworkUnmarshaller.Instance;
                        if (unmarshalledObject.AssociatedTargetNetworks == null)
                        {
                            unmarshalledObject.AssociatedTargetNetworks = new List<AssociatedTargetNetwork>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AssociatedTargetNetworks.Add(item);
                        continue;
                    }
                    if (context.TestExpression("authenticationOptions/item", targetDepth))
                    {
                        var unmarshaller = ClientVpnAuthenticationUnmarshaller.Instance;
                        if (unmarshalledObject.AuthenticationOptions == null)
                        {
                            unmarshalledObject.AuthenticationOptions = new List<ClientVpnAuthentication>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AuthenticationOptions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("clientCidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientCidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientConnectOptions", targetDepth))
                    {
                        var unmarshaller = ClientConnectResponseOptionsUnmarshaller.Instance;
                        unmarshalledObject.ClientConnectOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientLoginBannerOptions", targetDepth))
                    {
                        var unmarshaller = ClientLoginBannerResponseOptionsUnmarshaller.Instance;
                        unmarshalledObject.ClientLoginBannerOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientVpnEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientVpnEndpointId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("connectionLogOptions", targetDepth))
                    {
                        var unmarshaller = ConnectionLogResponseOptionsUnmarshaller.Instance;
                        unmarshalledObject.ConnectionLogOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deletionTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeletionTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dnsName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dnsServer/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.DnsServers == null)
                        {
                            unmarshalledObject.DnsServers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DnsServers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("securityGroupIdSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SecurityGroupIds == null)
                        {
                            unmarshalledObject.SecurityGroupIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroupIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("selfServicePortalUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SelfServicePortalUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serverCertificateArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServerCertificateArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sessionTimeoutHours", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SessionTimeoutHours = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("splitTunnel", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SplitTunnel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = ClientVpnEndpointStatusUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("transportProtocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransportProtocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpnPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.VpnPort = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpnProtocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpnProtocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static ClientVpnEndpointUnmarshaller _instance = new ClientVpnEndpointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClientVpnEndpointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}