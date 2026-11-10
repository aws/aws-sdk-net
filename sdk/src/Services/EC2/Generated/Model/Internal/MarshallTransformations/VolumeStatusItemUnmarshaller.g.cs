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
    /// Response Unmarshaller for VolumeStatusItem Object
    /// </summary>
    public partial class VolumeStatusItemUnmarshaller : IXmlUnmarshaller<VolumeStatusItem, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public VolumeStatusItem Unmarshall(XmlUnmarshallerContext context)
        {
            VolumeStatusItem unmarshalledObject = new VolumeStatusItem();
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
                    if (context.TestExpression("actionsSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Actions == null)
                        {
                            unmarshalledObject.Actions = new List<VolumeStatusAction>();
                        }
                        var unmarshaller = VolumeStatusActionUnmarshaller.Instance;
                        unmarshalledObject.Actions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("attachmentStatuses/item", targetDepth))
                    {
                        if (unmarshalledObject.AttachmentStatuses == null)
                        {
                            unmarshalledObject.AttachmentStatuses = new List<VolumeStatusAttachmentStatus>();
                        }
                        var unmarshaller = VolumeStatusAttachmentStatusUnmarshaller.Instance;
                        unmarshalledObject.AttachmentStatuses.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("eventsSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Events == null)
                        {
                            unmarshalledObject.Events = new List<VolumeStatusEvent>();
                        }
                        var unmarshaller = VolumeStatusEventUnmarshaller.Instance;
                        unmarshalledObject.Events.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("initializationStatusDetails", targetDepth))
                    {
                        var unmarshaller = InitializationStatusDetailsUnmarshaller.Instance;
                        unmarshalledObject.InitializationStatusDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("operator", targetDepth))
                    {
                        var unmarshaller = OperatorResponseUnmarshaller.Instance;
                        unmarshalledObject.Operator = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("outpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("volumeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VolumeId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("volumeStatus", targetDepth))
                    {
                        var unmarshaller = VolumeStatusInfoUnmarshaller.Instance;
                        unmarshalledObject.VolumeStatus = unmarshaller.Unmarshall(context);
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

        private static VolumeStatusItemUnmarshaller _instance = new VolumeStatusItemUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VolumeStatusItemUnmarshaller Instance => _instance;
    }
}
