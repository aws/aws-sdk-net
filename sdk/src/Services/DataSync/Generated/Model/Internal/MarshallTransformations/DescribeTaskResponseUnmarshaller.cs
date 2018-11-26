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
    /// Response Unmarshaller for DescribeTask operation
    /// </summary>  
    public class DescribeTaskResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTaskResponse response = new DescribeTaskResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchLogGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CloudWatchLogGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentTaskExecutionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CurrentTaskExecutionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationLocationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DestinationLocationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorDetail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ErrorDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = OptionsUnmarshaller.Instance;
                    response.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceLocationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceLocationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskArn = unmarshaller.Unmarshall(context);
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

        private static DescribeTaskResponseUnmarshaller _instance = new DescribeTaskResponseUnmarshaller();        

        internal static DescribeTaskResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTaskResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}