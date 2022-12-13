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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTrailStatus operation
    /// </summary>  
    public class GetTrailStatusResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetTrailStatusResponse response = new GetTrailStatusResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IsLogging", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsLogging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestCloudWatchLogsDeliveryError", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestCloudWatchLogsDeliveryError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestCloudWatchLogsDeliveryTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LatestCloudWatchLogsDeliveryTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDeliveryAttemptSucceeded", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestDeliveryAttemptSucceeded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDeliveryAttemptTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestDeliveryAttemptTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDeliveryError", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestDeliveryError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDeliveryTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LatestDeliveryTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDigestDeliveryError", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestDigestDeliveryError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestDigestDeliveryTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LatestDigestDeliveryTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestNotificationAttemptSucceeded", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestNotificationAttemptSucceeded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestNotificationAttemptTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestNotificationAttemptTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestNotificationError", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LatestNotificationError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestNotificationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LatestNotificationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartLoggingTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartLoggingTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StopLoggingTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StopLoggingTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeLoggingStarted", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimeLoggingStarted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeLoggingStopped", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TimeLoggingStopped = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("CloudTrailARNInvalidException"))
                {
                    return CloudTrailARNInvalidExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidTrailNameException"))
                {
                    return InvalidTrailNameExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OperationNotPermittedException"))
                {
                    return OperationNotPermittedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TrailNotFoundException"))
                {
                    return TrailNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedOperationException"))
                {
                    return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudTrailException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTrailStatusResponseUnmarshaller _instance = new GetTrailStatusResponseUnmarshaller();        

        internal static GetTrailStatusResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTrailStatusResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}