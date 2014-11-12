/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Response Unmarshaller for ReservedInstances Object
    /// </summary>  
    public class ReservedInstancesUnmarshaller : IUnmarshaller<ReservedInstances, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstances, JsonUnmarshallerContext>
    {
        public ReservedInstances Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedInstances unmarshalledObject = new ReservedInstances();
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
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("duration", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("end", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.End = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fixedPrice", targetDepth))
                    {
                        var unmarshaller = FloatUnmarshaller.Instance;
                        unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.InstanceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceTenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("offeringType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OfferingType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("productDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProductDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("recurringCharges/item", targetDepth))
                    {
                        var unmarshaller = RecurringChargeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RecurringCharges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedInstancesId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("start", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.Start = unmarshaller.Unmarshall(context);
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
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("usagePrice", targetDepth))
                    {
                        var unmarshaller = FloatUnmarshaller.Instance;
                        unmarshalledObject.UsagePrice = unmarshaller.Unmarshall(context);
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

        public ReservedInstances Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ReservedInstancesUnmarshaller _instance = new ReservedInstancesUnmarshaller();        

        public static ReservedInstancesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}