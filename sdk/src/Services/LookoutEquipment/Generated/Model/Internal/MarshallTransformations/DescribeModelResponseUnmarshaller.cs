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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeModel operation
    /// </summary>  
    public class DescribeModelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeModelResponse response = new DescribeModelResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccumulatedInferenceDataEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.AccumulatedInferenceDataEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AccumulatedInferenceDataStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.AccumulatedInferenceDataStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActiveModelVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ActiveModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ActiveModelVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ActiveModelVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataPreProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = DataPreProcessingConfigurationUnmarshaller.Instance;
                    response.DataPreProcessingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationDataEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EvaluationDataEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationDataStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EvaluationDataStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailedReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailedReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportJobEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ImportJobEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportJobStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ImportJobStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelsInputConfiguration", targetDepth))
                {
                    var unmarshaller = LabelsInputConfigurationUnmarshaller.Instance;
                    response.LabelsInputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestScheduledRetrainingAvailableDataInDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.LatestScheduledRetrainingAvailableDataInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestScheduledRetrainingFailedReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestScheduledRetrainingFailedReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestScheduledRetrainingModelVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.LatestScheduledRetrainingModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestScheduledRetrainingStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LatestScheduledRetrainingStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestScheduledRetrainingStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestScheduledRetrainingStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelDiagnosticsOutputConfiguration", targetDepth))
                {
                    var unmarshaller = ModelDiagnosticsOutputConfigurationUnmarshaller.Instance;
                    response.ModelDiagnosticsOutputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelQuality", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelQuality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelVersionActivatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ModelVersionActivatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextScheduledRetrainingStartDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.NextScheduledRetrainingStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OffCondition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OffCondition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousActiveModelVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.PreviousActiveModelVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousActiveModelVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PreviousActiveModelVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousModelVersionActivatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.PreviousModelVersionActivatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PriorModelMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PriorModelMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetrainingSchedulerStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RetrainingSchedulerStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schema", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Schema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerSideKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServerSideKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceModelVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceModelVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingDataEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TrainingDataEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingDataStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TrainingDataStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingExecutionEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TrainingExecutionEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingExecutionStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TrainingExecutionStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLookoutEquipmentException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeModelResponseUnmarshaller _instance = new DescribeModelResponseUnmarshaller();        

        internal static DescribeModelResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeModelResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618