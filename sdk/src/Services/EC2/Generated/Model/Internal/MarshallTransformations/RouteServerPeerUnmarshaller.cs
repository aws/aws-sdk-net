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
    /// Response Unmarshaller for RouteServerPeer Object
    /// </summary>  
    public class RouteServerPeerUnmarshaller : IXmlUnmarshaller<RouteServerPeer, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RouteServerPeer Unmarshall(XmlUnmarshallerContext context)
        {
            RouteServerPeer unmarshalledObject = new RouteServerPeer();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bfdStatus", targetDepth))
                    {
                        var unmarshaller = RouteServerBfdStatusUnmarshaller.Instance;
                        unmarshalledObject.BfdStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bgpOptions", targetDepth))
                    {
                        var unmarshaller = RouteServerBgpOptionsUnmarshaller.Instance;
                        unmarshalledObject.BgpOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bgpStatus", targetDepth))
                    {
                        var unmarshaller = RouteServerBgpStatusUnmarshaller.Instance;
                        unmarshalledObject.BgpStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("endpointEniAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointEniAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("endpointEniId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointEniId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("failureReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("peerAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PeerAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeServerEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RouteServerEndpointId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeServerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RouteServerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeServerPeerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RouteServerPeerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static RouteServerPeerUnmarshaller _instance = new RouteServerPeerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteServerPeerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}