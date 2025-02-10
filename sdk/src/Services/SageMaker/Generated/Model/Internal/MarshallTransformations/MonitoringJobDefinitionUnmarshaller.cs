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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MonitoringJobDefinition Object
    /// </summary>  
    public class MonitoringJobDefinitionUnmarshaller : IJsonUnmarshaller<MonitoringJobDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MonitoringJobDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MonitoringJobDefinition unmarshalledObject = new MonitoringJobDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BaselineConfig", targetDepth))
                {
                    var unmarshaller = MonitoringBaselineConfigUnmarshaller.Instance;
                    unmarshalledObject.BaselineConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonitoringAppSpecification", targetDepth))
                {
                    var unmarshaller = MonitoringAppSpecificationUnmarshaller.Instance;
                    unmarshalledObject.MonitoringAppSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonitoringInputs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MonitoringInput, MonitoringInputUnmarshaller>(MonitoringInputUnmarshaller.Instance);
                    unmarshalledObject.MonitoringInputs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonitoringOutputConfig", targetDepth))
                {
                    var unmarshaller = MonitoringOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.MonitoringOutputConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonitoringResources", targetDepth))
                {
                    var unmarshaller = MonitoringResourcesUnmarshaller.Instance;
                    unmarshalledObject.MonitoringResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkConfig", targetDepth))
                {
                    var unmarshaller = NetworkConfigUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = MonitoringStoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MonitoringJobDefinitionUnmarshaller _instance = new MonitoringJobDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MonitoringJobDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}