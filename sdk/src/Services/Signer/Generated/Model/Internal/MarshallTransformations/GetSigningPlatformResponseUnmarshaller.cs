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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetSigningPlatform operation
    /// </summary>  
    public class GetSigningPlatformResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetSigningPlatformResponse response = new GetSigningPlatformResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("category", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Category = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxSizeInMB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaxSizeInMB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("partner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Partner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlatformId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revocationSupported", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.RevocationSupported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingConfiguration", targetDepth))
                {
                    var unmarshaller = SigningConfigurationUnmarshaller.Instance;
                    response.SigningConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingImageFormat", targetDepth))
                {
                    var unmarshaller = SigningImageFormatUnmarshaller.Instance;
                    response.SigningImageFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Target = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceErrorException"))
                {
                    return InternalServiceErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSignerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetSigningPlatformResponseUnmarshaller _instance = new GetSigningPlatformResponseUnmarshaller();        

        internal static GetSigningPlatformResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSigningPlatformResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}