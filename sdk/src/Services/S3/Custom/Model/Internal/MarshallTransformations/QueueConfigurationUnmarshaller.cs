﻿/*
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

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueueConfiguration unmarshaller
    /// </summary>
    public class QueueConfigurationUnmarshaller : IXmlUnmarshaller<QueueConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public QueueConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            QueueConfiguration queueConfiguration = new QueueConfiguration();
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
                        queueConfiguration.Id = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Event", targetDepth))
                    {
                        if (queueConfiguration.Events == null)
                        {
                            queueConfiguration.Events = new List<EventType>();
                        }

                        queueConfiguration.Events.Add(StringUnmarshaller.GetInstance().Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("Queue", targetDepth))
                    {
                        queueConfiguration.Queue = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        queueConfiguration.Filter = FilterUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return queueConfiguration;
                }
            }

            return queueConfiguration;
        }

        private static QueueConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static QueueConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QueueConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
