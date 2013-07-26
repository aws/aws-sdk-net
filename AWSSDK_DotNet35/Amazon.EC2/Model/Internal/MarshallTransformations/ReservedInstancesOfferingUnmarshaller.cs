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
     ///   ReservedInstancesOffering Unmarshaller
     /// </summary>
    internal class ReservedInstancesOfferingUnmarshaller : IUnmarshaller<ReservedInstancesOffering, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstancesOffering, JsonUnmarshallerContext> 
    {
        public ReservedInstancesOffering Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedInstancesOffering reservedInstancesOffering = new ReservedInstancesOffering();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("reservedInstancesOfferingId", targetDepth))
                    {
                        reservedInstancesOffering.ReservedInstancesOfferingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        reservedInstancesOffering.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        reservedInstancesOffering.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("duration", targetDepth))
                    {
                        reservedInstancesOffering.Duration = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("usagePrice", targetDepth))
                    {
                        reservedInstancesOffering.UsagePrice = FloatUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("fixedPrice", targetDepth))
                    {
                        reservedInstancesOffering.FixedPrice = FloatUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("productDescription", targetDepth))
                    {
                        reservedInstancesOffering.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        reservedInstancesOffering.InstanceTenancy = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        reservedInstancesOffering.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("offeringType", targetDepth))
                    {
                        reservedInstancesOffering.OfferingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("recurringCharges/item", targetDepth))
                    {
                        reservedInstancesOffering.RecurringCharges.Add(RecurringChargeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("marketplace", targetDepth))
                    {
                        reservedInstancesOffering.Marketplace = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("pricingDetailsSet/item", targetDepth))
                    {
                        reservedInstancesOffering.PricingDetails.Add(PricingDetailUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedInstancesOffering;
                }
            }
                        


            return reservedInstancesOffering;
        }

        public ReservedInstancesOffering Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedInstancesOfferingUnmarshaller instance;

        public static ReservedInstancesOfferingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedInstancesOfferingUnmarshaller();

            return instance;
        }
    }
}
    
