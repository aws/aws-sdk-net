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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NotificationConfiguration Object
    /// </summary>  
    public class NotificationConfigurationUnmarshaller : IXmlUnmarshaller<NotificationConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NotificationConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            NotificationConfiguration unmarshalledObject = new NotificationConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EventBridgeConfiguration", targetDepth))
                    {
                        var unmarshaller = EventBridgeConfigurationUnmarshaller.Instance;
                        unmarshalledObject.EventBridgeConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CloudFunctionConfiguration/member", targetDepth))
                    {
                        if (unmarshalledObject.LambdaFunctionConfigurations == null)
                        {
                            unmarshalledObject.LambdaFunctionConfigurations = new List<LambdaFunctionConfiguration>();
                        }
                        var unmarshaller = LambdaFunctionConfigurationUnmarshaller.Instance;
                        unmarshalledObject.LambdaFunctionConfigurations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("QueueConfiguration/member", targetDepth))
                    {
                        if (unmarshalledObject.QueueConfigurations == null)
                        {
                            unmarshalledObject.QueueConfigurations = new List<QueueConfiguration>();
                        }
                        var unmarshaller = QueueConfigurationUnmarshaller.Instance;
                        unmarshalledObject.QueueConfigurations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("TopicConfiguration/member", targetDepth))
                    {
                        if (unmarshalledObject.TopicConfigurations == null)
                        {
                            unmarshalledObject.TopicConfigurations = new List<TopicConfiguration>();
                        }
                        var unmarshaller = TopicConfigurationUnmarshaller.Instance;
                        unmarshalledObject.TopicConfigurations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }
        private static NotificationConfigurationUnmarshaller _instance = new NotificationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotificationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}