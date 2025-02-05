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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DecisionTaskScheduledEventAttributes Object
    /// </summary>  
    public class DecisionTaskScheduledEventAttributesUnmarshaller : IJsonUnmarshaller<DecisionTaskScheduledEventAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DecisionTaskScheduledEventAttributes Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DecisionTaskScheduledEventAttributes unmarshalledObject = new DecisionTaskScheduledEventAttributes();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("scheduleToStartTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleToStartTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartToCloseTimeout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskList", targetDepth))
                {
                    var unmarshaller = TaskListUnmarshaller.Instance;
                    unmarshalledObject.TaskList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskPriority", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskPriority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DecisionTaskScheduledEventAttributesUnmarshaller _instance = new DecisionTaskScheduledEventAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DecisionTaskScheduledEventAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}