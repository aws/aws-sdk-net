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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails Object
    /// </summary>  
    public class AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetailsUnmarshaller : IUnmarshaller<AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails IUnmarshaller<AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails unmarshalledObject = new AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchLogsLogGroup", targetDepth))
                {
                    var unmarshaller = AwsStepFunctionStateMachineLoggingConfigurationDestinationsCloudWatchLogsLogGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLogsLogGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetailsUnmarshaller _instance = new AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}