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
    /// Response Unmarshaller for TransitGatewayRouteTableAnnouncement Object
    /// </summary>  
    public class TransitGatewayRouteTableAnnouncementUnmarshaller : IXmlUnmarshaller<TransitGatewayRouteTableAnnouncement, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TransitGatewayRouteTableAnnouncement Unmarshall(XmlUnmarshallerContext context)
        {
            TransitGatewayRouteTableAnnouncement unmarshalledObject = new TransitGatewayRouteTableAnnouncement();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("announcementDirection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AnnouncementDirection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("coreNetworkId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CoreNetworkId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("peerCoreNetworkId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PeerCoreNetworkId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("peeringAttachmentId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PeeringAttachmentId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("peerTransitGatewayId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PeerTransitGatewayId = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("transitGatewayRouteTableAnnouncementId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayRouteTableAnnouncementId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGatewayRouteTableId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayRouteTableId = unmarshaller.Unmarshall(context);
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

        private static TransitGatewayRouteTableAnnouncementUnmarshaller _instance = new TransitGatewayRouteTableAnnouncementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransitGatewayRouteTableAnnouncementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}