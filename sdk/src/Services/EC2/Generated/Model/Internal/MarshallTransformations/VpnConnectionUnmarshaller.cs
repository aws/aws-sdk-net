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
    /// Response Unmarshaller for VpnConnection Object
    /// </summary>  
    public class VpnConnectionUnmarshaller : IXmlUnmarshaller<VpnConnection, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpnConnection Unmarshall(XmlUnmarshallerContext context)
        {
            VpnConnection unmarshalledObject = new VpnConnection();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("category", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("coreNetworkArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CoreNetworkArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("coreNetworkAttachmentArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CoreNetworkAttachmentArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerGatewayConfiguration", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomerGatewayConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerGatewayId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomerGatewayId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("gatewayAssociationState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GatewayAssociationState = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("options", targetDepth))
                    {
                        var unmarshaller = VpnConnectionOptionsUnmarshaller.Instance;
                        unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routes/item", targetDepth))
                    {
                        var unmarshaller = VpnStaticRouteUnmarshaller.Instance;
                        if (unmarshalledObject.Routes == null)
                        {
                            unmarshalledObject.Routes = new List<VpnStaticRoute>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Routes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("transitGatewayId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vgwTelemetry/item", targetDepth))
                    {
                        var unmarshaller = VgwTelemetryUnmarshaller.Instance;
                        if (unmarshalledObject.VgwTelemetry == null)
                        {
                            unmarshalledObject.VgwTelemetry = new List<VgwTelemetry>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VgwTelemetry.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vpnConnectionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpnConnectionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpnGatewayId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpnGatewayId = unmarshaller.Unmarshall(context);
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

        private static VpnConnectionUnmarshaller _instance = new VpnConnectionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpnConnectionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}