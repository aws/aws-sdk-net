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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrainingJob Object
    /// </summary>  
    public class TrainingJobUnmarshaller : IUnmarshaller<TrainingJob, XmlUnmarshallerContext>, IUnmarshaller<TrainingJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrainingJob IUnmarshaller<TrainingJob, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TrainingJob Unmarshall(JsonUnmarshallerContext context)
        {
            TrainingJob unmarshalledObject = new TrainingJob();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlgorithmSpecification", targetDepth))
                {
                    var unmarshaller = AlgorithmSpecificationUnmarshaller.Instance;
                    unmarshalledObject.AlgorithmSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoMLJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BillableTimeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BillableTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CheckpointConfig", targetDepth))
                {
                    var unmarshaller = CheckpointConfigUnmarshaller.Instance;
                    unmarshalledObject.CheckpointConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DebugHookConfig", targetDepth))
                {
                    var unmarshaller = DebugHookConfigUnmarshaller.Instance;
                    unmarshalledObject.DebugHookConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DebugRuleConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DebugRuleConfiguration, DebugRuleConfigurationUnmarshaller>(DebugRuleConfigurationUnmarshaller.Instance);
                    unmarshalledObject.DebugRuleConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DebugRuleEvaluationStatuses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DebugRuleEvaluationStatus, DebugRuleEvaluationStatusUnmarshaller>(DebugRuleEvaluationStatusUnmarshaller.Instance);
                    unmarshalledObject.DebugRuleEvaluationStatuses = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ExperimentConfig", targetDepth))
                {
                    var unmarshaller = ExperimentConfigUnmarshaller.Instance;
                    unmarshalledObject.ExperimentConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FinalMetricDataList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricData, MetricDataUnmarshaller>(MetricDataUnmarshaller.Instance);
                    unmarshalledObject.FinalMetricDataList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.HyperParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputDataConfig", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Channel, ChannelUnmarshaller>(ChannelUnmarshaller.Instance);
                    unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelingJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelArtifacts", targetDepth))
                {
                    var unmarshaller = ModelArtifactsUnmarshaller.Instance;
                    unmarshalledObject.ModelArtifacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageConfig", targetDepth))
                {
                    var unmarshaller = ModelPackageConfigUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputDataConfig", targetDepth))
                {
                    var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputModelPackageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputModelPackageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfilerConfig", targetDepth))
                {
                    var unmarshaller = ProfilerConfigUnmarshaller.Instance;
                    unmarshalledObject.ProfilerConfig = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("SecondaryStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryStatusTransitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SecondaryStatusTransition, SecondaryStatusTransitionUnmarshaller>(SecondaryStatusTransitionUnmarshaller.Instance);
                    unmarshalledObject.SecondaryStatusTransitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = StoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TensorBoardOutputConfig", targetDepth))
                {
                    var unmarshaller = TensorBoardOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.TensorBoardOutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingTimeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TrainingTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TuningJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TuningJobArn = unmarshaller.Unmarshall(context);
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


        private static TrainingJobUnmarshaller _instance = new TrainingJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrainingJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}