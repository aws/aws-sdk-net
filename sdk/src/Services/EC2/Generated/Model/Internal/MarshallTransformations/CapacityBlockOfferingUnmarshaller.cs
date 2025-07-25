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
    /// Response Unmarshaller for CapacityBlockOffering Object
    /// </summary>  
    public class CapacityBlockOfferingUnmarshaller : IXmlUnmarshaller<CapacityBlockOffering, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CapacityBlockOffering Unmarshall(XmlUnmarshallerContext context)
        {
            CapacityBlockOffering unmarshalledObject = new CapacityBlockOffering();
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
                    if (context.TestExpression("capacityBlockDurationHours", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockDurationHours = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockDurationMinutes", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockDurationMinutes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityBlockOfferingId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CapacityBlockOfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("endDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.EndDate = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("startDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Tenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ultraserverCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.UltraserverCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ultraserverType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UltraserverType = unmarshaller.Unmarshall(context);
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

        private static CapacityBlockOfferingUnmarshaller _instance = new CapacityBlockOfferingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CapacityBlockOfferingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}