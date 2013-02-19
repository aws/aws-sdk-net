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
     ///   EventSubscription Unmarshaller
     /// </summary>
    internal class EventSubscriptionUnmarshaller : IUnmarshaller<EventSubscription, XmlUnmarshallerContext>, IUnmarshaller<EventSubscription, JsonUnmarshallerContext> 
    {
        public EventSubscription Unmarshall(XmlUnmarshallerContext context) 
        {
            EventSubscription eventSubscription = new EventSubscription();
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
                    if (context.TestExpression("Id", targetDepth))
                    {
                        eventSubscription.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CustomerAwsId", targetDepth))
                    {
                        eventSubscription.CustomerAwsId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CustSubscriptionId", targetDepth))
                    {
                        eventSubscription.CustSubscriptionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SnsTopicArn", targetDepth))
                    {
                        eventSubscription.SnsTopicArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        eventSubscription.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SubscriptionCreationTime", targetDepth))
                    {
                        eventSubscription.SubscriptionCreationTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceType", targetDepth))
                    {
                        eventSubscription.SourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceIdsList/SourceId", targetDepth))
                    {
                        eventSubscription.SourceIdsList.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("EventCategoriesList/EventCategory", targetDepth))
                    {
                        eventSubscription.EventCategoriesList.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        eventSubscription.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return eventSubscription;
                }
            }
                        


            return eventSubscription;
        }

        public EventSubscription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EventSubscriptionUnmarshaller instance;

        public static EventSubscriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EventSubscriptionUnmarshaller();

            return instance;
        }
    }
}
    
