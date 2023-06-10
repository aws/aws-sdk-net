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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTimeSeries operation
    /// </summary>  
    public class DescribeTimeSeriesResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTimeSeriesResponse response = new DescribeTimeSeriesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alias", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Alias = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataTypeSpec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataTypeSpec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("propertyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PropertyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeSeriesArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimeSeriesArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeSeriesCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TimeSeriesCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeSeriesId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimeSeriesId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeSeriesLastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TimeSeriesLastUpdateDate = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeTimeSeriesResponseUnmarshaller _instance = new DescribeTimeSeriesResponseUnmarshaller();        

        internal static DescribeTimeSeriesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTimeSeriesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}