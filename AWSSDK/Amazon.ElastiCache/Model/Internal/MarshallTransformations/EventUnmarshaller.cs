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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Event Unmarshaller
     /// </summary>
    internal class EventUnmarshaller : IUnmarshaller<Event, XmlUnmarshallerContext>, IUnmarshaller<Event, JsonUnmarshallerContext> 
    {
        public Event Unmarshall(XmlUnmarshallerContext context) 
        {
            Event eventValue = new Event();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SourceIdentifier", targetDepth))
                    {
                        eventValue.SourceIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceType", targetDepth))
                    {
                        eventValue.SourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Message", targetDepth))
                    {
                        eventValue.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Date", targetDepth))
                    {
                        eventValue.Date = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return eventValue;
                }
            }
                        


            return eventValue;
        }

        public Event Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EventUnmarshaller instance;

        public static EventUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EventUnmarshaller();

            return instance;
        }
    }
}
    
