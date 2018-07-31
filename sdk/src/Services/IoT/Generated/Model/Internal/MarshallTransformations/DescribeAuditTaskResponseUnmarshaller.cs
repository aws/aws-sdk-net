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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAuditTask operation
    /// </summary>  
    public class DescribeAuditTaskResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAuditTaskResponse response = new DescribeAuditTaskResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("auditDetails", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, AuditCheckDetails, StringUnmarshaller, AuditCheckDetailsUnmarshaller>(StringUnmarshaller.Instance, AuditCheckDetailsUnmarshaller.Instance);
                    response.AuditDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scheduledAuditName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ScheduledAuditName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TaskStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStatistics", targetDepth))
                {
                    var unmarshaller = TaskStatisticsUnmarshaller.Instance;
                    response.TaskStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskType = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeAuditTaskResponseUnmarshaller _instance = new DescribeAuditTaskResponseUnmarshaller();        

        internal static DescribeAuditTaskResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAuditTaskResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}