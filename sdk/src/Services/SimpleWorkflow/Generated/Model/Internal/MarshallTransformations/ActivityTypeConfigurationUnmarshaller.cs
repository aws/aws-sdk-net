/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActivityTypeConfiguration Object
    /// </summary>  
    public class ActivityTypeConfigurationUnmarshaller : IUnmarshaller<ActivityTypeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ActivityTypeConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActivityTypeConfiguration IUnmarshaller<ActivityTypeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActivityTypeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActivityTypeConfiguration unmarshalledObject = new ActivityTypeConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("defaultTaskHeartbeatTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskHeartbeatTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskList", targetDepth))
                {
                    var unmarshaller = TaskListUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskPriority", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskPriority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskScheduleToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskScheduleToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskScheduleToStartTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskScheduleToStartTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskStartToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskStartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActivityTypeConfigurationUnmarshaller _instance = new ActivityTypeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivityTypeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}