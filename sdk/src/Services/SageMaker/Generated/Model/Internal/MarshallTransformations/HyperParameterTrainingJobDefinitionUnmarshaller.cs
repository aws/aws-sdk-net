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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HyperParameterTrainingJobDefinition Object
    /// </summary>  
    public class HyperParameterTrainingJobDefinitionUnmarshaller : IUnmarshaller<HyperParameterTrainingJobDefinition, XmlUnmarshallerContext>, IUnmarshaller<HyperParameterTrainingJobDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HyperParameterTrainingJobDefinition IUnmarshaller<HyperParameterTrainingJobDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HyperParameterTrainingJobDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HyperParameterTrainingJobDefinition unmarshalledObject = new HyperParameterTrainingJobDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlgorithmSpecification", targetDepth))
                {
                    var unmarshaller = HyperParameterAlgorithmSpecificationUnmarshaller.Instance;
                    unmarshalledObject.AlgorithmSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CheckpointConfig", targetDepth))
                {
                    var unmarshaller = CheckpointConfigUnmarshaller.Instance;
                    unmarshalledObject.CheckpointConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefinitionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableInterContainerTrafficEncryption", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableInterContainerTrafficEncryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableManagedSpotTraining", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableManagedSpotTraining = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableNetworkIsolation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableNetworkIsolation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterRanges", targetDepth))
                {
                    var unmarshaller = ParameterRangesUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningResourceConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningResourceConfigUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningResourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputDataConfig", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Channel, ChannelUnmarshaller>(ChannelUnmarshaller.Instance);
                    unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputDataConfig", targetDepth))
                {
                    var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceConfig", targetDepth))
                {
                    var unmarshaller = ResourceConfigUnmarshaller.Instance;
                    unmarshalledObject.ResourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryStrategy", targetDepth))
                {
                    var unmarshaller = RetryStrategyUnmarshaller.Instance;
                    unmarshalledObject.RetryStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StaticHyperParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StaticHyperParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = StoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TuningObjective", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobObjectiveUnmarshaller.Instance;
                    unmarshalledObject.TuningObjective = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HyperParameterTrainingJobDefinitionUnmarshaller _instance = new HyperParameterTrainingJobDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HyperParameterTrainingJobDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}