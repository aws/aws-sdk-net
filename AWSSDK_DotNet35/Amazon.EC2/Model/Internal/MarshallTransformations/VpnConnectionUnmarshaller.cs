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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VpnConnection Unmarshaller
     /// </summary>
    internal class VpnConnectionUnmarshaller : IUnmarshaller<VpnConnection, XmlUnmarshallerContext>, IUnmarshaller<VpnConnection, JsonUnmarshallerContext> 
    {
        public VpnConnection Unmarshall(XmlUnmarshallerContext context) 
        {
            VpnConnection vpnConnection = new VpnConnection();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("vpnConnectionId", targetDepth))
                    {
                        vpnConnection.VpnConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        vpnConnection.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("customerGatewayConfiguration", targetDepth))
                    {
                        vpnConnection.CustomerGatewayConfiguration = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        vpnConnection.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("customerGatewayId", targetDepth))
                    {
                        vpnConnection.CustomerGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpnGatewayId", targetDepth))
                    {
                        vpnConnection.VpnGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        vpnConnection.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("vgwTelemetry/item", targetDepth))
                    {
                        vpnConnection.VgwTelemetry.Add(VgwTelemetryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("options", targetDepth))
                    {
                        vpnConnection.Options = VpnConnectionOptionsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("routes/item", targetDepth))
                    {
                        vpnConnection.Routes.Add(VpnStaticRouteUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpnConnection;
                }
            }
                        


            return vpnConnection;
        }

        public VpnConnection Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpnConnectionUnmarshaller instance;

        public static VpnConnectionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpnConnectionUnmarshaller();

            return instance;
        }
    }
}
    
