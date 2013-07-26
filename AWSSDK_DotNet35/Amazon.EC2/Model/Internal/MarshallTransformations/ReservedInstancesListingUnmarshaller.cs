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
     ///   ReservedInstancesListing Unmarshaller
     /// </summary>
    internal class ReservedInstancesListingUnmarshaller : IUnmarshaller<ReservedInstancesListing, XmlUnmarshallerContext>, IUnmarshaller<ReservedInstancesListing, JsonUnmarshallerContext> 
    {
        public ReservedInstancesListing Unmarshall(XmlUnmarshallerContext context) 
        {
            ReservedInstancesListing reservedInstancesListing = new ReservedInstancesListing();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("reservedInstancesListingId", targetDepth))
                    {
                        reservedInstancesListing.ReservedInstancesListingId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesId", targetDepth))
                    {
                        reservedInstancesListing.ReservedInstancesId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("createDate", targetDepth))
                    {
                        reservedInstancesListing.CreateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("updateDate", targetDepth))
                    {
                        reservedInstancesListing.UpdateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        reservedInstancesListing.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        reservedInstancesListing.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceCounts/item", targetDepth))
                    {
                        reservedInstancesListing.InstanceCounts.Add(InstanceCountUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("priceSchedules/item", targetDepth))
                    {
                        reservedInstancesListing.PriceSchedules.Add(PriceScheduleUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        reservedInstancesListing.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        reservedInstancesListing.ClientToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservedInstancesListing;
                }
            }
                        


            return reservedInstancesListing;
        }

        public ReservedInstancesListing Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservedInstancesListingUnmarshaller instance;

        public static ReservedInstancesListingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservedInstancesListingUnmarshaller();

            return instance;
        }
    }
}
    
