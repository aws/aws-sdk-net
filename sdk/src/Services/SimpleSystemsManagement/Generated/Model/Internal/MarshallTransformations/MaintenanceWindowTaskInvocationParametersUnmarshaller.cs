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
    /// Response Unmarshaller for MaintenanceWindowTaskInvocationParameters Object
    /// </summary>  
    public class MaintenanceWindowTaskInvocationParametersUnmarshaller : IJsonUnmarshaller<MaintenanceWindowTaskInvocationParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MaintenanceWindowTaskInvocationParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MaintenanceWindowTaskInvocationParameters unmarshalledObject = new MaintenanceWindowTaskInvocationParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Automation", targetDepth))
                {
                    var unmarshaller = MaintenanceWindowAutomationParametersUnmarshaller.Instance;
                    unmarshalledObject.Automation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Lambda", targetDepth))
                {
                    var unmarshaller = MaintenanceWindowLambdaParametersUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RunCommand", targetDepth))
                {
                    var unmarshaller = MaintenanceWindowRunCommandParametersUnmarshaller.Instance;
                    unmarshalledObject.RunCommand = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StepFunctions", targetDepth))
                {
                    var unmarshaller = MaintenanceWindowStepFunctionsParametersUnmarshaller.Instance;
                    unmarshalledObject.StepFunctions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MaintenanceWindowTaskInvocationParametersUnmarshaller _instance = new MaintenanceWindowTaskInvocationParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MaintenanceWindowTaskInvocationParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}