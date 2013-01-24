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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EventDescription Unmarshaller
     /// </summary>
    internal class EventDescriptionUnmarshaller : IUnmarshaller<EventDescription, XmlUnmarshallerContext> 
    {
        public EventDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            EventDescription eventDescription = new EventDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("EventDate", targetDepth))
                    {
                        eventDescription.EventDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Message", targetDepth))
                    {
                        eventDescription.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        eventDescription.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        eventDescription.VersionLabel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        eventDescription.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        eventDescription.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("RequestId", targetDepth))
                    {
                        eventDescription.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Severity", targetDepth))
                    {
                        eventDescription.Severity = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return eventDescription;
                }
            }
                        


            return eventDescription;
        }

        private static EventDescriptionUnmarshaller instance;

        public static EventDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EventDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
