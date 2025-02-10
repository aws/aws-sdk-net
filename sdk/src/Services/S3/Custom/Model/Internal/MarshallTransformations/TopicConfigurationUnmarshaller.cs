/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   TopicConfiguration Unmarshaller
     /// </summary>
    public class TopicConfigurationUnmarshaller : IXmlUnmarshaller<TopicConfiguration, XmlUnmarshallerContext>, IXmlUnmarshaller<TopicConfiguration, JsonUnmarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public TopicConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            TopicConfiguration topicConfiguration = new TopicConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        topicConfiguration.Id = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Event", targetDepth))
                    {
                        if (topicConfiguration.Events == null)
                        {
                            topicConfiguration.Events = new List<EventType>();
                        }

                        topicConfiguration.Events.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Topic", targetDepth))
                    {
                        topicConfiguration.Topic = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        topicConfiguration.Filter = FilterUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return topicConfiguration;
                }
            }
                        


            return topicConfiguration;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public TopicConfiguration Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static TopicConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static TopicConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TopicConfigurationUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
