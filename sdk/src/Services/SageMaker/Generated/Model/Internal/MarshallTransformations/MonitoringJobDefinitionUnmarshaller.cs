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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MonitoringJobDefinition Object
    /// </summary>  
    public class MonitoringJobDefinitionUnmarshaller : IUnmarshaller<MonitoringJobDefinition, XmlUnmarshallerContext>, IUnmarshaller<MonitoringJobDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MonitoringJobDefinition IUnmarshaller<MonitoringJobDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MonitoringJobDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MonitoringJobDefinition unmarshalledObject = new MonitoringJobDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BaselineConfig", targetDepth))
                {
                    var unmarshaller = MonitoringBaselineConfigUnmarshaller.Instance;
                    unmarshalledObject.BaselineConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringAppSpecification", targetDepth))
                {
                    var unmarshaller = MonitoringAppSpecificationUnmarshaller.Instance;
                    unmarshalledObject.MonitoringAppSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringInputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MonitoringInput, MonitoringInputUnmarshaller>(MonitoringInputUnmarshaller.Instance);
                    unmarshalledObject.MonitoringInputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringOutputConfig", targetDepth))
                {
                    var unmarshaller = MonitoringOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.MonitoringOutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringResources", targetDepth))
                {
                    var unmarshaller = MonitoringResourcesUnmarshaller.Instance;
                    unmarshalledObject.MonitoringResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkConfig", targetDepth))
                {
                    var unmarshaller = NetworkConfigUnmarshaller.Instance;
                    unmarshalledObject.NetworkConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = MonitoringStoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context);
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