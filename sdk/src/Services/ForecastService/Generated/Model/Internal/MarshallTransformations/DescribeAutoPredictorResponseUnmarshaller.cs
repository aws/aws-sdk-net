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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAutoPredictor operation
    /// </summary>  
    public class DescribeAutoPredictorResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAutoPredictorResponse response = new DescribeAutoPredictorResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataConfig", targetDepth))
                {
                    var unmarshaller = DataConfigUnmarshaller.Instance;
                    response.DataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetImportJobArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.DatasetImportJobArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionConfig", targetDepth))
                {
                    var unmarshaller = EncryptionConfigUnmarshaller.Instance;
                    response.EncryptionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedTimeRemainingInMinutes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedTimeRemainingInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExplainabilityInfo", targetDepth))
                {
                    var unmarshaller = ExplainabilityInfoUnmarshaller.Instance;
                    response.ExplainabilityInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForecastDimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ForecastDimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForecastFrequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ForecastFrequency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForecastHorizon", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ForecastHorizon = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForecastTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ForecastTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModificationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModificationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptimizationMetric", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OptimizationMetric = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PredictorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PredictorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReferencePredictorSummary", targetDepth))
                {
                    var unmarshaller = ReferencePredictorSummaryUnmarshaller.Instance;
                    response.ReferencePredictorSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
                {
                    return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonForecastServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAutoPredictorResponseUnmarshaller _instance = new DescribeAutoPredictorResponseUnmarshaller();        

        internal static DescribeAutoPredictorResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAutoPredictorResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}