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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetMetricStream operation
    /// </summary>  
    public class GetMetricStreamResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetMetricStreamResponse response = new GetMetricStreamResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludeFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricStreamFilter, MetricStreamFilterUnmarshaller>(MetricStreamFilterUnmarshaller.Instance);
                    response.ExcludeFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirehoseArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FirehoseArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricStreamFilter, MetricStreamFilterUnmarshaller>(MetricStreamFilterUnmarshaller.Instance);
                    response.IncludeFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeLinkedAccountsMetrics", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IncludeLinkedAccountsMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OutputFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatisticsConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricStreamStatisticsConfiguration, MetricStreamStatisticsConfigurationUnmarshaller>(MetricStreamStatisticsConfigurationUnmarshaller.Instance);
                    response.StatisticsConfigurations = unmarshaller.Unmarshall(context);
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
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                var errorTypeName = errorResponse.Code;
                var queryHeaderKey = Amazon.Util.HeaderKeys.XAmzQueryError;
                if (context.ResponseData.IsHeaderPresent(queryHeaderKey))
                {
                    var queryError = context.ResponseData.GetHeaderValue(queryHeaderKey);
                    if (!string.IsNullOrEmpty(queryError) && queryError.Contains(";"))
                    {
                        var queryErrorParts = queryError.Split(';');
                        if (queryErrorParts.Length == 2)
                        {
                            errorResponse.Code = queryErrorParts[0];
                            var errorTypeString = queryErrorParts[1];
                            if (Enum.IsDefined(typeof(ErrorType), errorTypeString))
                            {
                                errorResponse.Type = (ErrorType) Enum.Parse(typeof(ErrorType), errorTypeString);
                            }
                        }
                    }
                }
                if (errorTypeName != null && errorTypeName.Equals("InternalServiceFault"))
                {
                    return InternalServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidParameterCombinationException"))
                {
                    return InvalidParameterCombinationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("MissingRequiredParameterException"))
                {
                    return MissingRequiredParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetMetricStreamResponseUnmarshaller _instance = new GetMetricStreamResponseUnmarshaller();        

        internal static GetMetricStreamResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricStreamResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}