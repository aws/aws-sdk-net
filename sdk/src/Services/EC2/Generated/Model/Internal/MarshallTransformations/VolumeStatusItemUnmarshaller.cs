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
    /// Response Unmarshaller for VolumeStatusItem Object
    /// </summary>  
    public class VolumeStatusItemUnmarshaller : IXmlUnmarshaller<VolumeStatusItem, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VolumeStatusItem Unmarshall(XmlUnmarshallerContext context)
        {
            VolumeStatusItem unmarshalledObject = new VolumeStatusItem();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("actionsSet/item", targetDepth))
                    {
                        var unmarshaller = VolumeStatusActionUnmarshaller.Instance;
                        if (unmarshalledObject.Actions == null)
                        {
                            unmarshalledObject.Actions = new List<VolumeStatusAction>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Actions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("attachmentStatuses/item", targetDepth))
                    {
                        var unmarshaller = VolumeStatusAttachmentStatusUnmarshaller.Instance;
                        if (unmarshalledObject.AttachmentStatuses == null)
                        {
                            unmarshalledObject.AttachmentStatuses = new List<VolumeStatusAttachmentStatus>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AttachmentStatuses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("eventsSet/item", targetDepth))
                    {
                        var unmarshaller = VolumeStatusEventUnmarshaller.Instance;
                        if (unmarshalledObject.Events == null)
                        {
                            unmarshalledObject.Events = new List<VolumeStatusEvent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Events.Add(item);
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
        public static VolumeStatusItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}