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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QApps.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetLibraryItem operation
    /// </summary>  
    public class GetLibraryItemResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetLibraryItemResponse response = new GetLibraryItemResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AppId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("appVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.AppVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("categories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    response.Categories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isRatedByUser", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsRatedByUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isVerified", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsVerified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("libraryItemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LibraryItemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ratingCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.RatingCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.UserCount = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
                {
                    return UnauthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonQAppsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetLibraryItemResponseUnmarshaller _instance = new GetLibraryItemResponseUnmarshaller();        

        internal static GetLibraryItemResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLibraryItemResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}