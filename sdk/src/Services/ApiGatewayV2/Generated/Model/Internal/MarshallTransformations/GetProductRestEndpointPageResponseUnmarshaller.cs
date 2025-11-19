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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetProductRestEndpointPage operation
    /// </summary>  
    public class GetProductRestEndpointPageResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetProductRestEndpointPageResponse response = new GetProductRestEndpointPageResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("displayContent", targetDepth))
                {
                    var unmarshaller = EndpointDisplayContentResponseUnmarshaller.Instance;
                    response.DisplayContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModified", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("productRestEndpointPageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProductRestEndpointPageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("productRestEndpointPageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProductRestEndpointPageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rawDisplayContent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RawDisplayContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("restEndpointIdentifier", targetDepth))
                {
                    var unmarshaller = RestEndpointIdentifierUnmarshaller.Instance;
                    response.RestEndpointIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusException", targetDepth))
                {
                    var unmarshaller = StatusExceptionUnmarshaller.Instance;
                    response.StatusException = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tryItState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TryItState = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonApiGatewayV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetProductRestEndpointPageResponseUnmarshaller _instance = new GetProductRestEndpointPageResponseUnmarshaller();        

        internal static GetProductRestEndpointPageResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProductRestEndpointPageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}