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

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Subscription Unmarshaller
     /// </summary>
    internal class SubscriptionUnmarshaller : IUnmarshaller<Subscription, XmlUnmarshallerContext>, IUnmarshaller<Subscription, JsonUnmarshallerContext> 
    {
        public Subscription Unmarshall(XmlUnmarshallerContext context) 
        {
            Subscription subscription = new Subscription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SubscriptionArn", targetDepth))
                    {
                        subscription.SubscriptionArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        subscription.Owner = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Protocol", targetDepth))
                    {
                        subscription.Protocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        subscription.Endpoint = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("TopicArn", targetDepth))
                    {
                        subscription.TopicArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return subscription;
                }
            }
                        


            return subscription;
        }

        public Subscription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SubscriptionUnmarshaller instance;

        public static SubscriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SubscriptionUnmarshaller();

            return instance;
        }
    }
}
    
