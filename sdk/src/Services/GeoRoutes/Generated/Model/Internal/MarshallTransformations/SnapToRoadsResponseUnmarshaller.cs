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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnapToRoads operation
    /// </summary>  
    public class SnapToRoadsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            SnapToRoadsResponse response = new SnapToRoadsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Notices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RoadSnapNotice, RoadSnapNoticeUnmarshaller>(RoadSnapNoticeUnmarshaller.Instance);
                    response.Notices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnappedGeometry", targetDepth))
                {
                    var unmarshaller = RoadSnapSnappedGeometryUnmarshaller.Instance;
                    response.SnappedGeometry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnappedGeometryFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SnappedGeometryFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnappedTracePoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RoadSnapSnappedTracePoint, RoadSnapSnappedTracePointUnmarshaller>(RoadSnapSnappedTracePointUnmarshaller.Instance);
                    response.SnappedTracePoints = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-geo-pricing-bucket"))
                response.PricingBucket = context.ResponseData.GetHeaderValue("x-amz-geo-pricing-bucket");

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonGeoRoutesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SnapToRoadsResponseUnmarshaller _instance = new SnapToRoadsResponseUnmarshaller();        

        internal static SnapToRoadsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapToRoadsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}