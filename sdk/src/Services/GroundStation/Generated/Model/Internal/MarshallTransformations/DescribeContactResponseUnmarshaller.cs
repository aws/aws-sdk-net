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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeContact operation
    /// </summary>  
    public class DescribeContactResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeContactResponse response = new DescribeContactResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("contactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contactStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ContactStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataflowList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataflowDetail, DataflowDetailUnmarshaller>(DataflowDetailUnmarshaller.Instance);
                    response.DataflowList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ephemeris", targetDepth))
                {
                    var unmarshaller = EphemerisResponseDataUnmarshaller.Instance;
                    response.Ephemeris = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("groundStation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GroundStation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maximumElevation", targetDepth))
                {
                    var unmarshaller = ElevationUnmarshaller.Instance;
                    response.MaximumElevation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("missionProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MissionProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("postPassEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.PostPassEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("prePassStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.PrePassStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("satelliteArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SatelliteArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trackingOverrides", targetDepth))
                {
                    var unmarshaller = TrackingOverridesUnmarshaller.Instance;
                    response.TrackingOverrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("visibilityEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.VisibilityEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("visibilityStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.VisibilityStartTime = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("DependencyException"))
                {
                    return DependencyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
                {
                    return InvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonGroundStationException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeContactResponseUnmarshaller _instance = new DescribeContactResponseUnmarshaller();        

        internal static DescribeContactResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeContactResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}