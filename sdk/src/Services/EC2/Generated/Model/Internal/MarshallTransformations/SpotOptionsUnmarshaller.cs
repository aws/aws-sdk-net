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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SpotOptions Object
    /// </summary>  
    public class SpotOptionsUnmarshaller : IUnmarshaller<SpotOptions, XmlUnmarshallerContext>, IUnmarshaller<SpotOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SpotOptions Unmarshall(XmlUnmarshallerContext context)
        {
            SpotOptions unmarshalledObject = new SpotOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("allocationStrategy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllocationStrategy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceInterruptionBehavior", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceInterruptionBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instancePoolsToUseCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.InstancePoolsToUseCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maintenanceStrategies", targetDepth))
                    {
                        var unmarshaller = FleetSpotMaintenanceStrategiesUnmarshaller.Instance;
                        unmarshalledObject.MaintenanceStrategies = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxTotalPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MaxTotalPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("minTargetCapacity", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MinTargetCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("singleAvailabilityZone", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.SingleAvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("singleInstanceType", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.SingleInstanceType = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SpotOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SpotOptionsUnmarshaller _instance = new SpotOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SpotOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}