/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ReservedInstances Unmarshaller
     /// </summary>
    internal class ReservedInstancesUnmarshaller : IUnmarshaller<ReservedInstances, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstances, JsonUnmarshallerContext> 
    {
        public ReservedInstances Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedInstances reservedInstances = new ReservedInstances();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("reservedInstancesId", targetDepth))
                    {
                        reservedInstances.ReservedInstancesId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        reservedInstances.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        reservedInstances.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("start", targetDepth))
                    {
                        reservedInstances.Start = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("end", targetDepth))
                    {
                        reservedInstances.End = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("duration", targetDepth))
                    {
                        reservedInstances.Duration = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("usagePrice", targetDepth))
                    {
                        reservedInstances.UsagePrice = FloatUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("fixedPrice", targetDepth))
                    {
                        reservedInstances.FixedPrice = FloatUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceCount", targetDepth))
                    {
                        reservedInstances.InstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("productDescription", targetDepth))
                    {
                        reservedInstances.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        reservedInstances.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        reservedInstances.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        reservedInstances.InstanceTenancy = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        reservedInstances.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("offeringType", targetDepth))
                    {
                        reservedInstances.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("recurringCharges/item", targetDepth))
                    {
                        reservedInstances.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedInstances;
                }
            }
                        


            return reservedInstances;
        }

        public ReservedInstances Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedInstancesUnmarshaller instance;

        public static ReservedInstancesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedInstancesUnmarshaller();

            return instance;
        }
    }
}
    
