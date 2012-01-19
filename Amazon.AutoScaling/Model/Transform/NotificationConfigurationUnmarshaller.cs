/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Transform
{
     /// <summary>
     ///   NotificationConfiguration Unmarshaller
     /// </summary>
    internal class NotificationConfigurationUnmarshaller : IUnmarshaller<NotificationConfiguration, UnmarshallerContext> 
    {
        public NotificationConfiguration Unmarshall(UnmarshallerContext context) 
        {
            NotificationConfiguration notificationConfiguration = new NotificationConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        notificationConfiguration.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("TopicARN", targetDepth))
                    {
                        notificationConfiguration.TopicARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NotificationType", targetDepth))
                    {
                        notificationConfiguration.NotificationType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return notificationConfiguration;
                }
            }

            return notificationConfiguration;
        }

        private static NotificationConfigurationUnmarshaller instance;

        public static NotificationConfigurationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NotificationConfigurationUnmarshaller();

            return instance;
        }
    }
}
    
