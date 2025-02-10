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
    /// Response Unmarshaller for HyperParameterTrainingJobDefinition Object
    /// </summary>  
    public class HyperParameterTrainingJobDefinitionUnmarshaller : IJsonUnmarshaller<HyperParameterTrainingJobDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HyperParameterTrainingJobDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HyperParameterTrainingJobDefinition unmarshalledObject = new HyperParameterTrainingJobDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlgorithmSpecification", targetDepth))
                {
                    var unmarshaller = HyperParameterAlgorithmSpecificationUnmarshaller.Instance;
                    unmarshalledObject.AlgorithmSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CheckpointConfig", targetDepth))
                {
                    var unmarshaller = CheckpointConfigUnmarshaller.Instance;
                    unmarshalledObject.CheckpointConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefinitionName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnableInterContainerTrafficEncryption", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableInterContainerTrafficEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnableManagedSpotTraining", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableManagedSpotTraining = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnableNetworkIsolation", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableNetworkIsolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterRanges", targetDepth))
                {
                    var unmarshaller = ParameterRangesUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterRanges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningResourceConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningResourceConfigUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningResourceConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputDataConfig", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Channel, ChannelUnmarshaller>(ChannelUnmarshaller.Instance);
                    unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputDataConfig", targetDepth))
                {
                    var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceConfig", targetDepth))
                {
                    var unmarshaller = ResourceConfigUnmarshaller.Instance;
                    unmarshalledObject.ResourceConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetryStrategy", targetDepth))
                {
                    var unmarshaller = RetryStrategyUnmarshaller.Instance;
                    unmarshalledObject.RetryStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StaticHyperParameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StaticHyperParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = StoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TuningObjective", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobObjectiveUnmarshaller.Instance;
                    unmarshalledObject.TuningObjective = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context, ref reader);
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