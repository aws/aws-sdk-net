/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTaskExecution operation
    /// </summary>  
    public class DescribeTaskExecutionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTaskExecutionResponse response = new DescribeTaskExecutionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BytesTransferred", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BytesTransferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BytesWritten", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BytesWritten = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedBytesToTransfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedBytesToTransfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedFilesToTransfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedFilesToTransfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesTransferred", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesTransferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = OptionsUnmarshaller.Instance;
                    response.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Result", targetDepth))
                {
                    var unmarshaller = TaskExecutionResultDetailUnmarshaller.Instance;
                    response.Result = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskExecutionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskExecutionArn = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonDataSyncException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeTaskExecutionResponseUnmarshaller _instance = new DescribeTaskExecutionResponseUnmarshaller();        

        internal static DescribeTaskExecutionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTaskExecutionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}