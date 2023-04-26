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
    /// Response Unmarshaller for DescribeJobTemplate operation
    /// </summary>  
    public class DescribeJobTemplateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeJobTemplateResponse response = new DescribeJobTemplateResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("abortConfig", targetDepth))
                {
                    var unmarshaller = AbortConfigUnmarshaller.Instance;
                    response.AbortConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("document", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Document = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("documentSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DocumentSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobExecutionsRetryConfig", targetDepth))
                {
                    var unmarshaller = JobExecutionsRetryConfigUnmarshaller.Instance;
                    response.JobExecutionsRetryConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobExecutionsRolloutConfig", targetDepth))
                {
                    var unmarshaller = JobExecutionsRolloutConfigUnmarshaller.Instance;
                    response.JobExecutionsRolloutConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobTemplateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobTemplateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobTemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobTemplateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenanceWindows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MaintenanceWindow, MaintenanceWindowUnmarshaller>(MaintenanceWindowUnmarshaller.Instance);
                    response.MaintenanceWindows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("presignedUrlConfig", targetDepth))
                {
                    var unmarshaller = PresignedUrlConfigUnmarshaller.Instance;
                    response.PresignedUrlConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutConfig", targetDepth))
                {
                    var unmarshaller = TimeoutConfigUnmarshaller.Instance;
                    response.TimeoutConfig = unmarshaller.Unmarshall(context);
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
            return new AmazonIoTException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeJobTemplateResponseUnmarshaller _instance = new DescribeJobTemplateResponseUnmarshaller();        

        internal static DescribeJobTemplateResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobTemplateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}