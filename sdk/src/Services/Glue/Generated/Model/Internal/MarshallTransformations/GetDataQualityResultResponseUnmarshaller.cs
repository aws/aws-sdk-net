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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDataQualityResult operation
    /// </summary>  
    public class GetDataQualityResultResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDataQualityResultResponse response = new GetDataQualityResultResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CompletedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CompletedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSource", targetDepth))
                {
                    var unmarshaller = DataSourceUnmarshaller.Instance;
                    response.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationContext", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EvaluationContext = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobRunId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobRunId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ResultId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataQualityRuleResult, DataQualityRuleResultUnmarshaller>(DataQualityRuleResultUnmarshaller.Instance);
                    response.RuleResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RulesetEvaluationRunId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RulesetEvaluationRunId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RulesetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RulesetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Score", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.Score = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartedOn = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("EntityNotFoundException"))
                {
                    return EntityNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceException"))
                {
                    return InternalServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
                {
                    return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OperationTimeoutException"))
                {
                    return OperationTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonGlueException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetDataQualityResultResponseUnmarshaller _instance = new GetDataQualityResultResponseUnmarshaller();        

        internal static GetDataQualityResultResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDataQualityResultResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}