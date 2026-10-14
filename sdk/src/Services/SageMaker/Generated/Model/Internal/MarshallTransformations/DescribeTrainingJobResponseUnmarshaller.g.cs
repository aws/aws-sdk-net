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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SageMaker.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTrainingJob operation.
    /// </summary>
    public partial class DescribeTrainingJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeTrainingJobResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AlgorithmSpecification", targetDepth, ref reader))
                {
                    var unmarshaller = AlgorithmSpecificationUnmarshaller.Instance;
                    unmarshalledObject.AlgorithmSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AutoMLJobArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoMLJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BillableTimeInSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.BillableTimeInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BillableTokenCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BillableTokenCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CheckpointConfig", targetDepth, ref reader))
                {
                    var unmarshaller = CheckpointConfigUnmarshaller.Instance;
                    unmarshalledObject.CheckpointConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CreationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DebugHookConfig", targetDepth, ref reader))
                {
                    var unmarshaller = DebugHookConfigUnmarshaller.Instance;
                    unmarshalledObject.DebugHookConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DebugRuleConfigurations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DebugRuleConfiguration, DebugRuleConfigurationUnmarshaller>(DebugRuleConfigurationUnmarshaller.Instance);
                    unmarshalledObject.DebugRuleConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DebugRuleEvaluationStatuses", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DebugRuleEvaluationStatus, DebugRuleEvaluationStatusUnmarshaller>(DebugRuleEvaluationStatusUnmarshaller.Instance);
                    unmarshalledObject.DebugRuleEvaluationStatuses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EnableInterContainerTrafficEncryption", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableInterContainerTrafficEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EnableManagedSpotTraining", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableManagedSpotTraining = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EnableNetworkIsolation", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableNetworkIsolation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Environment", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExperimentConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ExperimentConfigUnmarshaller.Instance;
                    unmarshalledObject.ExperimentConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FailureReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FinalMetricDataList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<MetricData, MetricDataUnmarshaller>(MetricDataUnmarshaller.Instance);
                    unmarshalledObject.FinalMetricDataList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameters", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.HyperParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InfraCheckConfig", targetDepth, ref reader))
                {
                    var unmarshaller = InfraCheckConfigUnmarshaller.Instance;
                    unmarshalledObject.InfraCheckConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InputDataConfig", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Channel, ChannelUnmarshaller>(ChannelUnmarshaller.Instance);
                    unmarshalledObject.InputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LabelingJobArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelingJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LastModifiedTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("MlflowConfig", targetDepth, ref reader))
                {
                    var unmarshaller = MlflowConfigUnmarshaller.Instance;
                    unmarshalledObject.MlflowConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("MlflowDetails", targetDepth, ref reader))
                {
                    var unmarshaller = MlflowDetailsUnmarshaller.Instance;
                    unmarshalledObject.MlflowDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ModelArtifacts", targetDepth, ref reader))
                {
                    var unmarshaller = ModelArtifactsUnmarshaller.Instance;
                    unmarshalledObject.ModelArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ModelPackageConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ModelPackageConfigUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OutputDataConfig", targetDepth, ref reader))
                {
                    var unmarshaller = OutputDataConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputDataConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OutputModelPackageArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputModelPackageArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfilerConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ProfilerConfigUnmarshaller.Instance;
                    unmarshalledObject.ProfilerConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfilerRuleConfigurations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProfilerRuleConfiguration, ProfilerRuleConfigurationUnmarshaller>(ProfilerRuleConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ProfilerRuleConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfilerRuleEvaluationStatuses", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProfilerRuleEvaluationStatus, ProfilerRuleEvaluationStatusUnmarshaller>(ProfilerRuleEvaluationStatusUnmarshaller.Instance);
                    unmarshalledObject.ProfilerRuleEvaluationStatuses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfilingStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfilingStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProgressInfo", targetDepth, ref reader))
                {
                    var unmarshaller = TrainingProgressInfoUnmarshaller.Instance;
                    unmarshalledObject.ProgressInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RemoteDebugConfig", targetDepth, ref reader))
                {
                    var unmarshaller = RemoteDebugConfigUnmarshaller.Instance;
                    unmarshalledObject.RemoteDebugConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ResourceConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ResourceConfigUnmarshaller.Instance;
                    unmarshalledObject.ResourceConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RetryStrategy", targetDepth, ref reader))
                {
                    var unmarshaller = RetryStrategyUnmarshaller.Instance;
                    unmarshalledObject.RetryStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RoleArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SecondaryStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SecondaryStatusTransitions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SecondaryStatusTransition, SecondaryStatusTransitionUnmarshaller>(SecondaryStatusTransitionUnmarshaller.Instance);
                    unmarshalledObject.SecondaryStatusTransitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ServerlessJobConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ServerlessJobConfigUnmarshaller.Instance;
                    unmarshalledObject.ServerlessJobConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StoppingCondition", targetDepth, ref reader))
                {
                    var unmarshaller = StoppingConditionUnmarshaller.Instance;
                    unmarshalledObject.StoppingCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TensorBoardOutputConfig", targetDepth, ref reader))
                {
                    var unmarshaller = TensorBoardOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.TensorBoardOutputConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingEndTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingStartTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingTimeInSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TrainingTimeInSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TuningJobArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TuningJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VpcConfig", targetDepth, ref reader))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("WarmPoolStatus", targetDepth, ref reader))
                {
                    var unmarshaller = WarmPoolStatusUnmarshaller.Instance;
                    unmarshalledObject.WarmPoolStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeTrainingJobResponseUnmarshaller _instance = new DescribeTrainingJobResponseUnmarshaller();

        internal static DescribeTrainingJobResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeTrainingJobResponseUnmarshaller Instance => _instance;
    }
}
