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
    /// Response Unmarshaller for DescribePredictor operation
    /// </summary>  
    public class DescribePredictorResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribePredictorResponse response = new DescribePredictorResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlgorithmArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AlgorithmArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLAlgorithmArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.AutoMLAlgorithmArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("EvaluationParameters", targetDepth))
                {
                    var unmarshaller = EvaluationParametersUnmarshaller.Instance;
                    response.EvaluationParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeaturizationConfig", targetDepth))
                {
                    var unmarshaller = FeaturizationConfigUnmarshaller.Instance;
                    response.FeaturizationConfig = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("HPOConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobConfigUnmarshaller.Instance;
                    response.HPOConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputDataConfig", targetDepth))
                {
                    var unmarshaller = InputDataConfigUnmarshaller.Instance;
                    response.InputDataConfig = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("PerformAutoML", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.PerformAutoML = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformHPO", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.PerformHPO = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PredictorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorExecutionDetails", targetDepth))
                {
                    var unmarshaller = PredictorExecutionDetailsUnmarshaller.Instance;
                    response.PredictorExecutionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PredictorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.TrainingParameters = unmarshaller.Unmarshall(context);
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

        private static DescribePredictorResponseUnmarshaller _instance = new DescribePredictorResponseUnmarshaller();        

        internal static DescribePredictorResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribePredictorResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}