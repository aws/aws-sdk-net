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
    /// Response Unmarshaller for CapacityBlockExtension Object
    /// </summary>  
    public class CapacityBlockExtensionUnmarshaller : IXmlUnmarshaller<CapacityBlockExtension, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CapacityBlockExtension Unmarshall(XmlUnmarshallerContext context)
        {
            CapacityBlockExtension unmarshalledObject = new CapacityBlockExtension();
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
                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionDurationHours", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionDurationHours = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionEndDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionEndDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionOfferingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionOfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionPurchaseDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionPurchaseDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionStartDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionStartDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockExtensionStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockExtensionStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityReservationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CapacityReservationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.InstanceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("upfrontFee", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UpfrontFee = unmarshaller.Unmarshall(context);
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

        private static CapacityBlockExtensionUnmarshaller _instance = new CapacityBlockExtensionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CapacityBlockExtensionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}