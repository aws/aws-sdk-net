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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MaintenanceWindowTask Object
    /// </summary>  
    public class MaintenanceWindowTaskUnmarshaller : IJsonUnmarshaller<MaintenanceWindowTask, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MaintenanceWindowTask Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MaintenanceWindowTask unmarshalledObject = new MaintenanceWindowTask();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlarmConfiguration", targetDepth))
                {
                    var unmarshaller = AlarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CutoffBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CutoffBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoggingInfo", targetDepth))
                {
                    var unmarshaller = LoggingInfoUnmarshaller.Instance;
                    unmarshalledObject.LoggingInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxErrors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskParameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, MaintenanceWindowTaskParameterValueExpression, StringUnmarshaller, MaintenanceWindowTaskParameterValueExpressionUnmarshaller>(StringUnmarshaller.Instance, MaintenanceWindowTaskParameterValueExpressionUnmarshaller.Instance);
                    unmarshalledObject.TaskParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WindowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WindowId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WindowTaskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WindowTaskId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MaintenanceWindowTaskUnmarshaller _instance = new MaintenanceWindowTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MaintenanceWindowTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}