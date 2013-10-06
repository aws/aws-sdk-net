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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   OrderableDBInstanceOption Unmarshaller
     /// </summary>
    internal class OrderableDBInstanceOptionUnmarshaller : IUnmarshaller<OrderableDBInstanceOption, XmlUnmarshallerContext>, IUnmarshaller<OrderableDBInstanceOption, JsonUnmarshallerContext> 
    {
        public OrderableDBInstanceOption Unmarshall(XmlUnmarshallerContext context) 
        {
            OrderableDBInstanceOption orderableDBInstanceOption = new OrderableDBInstanceOption();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        orderableDBInstanceOption.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        orderableDBInstanceOption.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        orderableDBInstanceOption.DBInstanceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LicenseModel", targetDepth))
                    {
                        orderableDBInstanceOption.LicenseModel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AvailabilityZones/AvailabilityZone", targetDepth))
                    {
                        orderableDBInstanceOption.AvailabilityZones.Add(AvailabilityZoneUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("MultiAZCapable", targetDepth))
                    {
                        orderableDBInstanceOption.MultiAZCapable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReadReplicaCapable", targetDepth))
                    {
                        orderableDBInstanceOption.ReadReplicaCapable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Vpc", targetDepth))
                    {
                        orderableDBInstanceOption.Vpc = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return orderableDBInstanceOption;
                }
            }
                        


            return orderableDBInstanceOption;
        }

        public OrderableDBInstanceOption Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OrderableDBInstanceOptionUnmarshaller instance;

        public static OrderableDBInstanceOptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OrderableDBInstanceOptionUnmarshaller();

            return instance;
        }
    }
}
    
