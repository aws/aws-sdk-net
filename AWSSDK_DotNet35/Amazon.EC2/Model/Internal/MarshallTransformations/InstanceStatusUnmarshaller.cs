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
     ///   InstanceStatus Unmarshaller
     /// </summary>
    internal class InstanceStatusUnmarshaller : IUnmarshaller<InstanceStatus, XmlUnmarshallerContext>, IUnmarshaller<InstanceStatus, JsonUnmarshallerContext> 
    {
        public InstanceStatus Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceStatus instanceStatus = new InstanceStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        instanceStatus.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        instanceStatus.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("eventsSet/item", targetDepth))
                    {
                        instanceStatus.Events.Add(InstanceStatusEventUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instanceState", targetDepth))
                    {
                        instanceStatus.InstanceState = InstanceStateUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("systemStatus", targetDepth))
                    {
                        instanceStatus.SystemStatus = InstanceStatusSummaryUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceStatus", targetDepth))
                    {
                        instanceStatus.Status = InstanceStatusSummaryUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceStatus;
                }
            }
                        


            return instanceStatus;
        }

        public InstanceStatus Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceStatusUnmarshaller instance;

        public static InstanceStatusUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceStatusUnmarshaller();

            return instance;
        }
    }
}
    
