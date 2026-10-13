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
    /// Response Unmarshaller for DescribeHyperParameterTuningJob operation.
    /// </summary>
    public partial class DescribeHyperParameterTuningJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeHyperParameterTuningJobResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Autotune", targetDepth, ref reader))
                {
                    var unmarshaller = AutotuneUnmarshaller.Instance;
                    unmarshalledObject.Autotune = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BestTrainingJob", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    unmarshalledObject.BestTrainingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ConsumedResources", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTuningJobConsumedResourcesUnmarshaller.Instance;
                    unmarshalledObject.ConsumedResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CreationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FailureReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameterTuningEndTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameterTuningJobArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameterTuningJobConfig", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTuningJobConfigUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameterTuningJobName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HyperParameterTuningJobStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LastModifiedTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ObjectiveStatusCounters", targetDepth, ref reader))
                {
                    var unmarshaller = ObjectiveStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.ObjectiveStatusCounters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OverallBestTrainingJob", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    unmarshalledObject.OverallBestTrainingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobDefinition", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTrainingJobDefinitionUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobDefinitions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<HyperParameterTrainingJobDefinition, HyperParameterTrainingJobDefinitionUnmarshaller>(HyperParameterTrainingJobDefinitionUnmarshaller.Instance);
                    unmarshalledObject.TrainingJobDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TrainingJobStatusCounters", targetDepth, ref reader))
                {
                    var unmarshaller = TrainingJobStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobStatusCounters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TuningJobCompletionDetails", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTuningJobCompletionDetailsUnmarshaller.Instance;
                    unmarshalledObject.TuningJobCompletionDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("WarmStartConfig", targetDepth, ref reader))
                {
                    var unmarshaller = HyperParameterTuningJobWarmStartConfigUnmarshaller.Instance;
                    unmarshalledObject.WarmStartConfig = unmarshaller.Unmarshall(context, ref reader);
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

        private static DescribeHyperParameterTuningJobResponseUnmarshaller _instance = new DescribeHyperParameterTuningJobResponseUnmarshaller();

        internal static DescribeHyperParameterTuningJobResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeHyperParameterTuningJobResponseUnmarshaller Instance => _instance;
    }
}
