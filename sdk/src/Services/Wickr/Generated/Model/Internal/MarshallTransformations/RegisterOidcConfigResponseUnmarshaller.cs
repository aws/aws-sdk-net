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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RegisterOidcConfig operation
    /// </summary>  
    public class RegisterOidcConfigResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            RegisterOidcConfigResponse response = new RegisterOidcConfigResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applicationId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ApplicationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ApplicationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("caCertificate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CaCertificate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientSecret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClientSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("companyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CompanyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extraAuthParams", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExtraAuthParams = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("issuer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Issuer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redirectUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RedirectUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scopes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Scopes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Secret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ssoTokenBufferMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.SsoTokenBufferMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UserId = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestError"))
                {
                    return BadRequestErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenError"))
                {
                    return ForbiddenErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RateLimitError"))
                {
                    return RateLimitErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundError"))
                {
                    return ResourceNotFoundErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedError"))
                {
                    return UnauthorizedErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationError"))
                {
                    return ValidationErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonWickrException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static RegisterOidcConfigResponseUnmarshaller _instance = new RegisterOidcConfigResponseUnmarshaller();        

        internal static RegisterOidcConfigResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterOidcConfigResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}