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
    /// Response Unmarshaller for InstanceStatus Object
    /// </summary>  
    public class InstanceStatusUnmarshaller : IXmlUnmarshaller<InstanceStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceStatus Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceStatus unmarshalledObject = new InstanceStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("attachedEbsStatus", targetDepth))
                    {
                        var unmarshaller = EbsStatusSummaryUnmarshaller.Instance;
                        unmarshalledObject.AttachedEbsStatus = unmarshaller.Unmarshall(context);
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
                        var unmarshaller = InstanceStatusEventUnmarshaller.Instance;
                        if (unmarshalledObject.Events == null)
                        {
                            unmarshalledObject.Events = new List<InstanceStatusEvent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Events.Add(item);
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceState", targetDepth))
                    {
                        var unmarshaller = InstanceStateUnmarshaller.Instance;
                        unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceStatus", targetDepth))
                    {
                        var unmarshaller = InstanceStatusSummaryUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("systemStatus", targetDepth))
                    {
                        var unmarshaller = InstanceStatusSummaryUnmarshaller.Instance;
                        unmarshalledObject.SystemStatus = unmarshaller.Unmarshall(context);
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

        private static InstanceStatusUnmarshaller _instance = new InstanceStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}