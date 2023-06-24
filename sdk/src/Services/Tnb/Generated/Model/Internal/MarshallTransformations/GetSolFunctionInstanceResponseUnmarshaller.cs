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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Tnb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Tnb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetSolFunctionInstance operation
    /// </summary>  
    public class GetSolFunctionInstanceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetSolFunctionInstanceResponse response = new GetSolFunctionInstanceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instantiatedVnfInfo", targetDepth))
                {
                    var unmarshaller = GetSolVnfInfoUnmarshaller.Instance;
                    response.InstantiatedVnfInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instantiationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InstantiationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata", targetDepth))
                {
                    var unmarshaller = GetSolFunctionInstanceMetadataUnmarshaller.Instance;
                    response.Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NsInstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfdId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VnfdId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfdVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VnfdVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfPkgId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VnfPkgId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfProductName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VnfProductName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfProvider", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VnfProvider = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonTnbException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetSolFunctionInstanceResponseUnmarshaller _instance = new GetSolFunctionInstanceResponseUnmarshaller();        

        internal static GetSolFunctionInstanceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSolFunctionInstanceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}