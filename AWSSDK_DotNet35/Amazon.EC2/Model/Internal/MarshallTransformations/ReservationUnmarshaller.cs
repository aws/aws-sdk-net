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
     ///   Reservation Unmarshaller
     /// </summary>
    internal class ReservationUnmarshaller : IUnmarshaller<Reservation, XmlUnmarshallerContext>, IUnmarshaller<Reservation, JsonUnmarshallerContext> 
    {
        public Reservation Unmarshall(XmlUnmarshallerContext context) 
        {
            Reservation reservation = new Reservation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("reservationId", targetDepth))
                    {
                        reservation.ReservationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        reservation.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("requesterId", targetDepth))
                    {
                        reservation.RequesterId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        reservation.Groups.Add(GroupIdentifierUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item/groupName", targetDepth))
                    {
                        reservation.GroupNames.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instancesSet/item", targetDepth))
                    {
                        reservation.Instances.Add(InstanceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return reservation;
                }
            }
                        


            return reservation;
        }

        public Reservation Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReservationUnmarshaller instance;

        public static ReservationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReservationUnmarshaller();

            return instance;
        }
    }
}
    
