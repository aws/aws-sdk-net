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
    /// Response Unmarshaller for VpnConnectionOptions Object
    /// </summary>  
    public class VpnConnectionOptionsUnmarshaller : IXmlUnmarshaller<VpnConnectionOptions, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpnConnectionOptions Unmarshall(XmlUnmarshallerContext context)
        {
            VpnConnectionOptions unmarshalledObject = new VpnConnectionOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("enableAcceleration", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnableAcceleration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("localIpv4NetworkCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LocalIpv4NetworkCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("localIpv6NetworkCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LocalIpv6NetworkCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outsideIpAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutsideIpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("remoteIpv4NetworkCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RemoteIpv4NetworkCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("remoteIpv6NetworkCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RemoteIpv6NetworkCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("staticRoutesOnly", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.StaticRoutesOnly = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transportTransitGatewayAttachmentId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransportTransitGatewayAttachmentId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tunnelInsideIpVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TunnelInsideIpVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tunnelOptionSet/item", targetDepth))
                    {
                        var unmarshaller = TunnelOptionUnmarshaller.Instance;
                        if (unmarshalledObject.TunnelOptions == null)
                        {
                            unmarshalledObject.TunnelOptions = new List<TunnelOption>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TunnelOptions.Add(item);
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

        private static VpnConnectionOptionsUnmarshaller _instance = new VpnConnectionOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpnConnectionOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}