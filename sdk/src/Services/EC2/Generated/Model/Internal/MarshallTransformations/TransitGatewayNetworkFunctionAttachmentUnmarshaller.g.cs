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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TransitGatewayNetworkFunctionAttachment Object
    /// </summary>
    public partial class TransitGatewayNetworkFunctionAttachmentUnmarshaller : IXmlUnmarshaller<TransitGatewayNetworkFunctionAttachment, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TransitGatewayNetworkFunctionAttachment Unmarshall(XmlUnmarshallerContext context)
        {
            TransitGatewayNetworkFunctionAttachment unmarshalledObject = new TransitGatewayNetworkFunctionAttachment();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("availabilityZoneIdSet/item", targetDepth))
                    {
                        if (unmarshalledObject.AvailabilityZoneIds == null)
                        {
                            unmarshalledObject.AvailabilityZoneIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneSet/item", targetDepth))
                    {
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZones.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("resourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("resourceOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceOwnerId = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("transitGatewayAttachmentId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayAttachmentId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("transitGatewayId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("transitGatewayOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayOwnerId = unmarshaller.Unmarshall(context);
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

        private static TransitGatewayNetworkFunctionAttachmentUnmarshaller _instance = new TransitGatewayNetworkFunctionAttachmentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TransitGatewayNetworkFunctionAttachmentUnmarshaller Instance => _instance;
    }
}
