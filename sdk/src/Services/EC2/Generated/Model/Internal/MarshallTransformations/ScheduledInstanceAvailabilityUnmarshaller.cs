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
    /// Response Unmarshaller for ScheduledInstanceAvailability Object
    /// </summary>  
    public class ScheduledInstanceAvailabilityUnmarshaller : IXmlUnmarshaller<ScheduledInstanceAvailability, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScheduledInstanceAvailability Unmarshall(XmlUnmarshallerContext context)
        {
            ScheduledInstanceAvailability unmarshalledObject = new ScheduledInstanceAvailability();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availableInstanceCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AvailableInstanceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("firstSlotStartTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.FirstSlotStartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hourlyPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HourlyPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxTermDurationInDays", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxTermDurationInDays = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("minTermDurationInDays", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinTermDurationInDays = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkPlatform", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkPlatform = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("purchaseToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PurchaseToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("recurrence", targetDepth))
                    {
                        var unmarshaller = ScheduledInstanceRecurrenceUnmarshaller.Instance;
                        unmarshalledObject.Recurrence = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("slotDurationInHours", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SlotDurationInHours = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("totalScheduledInstanceHours", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.TotalScheduledInstanceHours = unmarshaller.Unmarshall(context);
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

        private static ScheduledInstanceAvailabilityUnmarshaller _instance = new ScheduledInstanceAvailabilityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduledInstanceAvailabilityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}