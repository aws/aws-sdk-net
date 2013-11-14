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
     ///   EventInfoMap Unmarshaller
     /// </summary>
    internal class EventInfoMapUnmarshaller : IUnmarshaller<EventInfoMap, XmlUnmarshallerContext>, IUnmarshaller<EventInfoMap, JsonUnmarshallerContext> 
    {
        public EventInfoMap Unmarshall(XmlUnmarshallerContext context) 
        {
            EventInfoMap eventInfoMap = new EventInfoMap();
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
                    if (context.TestExpression("EventId", targetDepth))
                    {
                        eventInfoMap.EventId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EventCategories/EventCategory", targetDepth))
                    {
                        eventInfoMap.EventCategories.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("EventDescription", targetDepth))
                    {
                        eventInfoMap.EventDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Severity", targetDepth))
                    {
                        eventInfoMap.Severity = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return eventInfoMap;
                }
            }
                        


            return eventInfoMap;
        }

        public EventInfoMap Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EventInfoMapUnmarshaller instance;

        public static EventInfoMapUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EventInfoMapUnmarshaller();

            return instance;
        }
    }
}
    
