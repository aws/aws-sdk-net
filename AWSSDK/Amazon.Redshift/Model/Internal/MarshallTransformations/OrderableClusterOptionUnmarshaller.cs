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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   OrderableClusterOption Unmarshaller
     /// </summary>
    internal class OrderableClusterOptionUnmarshaller : IUnmarshaller<OrderableClusterOption, XmlUnmarshallerContext>, IUnmarshaller<OrderableClusterOption, JsonUnmarshallerContext> 
    {
        public OrderableClusterOption Unmarshall(XmlUnmarshallerContext context) 
        {
            OrderableClusterOption orderableClusterOption = new OrderableClusterOption();
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
                    if (context.TestExpression("ClusterVersion", targetDepth))
                    {
                        orderableClusterOption.ClusterVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterType", targetDepth))
                    {
                        orderableClusterOption.ClusterType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NodeType", targetDepth))
                    {
                        orderableClusterOption.NodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AvailabilityZones/AvailabilityZone", targetDepth))
                    {
                        orderableClusterOption.AvailabilityZones.Add(AvailabilityZoneUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return orderableClusterOption;
                }
            }
                        


            return orderableClusterOption;
        }

        public OrderableClusterOption Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OrderableClusterOptionUnmarshaller instance;

        public static OrderableClusterOptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OrderableClusterOptionUnmarshaller();

            return instance;
        }
    }
}
    
