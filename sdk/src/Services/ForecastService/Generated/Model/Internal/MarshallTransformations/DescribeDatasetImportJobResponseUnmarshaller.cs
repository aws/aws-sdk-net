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
    /// Response Unmarshaller for DescribeDatasetImportJob operation
    /// </summary>  
    public class DescribeDatasetImportJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeDatasetImportJobResponse response = new DescribeDatasetImportJobResponse();

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
                if (context.TestExpression("DatasetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetImportJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetImportJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetImportJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DatasetImportJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSize", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.DataSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSource", targetDepth))
                {
                    var unmarshaller = DataSourceUnmarshaller.Instance;
                    response.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedTimeRemainingInMinutes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedTimeRemainingInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldStatistics", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Statistics, StringUnmarshaller, StatisticsUnmarshaller>(StringUnmarshaller.Instance, StatisticsUnmarshaller.Instance);
                    response.FieldStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Format", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Format = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeolocationFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GeolocationFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ImportMode = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimestampFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimestampFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimeZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseGeolocationForTimeZone", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.UseGeolocationForTimeZone = unmarshaller.Unmarshall(context);
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

        private static DescribeDatasetImportJobResponseUnmarshaller _instance = new DescribeDatasetImportJobResponseUnmarshaller();        

        internal static DescribeDatasetImportJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDatasetImportJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}