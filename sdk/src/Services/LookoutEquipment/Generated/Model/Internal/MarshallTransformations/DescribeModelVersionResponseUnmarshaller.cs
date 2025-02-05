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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeModelVersion operation
    /// </summary>  
    public class DescribeModelVersionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeModelVersionResponse response = new DescribeModelVersionResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AutoPromotionResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoPromotionResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AutoPromotionResultReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoPromotionResultReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataPreProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = DataPreProcessingConfigurationUnmarshaller.Instance;
                    response.DataPreProcessingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatasetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatasetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationDataEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.EvaluationDataEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluationDataStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.EvaluationDataStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailedReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailedReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportedDataSizeInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    response.ImportedDataSizeInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportJobEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ImportJobEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportJobStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ImportJobStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelsInputConfiguration", targetDepth))
                {
                    var unmarshaller = LabelsInputConfigurationUnmarshaller.Instance;
                    response.LabelsInputConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastUpdatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelDiagnosticsOutputConfiguration", targetDepth))
                {
                    var unmarshaller = ModelDiagnosticsOutputConfigurationUnmarshaller.Instance;
                    response.ModelDiagnosticsOutputConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelDiagnosticsResultsObject", targetDepth))
                {
                    var unmarshaller = S3ObjectUnmarshaller.Instance;
                    response.ModelDiagnosticsResultsObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelQuality", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelQuality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelVersion", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    response.ModelVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelVersionArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OffCondition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OffCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PriorModelMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PriorModelMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetrainingAvailableDataInDays", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    response.RetrainingAvailableDataInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Schema", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Schema = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServerSideKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServerSideKmsKeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceModelVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceModelVersionArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingDataEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.TrainingDataEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingDataStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.TrainingDataStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingExecutionEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.TrainingExecutionEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingExecutionStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.TrainingExecutionStartTime = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonLookoutEquipmentException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeModelVersionResponseUnmarshaller _instance = new DescribeModelVersionResponseUnmarshaller();        

        internal static DescribeModelVersionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeModelVersionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}