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
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidTrailName"))
            {
                return new InvalidTrailNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("TrailNotFound"))
            {
                return new TrailNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonCloudTrailException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetTrailStatusResponseUnmarshaller _instance = new GetTrailStatusResponseUnmarshaller();        

        internal static GetTrailStatusResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static GetTrailStatusResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}